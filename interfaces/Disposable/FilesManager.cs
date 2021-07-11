using System;
using System.IO;

namespace lemure.interfaces.Disposable
{
    class FilesManager : IDisposable
    {
        FileStream fs;

        public FilesManager(string path)
        {
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void Write(byte[] data)
        {
            fs.Write(data, 0, data.Length);
        }

        public void Dispose()
        {
            fs.Close();
        }
    }
}
