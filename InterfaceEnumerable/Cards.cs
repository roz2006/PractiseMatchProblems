using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerablePractice
{
    class Cards
    {
        public Suit _suit { get; private set; }
        public Rank _rank { get; private set; }

        public Cards(Suit s, Rank r)
        {
            _suit = s;
            _rank = r;
        }

        public enum Suit
        {
            Club,
            Heart,
            Diamond,
            Spade
        }
        public enum Rank
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
            Queen,
            King,
            Joker
        }
    }
}
