using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    public partial class FListName : Form
    {
        private string _Name;
        public string ListName {
            get { return _Name; }
        }
        public FListName()
        {
            InitializeComponent();
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            SetNameFromButton((Button)sender);
        }
        private void SetNameFromButton(Button btn)
        {
            _Name = (btn.Text.Substring(2));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _Name = tbName.Text;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //if (tbName.Text.Length == 1 && Regex.IsMatch(tbName.Text, "[0-9]"))
            //{
            //    MessageBox.Show("true");
            //}

            btnOk.Enabled = !string.IsNullOrEmpty(tbName.Text);
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                if ((e.KeyData & Keys.D0) == Keys.D0)
                {
                    List<Button> lButtons = groupBox1.Controls.OfType<Button>().ToList();
                    foreach (Button btn in lButtons)
                    {
                        if (btn.Text[0] == e.KeyData.ToString()[1])
                        {
                            SetNameFromButton(btn);
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
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
