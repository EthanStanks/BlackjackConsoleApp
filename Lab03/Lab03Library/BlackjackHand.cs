using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class BlackjackHand : Hand
    {
        // properties
        public int Score { get; private set; }

        public bool IsDealer { get; set; } = false;

        public BlackjackHand(bool isDealer = false)
        {
            IsDealer = isDealer;
        }

        public override void AddCard(ICard card)
        {
            base.AddCard(card);
            int aceCounter = 0;
            Score = 0;
            for (int i = 0; i < _cards.Count; i++)
            {
                BlackjackCard temp = (BlackjackCard)_cards[i];
                if (temp.Face is CardFace.A)
                    aceCounter++;
                else Score += temp.Value;

            }
            for (int i = 0; i < aceCounter; i++)
            {
                if (11 + Score <= 21)
                    Score += 11;
                else Score++;
            }
        }

        public override void Print(int x, int y)
        {
            if (IsDealer is false)
            {
                base.Print(x, y);
                Console.WriteLine();
                string score = "Score: " + Score.ToString();
                Console.WriteLine(score);
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("+--------+");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 1);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("|  ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("♠♣");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("♦♥");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("  |");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 2);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("| Stanks |");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 3);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("|        |");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 4);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("| Casino |");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 5);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("|  ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("♠♣");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("♦♥");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("  |");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y + 6);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("+--------+");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();


                if (x >= 108)
                {
                    x = 0;
                    y += 8;
                }
                for (int i = 1; i < _cards.Count; i++)
                {
                    _cards[i].Print(x + 12, y);

                }
                x += 12;
            }


        }
        public void PrintReveal(int x, int y)
        {
            Console.SetCursorPosition(x, y);
                if (x >= 108)
                {
                    x = 0;
                    y += 8;
                }
                _cards[0].Print(x, y);
                x += 12;
            


        }


    }
}
