using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempatureConvert
    {
        static void Main(string[] args)
        {
            Console.Title = "Tempature Converter";

                bool repeat = true;
            do
            {

                Console.WriteLine("-= Celcius to Fahrenheit or Fahrenheit to Celcius -=\n");
                Console.WriteLine("A) Celcius to Fahrenheit\n" +
                    "B) Fahrenheit to Celcius\n ");

                ConsoleKey tempFr = Console.ReadKey(true).Key;
                
                switch (tempFr)
                {
                    case ConsoleKey.A:
                        Console.Write("What's the tempature outside in °c? ");
                        int cel = Convert.ToInt16(Console.ReadLine());
                        int fr = cel * 9 / 5 + 32;
                        Console.WriteLine("°" + fr + "f");
                        break;


                    case ConsoleKey.B:
                        Console.Write("What's the tempature outside in °f? ");
                        int fr2 = Convert.ToInt16(Console.ReadLine());
                        int cel2 = fr2 - 32 / 9 / 5;
                        Console.WriteLine("°" + cel2 + "c");
                        break;

                    default:
                        Console.WriteLine("farts");
                        break;

                }
                
            } while (repeat);







        }//end Main()
    }//end class
}//end namespace
