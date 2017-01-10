using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> wow = new CustomList<int>();
            wow.AddToList(5);
            wow.AddToList(15);
            wow.AddToList(25);
            wow.PrintList();
            Console.ReadLine();
        }
    }
}
