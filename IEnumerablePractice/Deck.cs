using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IEnumerablePractice.Cards;

namespace IEnumerablePractice
{
    class Deck
    {
        private List<Cards> _deck;

        public void FillDeck()
        {
            List<Cards> filledDeck = new List<Cards>();
            Array ranks = Enum.GetValues(typeof(Rank));
            Array suits = Enum.GetValues(typeof(Suit));

            foreach (Rank r in ranks)
            {
                foreach (Suit s in suits)
                {
                    Cards c = new Cards(s, r);
                    filledDeck.Add(c);
                }
            }
            _deck = filledDeck;
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i <_deck.Count; i++)
            {
                int j = r.Next(_deck.Count);
                Cards tempi = _deck.ElementAt(i);
                Cards tempj = _deck.ElementAt(j);
                _deck.RemoveAt(i);
                _deck.Insert(i, tempj);
                _deck.RemoveAt(j);
                _deck.Insert(i, tempi);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Cards c in _deck)
            {
                // Lets check for end of list (its bad code since we used arrays)
                if (c == null) // this wont work is T is not a nullable type
                {
                    break;
                }

                // Return the current element and then on next function call 
                // resume from next element rather than starting all over again;
                yield return c;
            }
        }

    }
}
