using FishTank.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Infrastructure.FileStore
{
    public class FileStore : IFileStore
    {
        private readonly IFileStore _fileStore;
        private readonly IDirectoryWrapper _directoryWrapper;
        private readonly IFileWrapper _fileWrapper;

        public FileStore(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper)
        {
            _fileWrapper = fileWrapper;
            _directoryWrapper = directoryWrapper;
        }


        public string SafeWriteFile(byte[] content, string sourceFileName, string path)
        {
            _directoryWrapper.CreateDirectory(path);
            var outputFile = Path.Combine(path, sourceFileName);
            _fileWrapper.WriteAllBytes(outputFile, content);
            return outputFile;
        }

    }
  
}
