using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    class BlackjackCard : Card
    {
        // properties
        public int Value{ get; private set; }

        public BlackjackCard(CardFace face, CardSuit suit) : base(face, suit)
        {
            switch (face)
            {
                default: // ace
                    Value = 11;
                    break;
                case CardFace._2:
                    Value = 2;
                    break;
                case CardFace._3:
                    Value = 3;
                    break;
                case CardFace._4:
                    Value = 4;
                    break;
                case CardFace._5:
                    Value = 5;
                    break;
                case CardFace._6:
                    Value = 6;
                    break;
                case CardFace._7:
                    Value = 7;
                    break;
                case CardFace._8:
                    Value = 8;
                    break;
                case CardFace._9:
                    Value = 9;
                    break;
                case CardFace._10:
                    Value = 10;
                    break;
                case CardFace.J:
                    Value = 10;
                    break;
                case CardFace.Q:
                    Value = 10;
                    break;
                case CardFace.K:
                    Value = 10;
                    break;
            } // value face switch

        } // constructor
    }
}
