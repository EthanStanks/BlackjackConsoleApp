using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public static class Factory
    {
        public static ICard CreateCard(CardFace face, CardSuit suit)
        {
            Card card = new Card(face, suit);
            return card;
        }
        public static ICard CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            BlackjackCard blackJackCard = new BlackjackCard(face, suit);
            return blackJackCard;
        }
    }

}
