using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    public partial class FAlgorytmOptions : Form
    {
        public List<DHList> SelectedLists
        {
            get
            {
                return this.checkedListBox1.CheckedItems.Cast<DHList>().ToList();
            }
        }
        public FAlgorytmOptions(List<DHList> lAllLists, List<DHList> lSelectedLists)
        {
            InitializeComponent();

            foreach (DHList list in lAllLists)
            {
                checkedListBox1.Items.Add(list, lSelectedLists.Any(x => x == list));
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
