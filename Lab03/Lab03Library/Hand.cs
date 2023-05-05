using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class Hand
    {
        #region Fields
        protected List<ICard> _cards = new List<ICard>();
        #endregion

        #region Methods
        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public virtual void Print(int x, int y)
        {
            foreach (var item in _cards)
            {
                if (x >= 108)
                {
                    x = 0;
                    y += 8;
                }


                item.Print(x, y);
                x += 12;
            }
        }
        #endregion
    }
}
