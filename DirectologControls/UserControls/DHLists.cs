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
    public partial class DHLists : UserControl
    {
        private object _selectedMenuItem;
        private object _MainList = null;
        public object MainList {
            get { return _MainList; }
        }

        public List<DHList> Lists
        {
            get
            {
                return this.lbLists.Items.Cast<DHList>().ToList();
            }
        }
        public DHLists()
        {
            InitializeComponent();
        }
        public event EventHandler<DHListArgs> SelectedListChanged;
        private void OnSelectedListChanged(DHList dhList)
        {
            if (SelectedListChanged != null)
            {
                SelectedListChanged(this, new DHListArgs(dhList));
            }
        }

        public event EventHandler<EventArgs> ListsChanged;
        private void OnListsChanged()
        {
            if (ListsChanged != null)
            {
                ListsChanged(this, null);
            }
        }

        private void lbLists_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    int idx = lbLists.IndexFromPoint(e.Location);
                    if (idx != ListBox.NoMatches)
                    {
                        _selectedMenuItem = lbLists.Items[idx];
                        cmsActions.Show(Cursor.Position);
                        cmsActions.Visible = true;
                    }
                    break;
                case MouseButtons.Left:
                    if (lbLists.Items.Count == 0)
                        return;
                    int index = lbLists.IndexFromPoint(e.X, e.Y);
                    if (lbLists.Items.Count <= index || index < 0)
                        return;
                    object item = lbLists.Items[index];
                    _selectedMenuItem = lbLists.Items[index];
                    DragDropEffects dde = DoDragDrop(item, DragDropEffects.All);
                    break;
            }
            lbLists_SelectedValueChanged(this, e);
        }

        private void addListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void AddList()
        {
            FListName fln = new FListName();
            if (fln.ShowDialog() == DialogResult.OK)
            {
                DHList newList = new DHList(fln.ListName);
                lbLists.Items.Add(newList);
                if(lbLists.Items.Count == 1)
                    this._MainList = newList;
            }
            return;

            char startChar = 'a';
            if (lbLists.Items.Count == 0)
            {
                DHList newList = new DHList(startChar.ToString());
                lbLists.Items.Add(newList);
                this._MainList = newList;
            }
            else
            {
                List<DHList> lLists = lbLists.Items.Cast<DHList>().ToList();
                int cIndex = 0;
                string sStartChar;
                while (true)
                {
                    sStartChar = startChar.ToString() + (cIndex == 0 ? "" : cIndex.ToString());
                    if (lLists.Any(x => x.Name == sStartChar))
                    {
                        if (startChar == 'z')
                        {
                            startChar = 'a';
                            cIndex++;
                        }
                        else
                        {
                            startChar++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                lbLists.Items.Add(new DHList(sStartChar));
            }
            OnListsChanged();
        }

        private void removeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveList();
        }

        private void RemoveList()
        {
            if (_selectedMenuItem == null)
                return;
            lbLists.Items.Remove(_selectedMenuItem);
            _selectedMenuItem = null;
            OnListsChanged();
        }

        private void lbLists_SelectedValueChanged(object sender, EventArgs e)
        {
            DHList dhList = lbLists.SelectedItem as DHList;
            if (dhList != null)
                OnSelectedListChanged(dhList);
        }

        private void lbLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setListAsMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAsMainList();
        }

        private void SetAsMainList()
        {
            if (_selectedMenuItem == null)
                return;
            this._MainList = _selectedMenuItem as DHList;
            lbLists.Items.Remove(_selectedMenuItem);
            lbLists.Items.Insert(0, _selectedMenuItem);
            _selectedMenuItem = null;
            this.OnListsChanged();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            RemoveList();
        }

        private void btnSetAsMain_Click(object sender, EventArgs e)
        {
            SetAsMainList();
        }
    }
}
