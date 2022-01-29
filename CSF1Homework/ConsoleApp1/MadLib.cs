using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some information below to do this Mad Lib. Unless, otherwise specified, verbs should be in standard present tense < i.e. 'swim' 'run' >. Adverbs are words modifying verbs < like 'soon', or often ending in 'ly', like 'swiftly' >. Adjectives are words that decribe nouns < like 'green' or 'descriptive' >. ");
            Console.WriteLine("Noun: ");
            string noun = Console.ReadLine();
            Console.WriteLine("Verb: ");
            string verb = Console.ReadLine();
            Console.WriteLine("Adjective: ");
            string adjective = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Verb ending in '-ing' ");
            string verb2 = Console.ReadLine();
            Console.WriteLine("Adjective");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Adverb: ");
            string adverb = Console.ReadLine();
            Console.WriteLine("Exclamation: ");
            string exclamation = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Time of Day (Morning, Midnight, exc...) : ");
            string timeOfDay = Console.ReadLine();

            Console.WriteLine($"One day there was a {noun} that didn't want to {verb} anymore. And so, like any good {adjective} {noun2}, the {noun} decided to go {verb2}.\n" +
                $"But sometimes the universe is a {adjective2} mistress, and destiny {adverb} called.\n After that, the {noun} exclaimed {exclamation}, and they heard it all the way in {city}! And the {noun} vowed not to return until {timeOfDay}.");

        }//end Main()
    }//end class
}//end namespace
