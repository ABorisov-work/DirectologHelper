using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    class ResultTextBoxWorker : IResultWorker
    {
        private RichTextBox _TextBox;
        private ConcurrentQueue<FileData> _Queue = new ConcurrentQueue<FileData>();
        public ResultTextBoxWorker(RichTextBox tb)
        {
            _TextBox = tb;
        }
        public void AddResultData(StringBuilder data, string algorytmName)
        {
            FileData fd = new FileData(data, algorytmName);
            _Queue.Enqueue(fd);
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
            while (_Queue.Any())
            {
                FileData fd;
                if (_Queue.TryDequeue(out fd))
                {
                    sbResult.Append(fd.Data);
                }
            }
            return sbResult.ToString();
        }

        public void Start()
        {
            return;
        }
    }
}
