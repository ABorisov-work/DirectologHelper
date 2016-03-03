using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    interface IResultWorker
    {
        void Start();
        void Cancel();
        void AddResultData(StringBuilder data, string algorytmName);
        void Finish();
    }
}
