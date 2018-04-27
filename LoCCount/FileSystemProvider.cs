using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoCCount
{
    class FileSystemProvider
    {
        public IEnumerable<string> FindSourceFiles(string in_Path)
        {
            var FileList = Directory.EnumerateFiles(in_Path,"*.cs",SearchOption.AllDirectories);
            return FileList; // yield return in Kombination mit IEnumerable möglich
        }
    }
}
