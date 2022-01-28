using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {
            Console.Title = "Fruit Loops 2";

            string[] fruits = { "apple\n.", "bannana\n..", "strawberry\n...", "cherry\n....", "grape\n.....", "orange\n......" };



            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
                
            }

        }//end Main()
    }//end class
}//end namespace
