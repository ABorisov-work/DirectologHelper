using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectologControls
{
    class ResultFileWorkerSingleThread : IResultWorker
    {
        private string _FolderName;

        public ResultFileWorkerSingleThread(string folderName)
        {
            _FolderName = folderName;
        }

        public void AddResultData(StringBuilder data, string algorytmName)
        {
            File.AppendAllText(CreateFilePath(algorytmName), data.ToString());
        }

        public void Cancel()
        {
            return;
        }

        public void Finish()
        {
            return;
        }

        public void Start()
        {
            return;
        }
        private string CreateFilePath(string algorytmName)
        {
            return Path.Combine(_FolderName, algorytmName + ".txt");
        }
    }
}
