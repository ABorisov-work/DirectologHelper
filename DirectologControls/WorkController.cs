using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    class WorkController
    {
        IWorker _Worker;
        IProgressUI _ProgressUI;
        IResultWorker _ResultWorker;
        private bool IsCanceled = false;
        private bool IsDone = false;
        private object _locker = new object();
        public WorkController(IWorker worker, IProgressUI progressUI, IResultWorker resultWorker)
        {
            _Worker = worker;
            _ProgressUI = progressUI;
            _ResultWorker = resultWorker;
            progressUI.WorkCanceled += ProgressUI_WorkCanceled;
            worker.DataCalculated += Worker_DataCalculated;
            worker.CalculationsFinished += Worker_CalculationsFinished;
        }

        private void Worker_CalculationsFinished(object sender, EventArgs e)
        {
            _ResultWorker.Finish();
            if (IsCanceled)
                return;
            lock (_locker)
            {
                if (IsCanceled)
                    return;
                IsDone = true;
                _ProgressUI.CloseUI();
            }
        }

        public void StartWork()
        {
            _ResultWorker.Start();
            _ProgressUI.DialogShowned += _ProgressUI_DialogShowned;
            _ProgressUI.ShowUI();
        }

        private void _ProgressUI_DialogShowned(object sender, EventArgs e)
        {
            _Worker.Start();
        }

        private void Worker_DataCalculated(object sender, DataCalculatedArgs e)
        {
            _ResultWorker.AddResultData(e.Data, e.AlgorytmName);
            _ProgressUI.AddSeed(e.LinesCount);
        }

        private void ProgressUI_WorkCanceled(object sender, EventArgs e)
        {
            if (IsDone)
                return;
            lock (_locker)
            {
                if (IsDone)
                    return;
                IsCanceled = true;
                _Worker.Cancel();
                _ResultWorker.Finish();
                Thread.Sleep(200);
                _ProgressUI.CloseUI();
            }
        }
    }
}
