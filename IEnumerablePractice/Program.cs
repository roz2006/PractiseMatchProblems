using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerablePractice
{
    class Program
    {
        static IEnumerable<int> YiledReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }


        static void Main(string[] args)
        {
            //foreach (var i in YiledReturn())
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> myStrings = new List<string>();
            //myStrings.Add("One");
            //myStrings.Add("Two");
            //myStrings.Add("Three");

            //foreach (var item in myStrings)
            //{
            //    Console.WriteLine(item);
            //}

            //MyList<string> myListString = new MyList<string>();
            //myListString.Add("Four");
            //myListString.Add("Five");
            //myListString.Add("Six");

            //foreach (var item in myListString)
            //{
            //    Console.WriteLine(item);
            //}

            Deck myDeck = new Deck();
            myDeck.FillDeck();
            Console.WriteLine("Before shuffling:");
            foreach (Cards c in myDeck)
            {
                Console.WriteLine(c._suit + "/" + c._rank);
            }

            myDeck.Shuffle();
            Console.WriteLine("After shuffling:");
            foreach (Cards c in myDeck)
            {
                Console.WriteLine(c._suit+"/"+c._rank);
            }
        }
    }
}
