using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

            AbstractHandler handler = new XMLHandler();
            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();
            Console.WriteLine("\t");

            AbstractHandler handler1 = new TXTHandler();
            handler1.Create();
            handler1.Open();
            handler1.Change();
            handler1.Save();
            Console.WriteLine("\t");

            AbstractHandler handler2 = new DOCHandler();
            handler2.Create();
            handler2.Open();
            handler2.Change();
            handler2.Save();
            Console.WriteLine("\t \n");

            Console.ReadKey();
        }
    }
}
