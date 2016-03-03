using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DirectologControls
{
    class DataWorkerSingleThread : IWorker
    {
        private List<DHAlgorytm> _Algorytms;
        private bool _Canceled = false;
        public event EventHandler<DataCalculatedArgs> DataCalculated;
        public event EventHandler<EventArgs> CalculationsFinished;

        private void OnCalculationsFinished()
        {
            if (CalculationsFinished != null)
                CalculationsFinished(this, null);
        }

        private void OnDataBlockCalculated(StringBuilder data, int linesCount, string algorytmName)
        {
            if (DataCalculated != null)
            {
                DataCalculated(this, new DataCalculatedArgs(data, linesCount, algorytmName));
            }   
        }
        public DataWorkerSingleThread(List<DHAlgorytm> algorytms)
        {
            _Algorytms = algorytms;
        }

        public void Cancel()
        {
            _Canceled = true;
        }

        public void Start()
        {
            Thread thr = new Thread(() =>
            {
                foreach (DHAlgorytm algo in _Algorytms)
                {
                    ProcessAlgorytm("", algo.Algorytm, algo.ToString());
                }
                OnCalculationsFinished();
            });
            thr.Start();
        }
        public void ProcessAlgorytm(string sLeft, List<DHList> lLists, string algorytmName)
        {
            if (_Canceled)
                return;
            if (lLists.Count == 1)
            {
                CreateResult(lLists.Single(), sLeft, algorytmName);
            }
            else
            {
                DHList dhList = lLists.First();
                List<string> lWords = dhList.SplitText();
                List<DHList> InnerLists = lLists.Skip(1).ToList();
                foreach (string word in dhList.SplitText())
                {
                    if (_Canceled)
                        return;
                    string sLeftToSend = string.IsNullOrEmpty(sLeft) ? word : sLeft + " " + word;
                    ProcessAlgorytm(sLeftToSend, InnerLists, algorytmName);
                }
            }
        }
        private void CreateResult(DHList singleList, string sLeft, string algorytmName)
        {
            if (singleList == null || string.IsNullOrEmpty(algorytmName))
                return;
            StringBuilder sbResult = new StringBuilder();
            foreach (string word in singleList.SplitText())
            {
                if (_Canceled)
                    return;
                string sLeftBlock = sLeft.Length == 0 ? word : sLeft + " " + word;
                sbResult.AppendFormat("{0}{1}", sLeftBlock, Environment.NewLine);
            }
            if (_Canceled)
                return;
            OnDataBlockCalculated(sbResult, singleList.SplitText().Count, algorytmName);
        }
    }
}
