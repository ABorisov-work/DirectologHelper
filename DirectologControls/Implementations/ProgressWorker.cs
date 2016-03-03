using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DirectologControls
{
    class ProgressWorker : IProgressUI
    {
        private int _Divider;
        private ConcurrentQueue<int> _ProgressCollection = new ConcurrentQueue<int>();
        private int _countOfRequests = 0;
        //private SimpleSpinBlock _Block = new SimpleSpinBlock();
        private FProrgess _Window;
        public ProgressWorker(int max, int divider, long totalBytes)
        {
            _Divider = divider;
            _Window = new FProrgess();
            _Window.SetMaxValue(max);
            _Window.SetLabelTotalBytes(totalBytes);
            _Window.Shown += FProrgessLongWorker_Shown;
            _Window.WorkCanceled += _Window_WorkCanceled;
        }

        private void _Window_WorkCanceled(object sender, EventArgs e)
        {
            OnWorkCanceled();
        }

        private void FProrgessLongWorker_Shown(object sender, EventArgs e)
        {
            OnDialogShowned();
        }

        public event EventHandler<EventArgs> WorkCanceled;
        public event EventHandler<EventArgs> DialogShowned;
        private void OnDialogShowned()
        {
            if (DialogShowned != null)
                DialogShowned(this, null);
        }

        private void OnWorkCanceled()
        {
            if (WorkCanceled != null)
                WorkCanceled(this, null);
        }

        public void AddSeed(int linesCount)
        {
            int newLineCount = linesCount;
            if (_Divider != 0)
            {
                newLineCount = linesCount / _Divider;
            }

            _ProgressCollection.Enqueue(newLineCount);

            int cor = Interlocked.Increment(ref _countOfRequests);
            if (cor >= 10)
            {
                // Invoke
                Interlocked.Add(ref _countOfRequests, -10);
                ThreadPool.QueueUserWorkItem(IncrementProgress);
            }
        }
        private void IncrementProgress(object fake)
        {
            int newLineCount = 0;
            if (_ProgressCollection.Count < 10)
                return;
            for (int i = 0; i < 10; i++)
            {
                int takenInt;
                if (_ProgressCollection.TryDequeue(out takenInt))
                {
                    newLineCount += takenInt;
                }
            }
            InvokeRepaint(newLineCount);
        }

        private void InvokeRepaint(int newLineCount)
        {
            if (_Window.ControlsInvokeRequired())
            {
                if (_Window.DisposedOrHandleNotCreated())
                    return;
                try
                {
                    _Window.Invoke((Action)(() => _Window.AddProgressValue(newLineCount)));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
            }
            else
            {
                _Window.AddProgressValue(newLineCount);
            }
        }

        public void CloseUI()
        {
            if (_Window.ControlsInvokeRequired())
            {
                if (_Window.DisposedOrHandleNotCreated())
                    return;
                try
                {
                    _Window.Invoke((Action)(() => _Window.Close()));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
            }
            else
            {
                _Window.Close();
            }
        }

        public void ShowUI()
        {
            // ToDo: Maybe here should be cycle with Thread.Seep (In other places)
            _Window.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnWorkCanceled();
        }
    }
}
