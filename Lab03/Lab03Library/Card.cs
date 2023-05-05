using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class Card : ICard
    {
        #region Properties
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        #endregion

        #region Methods

        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            switch (Face)
            {
                default:
                    Console.Write("  A");
                    break;
                case CardFace._2:
                    Console.Write("  2");
                    break;
                case CardFace._3:
                    Console.Write("  3");
                    break;
                case CardFace._4:
                    Console.Write("  4");
                    break;
                case CardFace._5:
                    Console.Write("  5");
                    break;
                case CardFace._6:
                    Console.Write("  6");
                    break;
                case CardFace._7:
                    Console.Write("  7");
                    break;
                case CardFace._8:
                    Console.Write("  8");
                    break;
                case CardFace._9:
                    Console.Write("  9");
                    break;
                case CardFace._10:
                    Console.Write(" 10");
                    break;
                case CardFace.J:
                    Console.Write("  J");
                    break;
                case CardFace.Q:
                    Console.Write("  Q");
                    break;
                case CardFace.K:
                    Console.Write("  K");
                    break;
            }
            switch (Suit)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("♠      ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y+1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y+2);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♠♠    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y+3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("   ♠  ♠   ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y+4);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♠♠    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y+5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 6);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("      ♠");
                    break;
                case CardSuit.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("♥      ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 2);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♥♥    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("   ♥  ♥   ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 4);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♥♥    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 6);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("      ♥");
                    break;
                case CardSuit.Clubs:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("♣      ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 2);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♣♣    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("   ♣  ♣   ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 4);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♣♣    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 6);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("      ♣");
                    break;
                case CardSuit.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("♦      ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 2);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♦♦    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("   ♦  ♦   ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 4);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("    ♦♦    ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.SetCursorPosition(x, y + 6);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("      ♦");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Black;
            switch (Face)
            {
                default:
                    Console.Write("A  ");
                    break;
                case CardFace._2:
                    Console.Write("2  ");
                    break;
                case CardFace._3:
                    Console.Write("3  ");
                    break;
                case CardFace._4:
                    Console.Write("4  ");
                    break;
                case CardFace._5:
                    Console.Write("5  ");
                    break;
                case CardFace._6:
                    Console.Write("6  ");
                    break;
                case CardFace._7:
                    Console.Write("7  ");
                    break;
                case CardFace._8:
                    Console.Write("8  ");
                    break;
                case CardFace._9:
                    Console.Write("9  ");
                    break;
                case CardFace._10:
                    Console.Write("10 ");
                    break;
                case CardFace.J:
                    Console.Write("J  ");
                    break;
                case CardFace.Q:
                    Console.Write("Q  ");
                    break;
                case CardFace.K:
                    Console.Write("K  ");
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }

        #endregion
    }
}
