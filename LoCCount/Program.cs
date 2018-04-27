using System;

namespace LoCCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Interactors interAct = new Interactors();
            interAct.Start(args);
#if DEBUG
            Console.Read();
#endif
        }
    }
}
