using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class Deck
    {
        List<ICard> _cards = new List<ICard>();

        public Deck()
        {
            DeckMethod();
        }

        public void DeckMethod()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    _cards.Add(Factory.CreateBlackjackCard((CardFace)j, (CardSuit)i));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = 0; i < 51; i++)
            {
                int j = rng.Next(i, 52);

                ICard temp = _cards[j];
                _cards[j] = _cards[i];
                _cards[i] = temp;
            }
        }

        public ICard Deal()
        {
            if (_cards.Count == 0)
            {
                DeckMethod();
                Shuffle();
            }
            ICard temp = _cards[0];
            _cards.RemoveAt(0);
            return temp;
        }

        public void Print(int x, int y)
        {
            
            for (int i = 0; i < 52; i++)
            {
                if (x >= 108)
                {
                    x = 0;
                    y += 8;
                }


                _cards[i].Print(x, y);
                x += 12;
            }
        }
    }
}
