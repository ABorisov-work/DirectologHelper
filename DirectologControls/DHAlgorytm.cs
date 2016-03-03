using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    public class DHAlgorytm
    {
        private const string _plus = "+";
        public List<DHList> Algorytm { get; set; }
        public DHAlgorytm(List<DHList> algorytm)
        {
            Algorytm = algorytm;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DHList list in Algorytm)
            {
                sb.Append(list.Name);
                sb.Append(_plus);
            }
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
