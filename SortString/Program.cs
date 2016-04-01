using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Developement Foundation";
            Program prog = new Program();
            prog.StringSplitterAndJoiner(s);
        }

        public void StringSplitterAndJoiner(string text)
        {
            string[] splittedString = text.Split(' ');
            Array.Sort(splittedString);
            foreach (var item in splittedString)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            text = string.Join(" ", splittedString);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
