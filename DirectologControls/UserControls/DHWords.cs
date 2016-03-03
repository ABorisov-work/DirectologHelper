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
    public partial class DHWords : UserControl
    {
        private const string _TitleBase = "Слова списка ";
        private DHList _DHList;
        //public List<string> Words {
        //    get {
        //        return tbWords.Text.Split(
        //            new string[] { Environment.NewLine }, 
        //            StringSplitOptions.RemoveEmptyEntries).ToList();
        //    }
        //}
        private bool bChangind = false;
        [Browsable(true)]
        public DHLists ListControl { get { return _ListControl; }
            set
            {
                if (_ListControl != null)
                {
                    _ListControl.SelectedListChanged -= _ListControl_SelectedListChanged;
                }
                _ListControl = value;
                if(_ListControl != null)
                    _ListControl.SelectedListChanged += _ListControl_SelectedListChanged;
            }
        }

        private void _ListControl_SelectedListChanged(object sender, DHListArgs e)
        {
            if (e.DHList == _DHList)
                return;
            _DHList = e.DHList;
            this.lTitle.Text = _TitleBase + e.DHList.Name;
            bChangind = true;
            this.tbWords.Text = this._DHList.Text;
            bChangind = false;
        }

        private DHLists _ListControl;

        public DHWords()
        {
            InitializeComponent();
        }

        private void tbWords_TextChanged(object sender, EventArgs e)
        {
            if (this._DHList != null && !bChangind)
            {
                this._DHList.Text = tbWords.Text;
                this._DHList.TextSplited = false;
            }
        }
    }
}
