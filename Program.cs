using System;
using System.Text;
using System.Threading;

namespace emojimadness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var f1 = new string[]{ "🌑", "🌒", "🌓", "🌔", "🌝", "🌖", "🌗", "🌘" };
            var f2 = new string[]{ "🕐", "🕑", "🕒", "🕓", "🕔", "🕕", "🕖", "🕗", "🕘", "🕙", "🕚", "🕛"};
            var f3 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (string s in f1)
            {
                //Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(s + "    ");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            foreach (string s in f2)
            {
                //Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(s + "    ");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            foreach (string s in f3)
            {
                //Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(s + "    ");
                Thread.Sleep(100);
            }
        }
    }
}
