using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    class DataAnalyser
    {
        /// <summary>
        /// Calculate bytes count for list of algorytms
        /// </summary>
        /// <param name="lAlgos"></param>
        /// <returns></returns>
        public static List<AnalyseData> CalculateBytesForAlgoList(List<DHAlgorytm> lAlgos)
        {
            List<AnalyseData> lResult = lAlgos.Select(x => CalculateBytesForAlrorytm(x)).ToList();
            return lResult;
        }
        /// <summary>
        /// Calculate bytes count for one algorytm
        /// </summary>
        /// <param name="algo"></param>
        /// <returns></returns>
        public static AnalyseData CalculateBytesForAlrorytm(DHAlgorytm algo)
        {
            List<int> iaverages = new List<int>();
            long lLineCount = 1;
            algo.Algorytm.ForEach(y =>
            {
                int lineCount = y.SplitText().Count;
                if (lineCount == 0)
                    return;
                lLineCount *= lineCount;
                iaverages.Add((int)y.SplitText().Average(z => z.Length));
            });
            if (!iaverages.Any())
                return new AnalyseData(0, 0, algo);
            int averageWordLength = (int)iaverages.Average();
            long blocksInAllLines = lLineCount * algo.Algorytm.Count;
            long spaceCount = blocksInAllLines;
            long symbolsCount = (blocksInAllLines * averageWordLength) + spaceCount;
            int bytesPerSymbol = 2;
            long byteSize = (long)(symbolsCount * bytesPerSymbol);
            AnalyseData result = new AnalyseData(byteSize, lLineCount, algo);
            return result;
        }
    }
    class AnalyseData
    {
        public long BytesCount { get; private set; }
        public long LinesCount { get; private set; }
        public DHAlgorytm Algorytm { get; private set; }
        public AnalyseData(long bytesCount, long linesCount, DHAlgorytm algo)
        {
            BytesCount = bytesCount;
            LinesCount = linesCount;
            Algorytm = algo;
        }
    }
}
