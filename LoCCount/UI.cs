using System;
using System.Collections.Generic;
using System.Text;

namespace LoCCount
{
    public class UI
    {
        public void Print(List<LocInfo> locCounts)
        {
            Tuple<int, int> totals = CalculateTotals(locCounts);
            foreach (var locInfo in locCounts)
            {
                Console.WriteLine("{0}t{1} lines\t{2} loc", locInfo.FileName, locInfo.TotalLines, locInfo.LinesOfCode);
            }
            Console.WriteLine();

            Console.WriteLine("Total:\t{0} lines {1} loc", totals.Item1, totals.Item2);
        }

        internal static Tuple<int, int> CalculateTotals(List<LocInfo> locCounts)
        {
            int linesOfCode = 0;
            int totalLines = 0;
            foreach (var locInfo in locCounts)
            {
                linesOfCode += locInfo.LinesOfCode;
                totalLines += locInfo.TotalLines;
            }

            return new Tuple<int, int>(linesOfCode, totalLines);
        }
    }
}
