using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoCCount
{
    class SourceFileProvider
    {
        public string[] ReadContent(string fileName)
        {
            return File.ReadAllLines(fileName);
        }

        public LocInfo CountLoc(string[] lines, string filename)
        {
            int linesOfCode = 0;
            foreach (var line in lines)
            {
                if (!String.IsNullOrWhiteSpace(line)
                    && !line.Trim().StartsWith("//"))
                {
                    linesOfCode++;
                }
            }
            return new LocInfo() { FileName = filename, LinesOfCode = linesOfCode, TotalLines = lines.Length };
        }

    }
}
