using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    interface IProgressUI
    {
        event EventHandler<EventArgs> WorkCanceled;
        event EventHandler<EventArgs> DialogShowned;
        void AddSeed(int linesCount);
        void CloseUI();
        void ShowUI();
    }
}
