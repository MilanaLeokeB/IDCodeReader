using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)

        {
            DisplayLOGIT("LOGITpe20");


        }
        public static void DisplayLOGIT(string logitpe20)
        {
            string logit = logitpe20.Substring(0, 5);
            string pe = logitpe20.Substring(5, 2);
            string twenty = logitpe20.Substring(7, 2);
            Console.WriteLine($"--> {logit}");
            Console.WriteLine($"--> {pe}");
            Console.WriteLine($"--> {twenty}");
        }

    }
}
