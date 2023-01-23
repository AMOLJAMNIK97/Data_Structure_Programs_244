using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedList orderedList = new OrderedList();

            Console.WriteLine("Enter word to Search");
            string word = Console.ReadLine();
            orderedList.Ordered(word); 
        }
    }
}
