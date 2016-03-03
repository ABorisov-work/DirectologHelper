using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    public class DHListArgs
    {
        public DHList DHList { get; private set; }
        public DHListArgs(DHList dhList)
        {
            DHList = dhList;
        }
    }
    public class DHAlgorytmArgs
    {
        public DHAlgorytm Algorytm { get; private set; }
        public DHAlgorytmArgs(DHAlgorytm algo)
        {
            Algorytm = algo;
        }
    }
    public class DHBlockWriteDone
    {
        public int Size { get; private set; }
        public DHBlockWriteDone(int size)
        {
            Size = size;
        }
    }
    public class DHDataBlockCalculatedArgs : EventArgs
    {
        public StringBuilder Data { get; set; }
        public int LinesCount { get; set; }
        public string FileName { get; private set; }
        public DHDataBlockCalculatedArgs(StringBuilder data, int linesCount, string fileName)
        {
            Data = data;
            LinesCount = linesCount;
            FileName = fileName;
        }
    }
    public class DataCalculatedArgs : EventArgs
    {
        public StringBuilder Data { get; private set; }
        public int LinesCount { get; private set; }
        public string AlgorytmName { get; private set; }
        public DataCalculatedArgs(StringBuilder data, int linesCount, string algorytmName)
        {
            Data = data;
            LinesCount = linesCount;
            AlgorytmName = algorytmName;
        }
    }
}
