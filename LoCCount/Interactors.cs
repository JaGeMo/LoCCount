using System;
using System.Collections.Generic;
using System.Text;

namespace LoCCount
{
    public class Interactors
    {
        CommandLine _cmdLine = new CommandLine();
        FileSystemProvider _fileSysProv = new FileSystemProvider();
        SourceFileProvider _srcFileProv = new SourceFileProvider();
        UI ConsoleUI = new UI();
        
        public void Start(string[] in_args)
        {
            var Path = _cmdLine.ExtractPath(in_args);

            IEnumerable<string> fileList = _fileSysProv.FindSourceFiles(Path);

            var LoCObjList = CountLoC(fileList);

            ConsoleUI.Print(LoCObjList);
        }

        List<LocInfo> CountLoC(IEnumerable<string> files)
        {
            List<LocInfo> res = new List<LocInfo>();
            foreach (var file in files)
            {
                var lines = _srcFileProv.ReadContent(file);
                res.Add(_srcFileProv.CountLoc(lines, file));
            }
            return res;
        }

    }
}
