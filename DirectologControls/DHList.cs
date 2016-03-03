using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    public class DHList
    {
        private static readonly string[] _separeteChars = new string[] { Environment.NewLine , "\r\n", "\\r", "\\n",/*" ",*/ "\r", "\n", /*"\t"*/ };
        public bool TextSplited { get; set; }
        private List<string> _SplitedText;
        private string _Name;
        public string Name { get { return _Name; } }

        public string Text { get; set; }

        public DHList(string name)
        {
            _Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public List<string> SplitText()
        {
            if (!TextSplited)
            {
                if (Text != null)
                {
                    _SplitedText = Text.Split(_separeteChars, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                }
                else
                {
                    _SplitedText = new List<string>();
                }
                TextSplited = true;
            }
            return _SplitedText;
        }
    }
}
