using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DirectologControls
{
    class DataWorker : IWorker
    {
        private List<DHAlgorytm> _Algorytms;
        private bool _Canceled = false;
        public event EventHandler<DataCalculatedArgs> DataCalculated;
        public event EventHandler<EventArgs> CalculationsFinished;

        private bool _GroundWorkDone = false;
        private int _TasksCount = 0;

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
            Interlocked.Decrement(ref _TasksCount);
            if(_GroundWorkDone && _TasksCount == 0)
                OnCalculationsFinished();
        }
        public DataWorker(List<DHAlgorytm> algorytms)
        {
            _Algorytms = algorytms;
        }

        public void Cancel()
        {
            _Canceled = true;
        }

        public void Start()
        {
            ThreadPool.QueueUserWorkItem(BeginProcess);
        }
        private void BeginProcess(object fake)
        {
            foreach (DHAlgorytm algo in _Algorytms)
            {
                ProcessAlgorytm("", algo.Algorytm, algo.ToString());
            }
            _GroundWorkDone = true;
        }
        public void ProcessAlgorytm(string sLeft, List<DHList> lLists, string algorytmName)
        {
            if (_Canceled)
                return;
            if (lLists.Count == 1)
            {
                object[] sendData = new object[3];
                sendData[0] = lLists.Single();
                sendData[1] = sLeft;
                sendData[2] = algorytmName;
                Interlocked.Increment(ref _TasksCount);
                ThreadPool.QueueUserWorkItem(CreateResult, sendData);
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
        private void CreateResult(object o)
        {
            
            object[] inputData = o as object[];
            if (inputData == null || inputData.Length < 3)
                return;
            DHList singleList = inputData[0] as DHList;
            string sLeft = inputData[1] as string;
            string algorytmName = inputData[2] as string;
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
