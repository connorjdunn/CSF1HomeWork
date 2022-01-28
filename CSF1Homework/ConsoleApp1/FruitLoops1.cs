using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework

{
    class FruitLoops1
    {
        static void Main(string[] args)
        {
            Console.Title = "FruitLoops1";

            string[] fruits = { "apple", "bannana", "strawberry", "cherry", "grape", "orange" };

            

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

        }
    }
}
