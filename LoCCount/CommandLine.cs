using System;
using System.Collections.Generic;
using System.Text;

namespace LoCCount
{
    public class CommandLine
    {
        public string ExtractPath(string[] in_args)
        {
            if(in_args.Length != 0)
            {
                return in_args[0];
            }
            else
            {
                throw new System.ArgumentException("path not provided");
            }
        }

    }
}
