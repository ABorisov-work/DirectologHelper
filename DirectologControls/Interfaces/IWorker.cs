using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    interface IWorker
    {
        event EventHandler<DataCalculatedArgs> DataCalculated;
        event EventHandler<EventArgs> CalculationsFinished;
        void Start();
        void Cancel();
    }
}
