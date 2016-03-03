using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    class ResultTextBoxWorkerSingleThread : IResultWorker
    {
        private RichTextBox _TextBox;
        private List<StringBuilder> _DataCollection = new List<StringBuilder>();
        public ResultTextBoxWorkerSingleThread(RichTextBox tb)
        {
            _TextBox = tb;
        }
        public void AddResultData(StringBuilder data, string algorytmName)
        {
            _DataCollection.Add(data);
        }

        public void Cancel()
        {
            return;
        }

        public void Finish()
        {
            string resultText = GetResultText();
            if (_TextBox.InvokeRequired)
            {
                _TextBox.Invoke((Action)(() => { _TextBox.Text = resultText; }));
            }
            else
            {
                _TextBox.Text = resultText;
            }
        }
        private string GetResultText()
        {
            StringBuilder sbResult = new StringBuilder();
            _DataCollection.ForEach(x => sbResult.Append(x));
            return sbResult.ToString();
        }

        public void Start()
        {
            return;
        }
    }
}
