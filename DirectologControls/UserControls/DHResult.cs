using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DirectologControls
{
    public partial class DHResult : UserControl
    {
        [Browsable(true)]
        public DHAlgoritms DHAlgorytms { get { return _DHAlgorytms; }
            set
            {
                if (_DHAlgorytms != null)
                    _DHAlgorytms.AlgorytmSelected -= _DHAlgorytms_AlgorytmSelected;
                _DHAlgorytms = value;
                if(_DHAlgorytms != null)
                    _DHAlgorytms.AlgorytmSelected += _DHAlgorytms_AlgorytmSelected;
            }
        }
        private DHAlgoritms _DHAlgorytms;
        private DHAlgorytm _Algorytm;

        private void _DHAlgorytms_AlgorytmSelected(object sender, DHAlgorytmArgs e)
        {
            _Algorytm = e.Algorytm;
            if (cbAutoProc.Checked)
            {
                StartProcess(new List<DHAlgorytm>() { _Algorytm }, cbToFile.Checked);
            }
        }

        
        public DHResult()
        {
            InitializeComponent();
            cbThreading.SelectedIndex = 0;
        }

        private void ProccedAll_Click(object sender, EventArgs e)
        {
            if (_DHAlgorytms == null || _DHAlgorytms.Algoritms.Count == 0)
            {
                MessageBox.Show("Не найдено ни одного алгоритма!");
                return;
            }
            StartProcess(_DHAlgorytms.Algoritms, cbToFile.Checked);
        }

        private void btnProccedOne_Click(object sender, EventArgs e)
        {
            if (_Algorytm == null)
            {
                MessageBox.Show("Не выбран ни один алгоритм!");
                return;
            }
            StartProcess(new List<DHAlgorytm>() { _Algorytm }, cbToFile.Checked);
        }

        private void StartProcess(List<DHAlgorytm> lAlgorytms, bool bToFile)
        {
            IWorker worker;
            IProgressUI progressUI;
            IResultWorker resultWorker;
            if (bToFile)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderName = fbd.SelectedPath;
                    resultWorker = GetResultFileWorker(folderName);
                }
                else
                {
                    return;
                }
            }
            else
            {
                textBox1.Text = "";
                resultWorker = GetResultTextBoxWorker(this.textBox1);
            }
            List<AnalyseData> lAnalyseData = DataAnalyser.CalculateBytesForAlgoList(lAlgorytms);
            long totalBytes = lAnalyseData.Sum(x => x.BytesCount);
            long linesCount = lAnalyseData.Sum(x => x.LinesCount);
            int iMaxValue;
            int divider = 0;

            while (linesCount > Int32.MaxValue)
            {
                divider++;
                linesCount /= 10;
            }
            divider *= 10;
            iMaxValue = (int)linesCount;
            progressUI = GetProgress(iMaxValue, divider, totalBytes);
            worker = GetWorker(lAlgorytms);
            WorkController controller = new WorkController(worker, progressUI, resultWorker);
            controller.StartWork();
        }

        private IWorker GetWorker(List<DHAlgorytm> lAlgorytms)
        {
            if (cbThreading.SelectedIndex == 0)
            {
                return new DataWorkerSingleThread(lAlgorytms);
            }
            else if (cbThreading.SelectedIndex == 1)
            {
                return new DataWorker(lAlgorytms);
            }
            else
            {
                return null;
            }
        }
        private IProgressUI GetProgress(int iMaxValue, int divider, long totalBytes)
        {
            if (cbThreading.SelectedIndex == 0)
            {
                return new ProgressWorkerSingleThread(iMaxValue, divider, totalBytes);
            }
            else if (cbThreading.SelectedIndex == 1)
            {
                return new ProgressWorker(iMaxValue, divider, totalBytes);
            }
            else
            {
                return null;
            }
        }
        private IResultWorker GetResultFileWorker(string folderName)
        {
            if (cbThreading.SelectedIndex == 0)
            {
                return new ResultFileWorkerSingleThread(folderName);
            }
            else if (cbThreading.SelectedIndex == 1)
            {
                return new ResultFileWorker(folderName);
            }
            else
            {
                return null;
            }
        }
        private IResultWorker GetResultTextBoxWorker(RichTextBox tb)
        {
            if (cbThreading.SelectedIndex == 0)
            {
                return new ResultTextBoxWorkerSingleThread(tb);
            }
            else if (cbThreading.SelectedIndex == 1)
            {
                return new ResultTextBoxWorker(tb);
            }
            else
            {
                return null;
            }
        }
    }
}
