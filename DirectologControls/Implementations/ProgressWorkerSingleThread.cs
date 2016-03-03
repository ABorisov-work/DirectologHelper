using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    class ProgressWorkerSingleThread : IProgressUI
    {
        private int _Divider;
        private FProrgess _Window;
        private int _countOfRequests = 0;
        private int _countToAdd = 0;
        public ProgressWorkerSingleThread(int max, int divider, long totalBytes)
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
            _countToAdd += newLineCount;
            _countOfRequests++;
            if (_countOfRequests == 10)
            {
                // Invoke
                _countOfRequests = 0;
                IncrementProgress();
            }
        }
        private void IncrementProgress()
        {
            InvokeRepaint(_countToAdd);
            _countToAdd = 0;
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
