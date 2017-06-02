using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IEnumerablePractice.Cards;

namespace IEnumerablePractice
{
    class Deck
    {
        private List<Cards> _deck { get; set; }

        public void FillDeck()
        {
            Array ranks = Enum.GetValues(typeof(Rank));
            Array suits = Enum.GetValues(typeof(Suit));

            foreach (Rank r in ranks)
            {
                foreach (Suit s in suits)
                {
                    Cards c = new Cards(s, r);
                    _deck.Add(c);
                }
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < _deck.Count; i++)
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
    }
}
