using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card(Suit.Heart,Rank.Ace);
            Card myCard1 = new Card(Suit.Diamonds);
            Console.WriteLine($"My favorite cards is:{myCard._rank},{myCard._suit}");
            Console.WriteLine($"My new cards is:{myCard1._rank},{myCard1._suit}");
        }

        enum Suit
        {
            Heart,
            Spades,
            Clubs,
            Diamonds
        }

        enum Rank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            King,
            Queen,
            Princess,
            Joker
        }
        struct Card
        {

            public Suit _suit { get; private set; }
            public Rank _rank { get; private set; }

            public Card(Suit s, Rank r)
            {
                this._suit = s;
                this._rank = r;
            }
            public Card(Suit s)
            {
                this._suit = s;
                Random r = new Random();
                Type type = typeof(Rank);

                Array ranks=Enum.GetValues(type);
                this._rank = (Rank)(r.Next(0, 14));
               
            }

        }

    }


}