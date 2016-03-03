using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    public partial class FProrgess : Form
    {
        public event EventHandler<EventArgs> WorkCanceled;
        public FProrgess()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnWorkCanceled();
        }
        private void OnWorkCanceled()
        {
            if (WorkCanceled != null)
                WorkCanceled(this, null);
        }
        public void SetMaxValue(int value)
        {
            this.progressBar1.Maximum = value;
        }
        public void SetLabelTotalBytes(long totalBytes)
        {
            lbBytesTotal.Text = totalBytes.ToString("N0");
        }
        public bool ControlsInvokeRequired()
        {
            return this.InvokeRequired;
        }
        public bool DisposedOrHandleNotCreated()
        {
            return this.Disposing || progressBar1.IsDisposed || !progressBar1.IsHandleCreated;
        }
        public void AddProgressValue(int value)
        {
            this.progressBar1.Value += value;
        }
        #region Перемещение формы по клику мыши
        private bool _NeedToMoove = false;
        private Point _OldCursorLocation = Point.Empty;
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _OldCursorLocation = e.Location;
                _NeedToMoove = true;
            }
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (_NeedToMoove)
            {
                Point newPoint = new Point(this.Left + e.X - _OldCursorLocation.X, this.Top + e.Y - _OldCursorLocation.Y);
                this.Location = newPoint;
            }
        }
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            _NeedToMoove = false;
        }
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            _NeedToMoove = false;
        }
        #endregion
    }
}
