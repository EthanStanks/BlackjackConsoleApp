using System;
using Lab03Library;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // makes the symbols of cards show up

            Console.Title = "♣ ♠ Blackjack ♥ ♦";
            Console.WindowHeight = 55;
            Console.WindowWidth = 120;

            bool runProgram = true;
            string prompt = "What would you like to do? ";
            string[] menuOptions = new string[] { "(1) Play Blackjack", "(2) Shuffle and Show Deck", "(3) Exit" };
            int menuSelection;
            while (runProgram)
            {
                Console.Clear();
                ReadMethods.ReadChoice(prompt, menuOptions, out menuSelection);
                switch (menuSelection)
                {
                    default:
                        Console.Clear();
                        BlackjackGame gameInstance = new BlackjackGame();
                        bool playBlackjack = true;
                        int choice;
                        while (playBlackjack)
                        {
                            gameInstance.PlayRound();
                            choice = ReadMethods.ReadInteger("Want to play again?\n(1) Yes   (2) No ", 1, 2);
                            if (choice == 1)
                                playBlackjack = true;
                            else break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Deck showdeck = new Deck(); // creates deck instance
                        showdeck.DeckMethod(); // creates the deck
                        showdeck.Shuffle(); // shuffles it
                        showdeck.Print(0, 1); // prints it
                        Console.ReadKey();
                        break;
                    case 3:
                        runProgram = false;
                        break;
                } // menu options switch

            } // runProgram while loop
        } // main
    } // program class
}
