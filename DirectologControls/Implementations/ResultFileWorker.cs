using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DirectologControls
{
    class ResultFileWorker : IResultWorker
    {
        private ConcurrentQueue<FileData> _Queue = new ConcurrentQueue<FileData>();
        private string _FolderName;
        private enum WorkStatusses
        {
            None,
            Canceled,
            InProgress,
            Done
        }
        private WorkStatusses WorkStatuss = WorkStatusses.None;
        public ResultFileWorker(string folderName)
        {
            _FolderName = folderName;
        }

        public void AddResultData(StringBuilder data, string algorytmName)
        {
            FileData fd = new FileData(data, algorytmName);
            _Queue.Enqueue(fd);
        }

        public void Cancel()
        {
            WorkStatuss = WorkStatusses.Canceled;
        }

        public void Finish()
        {
            WorkStatuss = WorkStatusses.Done;
        }

        public void Start()
        {
            WorkStatuss = WorkStatusses.InProgress;
            ThreadPool.QueueUserWorkItem(WriteDataToFiles);
        }
        private void WriteDataToFiles(object nullObject)
        {
            if (WorkStatuss == WorkStatusses.Canceled)
                return;
            while (_Queue.Any())
            {
                FileData fileData;
                if (_Queue.TryDequeue(out fileData))
                {
                    File.AppendAllText(CreateFilePath(fileData.AlgorytmName), fileData.Data.ToString());
                }
            }
            if (WorkStatuss == WorkStatusses.Done)
                return;
            ThreadPool.QueueUserWorkItem(WriteDataToFiles);
        }
        private string CreateFilePath(string algorytmName)
        {
            return Path.Combine(_FolderName, algorytmName + ".txt");
        }
    }
    struct FileData
    {
        public StringBuilder Data { get; private set; }
        public string AlgorytmName { get; private set; }
        public FileData(StringBuilder data, string algorytmName)
        {
            Data = data;
            AlgorytmName = algorytmName;
        }
    }
}
