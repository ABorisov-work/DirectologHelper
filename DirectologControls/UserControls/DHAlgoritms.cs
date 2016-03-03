using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectologControls
{
    public partial class DHAlgoritms : UserControl
    {
        private object _selectedMenuItem;
        [Browsable(true)]
        public DHLists DHLists
        {
            get;
            set;
        }
        public event EventHandler<DHAlgorytmArgs> AlgorytmSelected;
        private void OnAlgorytmSelected(DHAlgorytm algo)
        {
            if (AlgorytmSelected != null && algo != null)
            {
                AlgorytmSelected(this, new DHAlgorytmArgs(algo));
            }
        }

        public List<DHAlgorytm> Algoritms {
            get {
                return lbAlgorytms.Items.Cast<DHAlgorytm>().ToList();
            }
        }

        public DHAlgoritms()
        {
            InitializeComponent();
        }

        private void addAlgorytmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlgoritm();
        }

        private void AddAlgoritm()
        {
            if (DHLists == null || DHLists.Lists.Count == 0)
                return;
            FAlgorytmOptions fo = new FAlgorytmOptions(DHLists.Lists, new List<DHList>());
            if (fo.ShowDialog() == DialogResult.OK)
            {
                if (fo.SelectedLists.Any())
                {
                    DHAlgorytm dhAlgo = new DHAlgorytm(fo.SelectedLists);
                    lbAlgorytms.Items.Add(dhAlgo);
                }
            }
        }

        private void removeAlgorytmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAlgoritm();
        }

        private void RemoveAlgoritm()
        {
            if (_selectedMenuItem == null)
                return;
            lbAlgorytms.Items.Remove(_selectedMenuItem);
            _selectedMenuItem = null;
        }

        private void lbAlgorytms_MouseDown(object sender, MouseEventArgs e)
        {
            int idx = lbAlgorytms.IndexFromPoint(e.Location);
            if (idx != ListBox.NoMatches)
            {
                _selectedMenuItem = lbAlgorytms.Items[idx];
            }
            else
            {
                _selectedMenuItem = null;
            }
            switch (e.Button)
            {
                case MouseButtons.Right:
                    if (_selectedMenuItem != null)
                    {
                        cmsActions.Show(Cursor.Position);
                        cmsActions.Visible = true;
                    }
                    OnAlgorytmSelected(_selectedMenuItem as DHAlgorytm);
                    break;
            }
        }

        private void editAlgorytmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAlgoritm();
        }

        private void EditAlgoritm()
        {
            if (_selectedMenuItem == null)
                return;

            if (DHLists == null || DHLists.Lists.Count == 0)
                return;
            DHAlgorytm selectedAlgo = _selectedMenuItem as DHAlgorytm;
            if (selectedAlgo == null)
                return;
            FAlgorytmOptions fo = new FAlgorytmOptions(DHLists.Lists, selectedAlgo.Algorytm);
            if (fo.ShowDialog() == DialogResult.OK)
            {
                selectedAlgo.Algorytm = fo.SelectedLists;
                int index = lbAlgorytms.Items.IndexOf(selectedAlgo);
                lbAlgorytms.Items.Remove(selectedAlgo);
                lbAlgorytms.Items.Insert(index, selectedAlgo);
            }

            _selectedMenuItem = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbAlgorytms.Items.Clear();
        }

        private void btnCreateAlgos_Click(object sender, EventArgs e)
        {
            if (DHLists.MainList != null)
            {
                DHList mainList = DHLists.MainList as DHList;
                foreach (DHList list in DHLists.Lists)
                {
                    if (list != mainList)
                    {
                        DHAlgorytm dhAlgo = new DHAlgorytm(new List<DHList>() { mainList, list});
                        lbAlgorytms.Items.Add(dhAlgo);
                    }
                }
            } 
        }

        private void lbAlgorytms_SelectedValueChanged(object sender, EventArgs e)
        {
            DHAlgorytm algo = lbAlgorytms.SelectedItem as DHAlgorytm;
            if (algo != null)
                OnAlgorytmSelected(algo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAlgoritm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveAlgoritm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAlgoritm();
        }
    }
}
