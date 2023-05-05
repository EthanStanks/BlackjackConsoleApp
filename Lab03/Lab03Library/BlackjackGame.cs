using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class BlackjackGame
    {
        #region Fields

        BlackjackHand _dealer;
        BlackjackHand _player;
        Deck _deck;
        #endregion

        #region Methods

        public void PlayRound()
        {
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand(false);
            _deck = new Deck();
            bool playRound = true;

            DealInitialCards();
            while (playRound)
            {
                if (_dealer.Score == 21 || _player.Score == 21)
                {
                    playRound = false;
                    DrawTable();
                    RevealCard(0, 0);
                }
                else
                {
                    PlayersTurn();
                    DealersTurn();
                    playRound = false;

                }
            }
            _dealer.IsDealer = false;
            DeclareWinner();
            Console.SetCursorPosition(0, 25);

        } //PlayRound method

        private void DealInitialCards()
        {
            _deck.DeckMethod();
            _deck.Shuffle();
            for (int i = 0; i < 2; i++)
            {
                _player.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
            }
            DrawTable();

        }//DealInitialCards method

        private void PlayersTurn()
        {
            bool userStands = false;
            bool playerTurn = true;
            string prompt = "(1) Hit or (2) Stand ";

            while (playerTurn)
            {
                if (_player.Score >= 21 || userStands == true)
                {
                    playerTurn = false;
                } // if their score is above or equal to 21 or they chose to stand
                else
                {
                    Console.SetCursorPosition(0, 20);
                    int option = ReadMethods.ReadInteger(prompt, 1, 2);
                    if (option == 1)
                    {
                        _player.AddCard(_deck.Deal());
                        DrawTable();
                        userStands = false;
                    } // if they chose to hit
                    else
                    {
                        userStands = true;
                    } // if user chose to stand
                } // if they have below 21 or they don't stand
            } // while player's turn

        }//PlayersTurn method

        private void DealersTurn()
        {
            DrawTable();
            bool dealerTurn = true;
            while (dealerTurn)
            {
                if (_dealer.Score >= 17)
                {
                    dealerTurn = false;
                } // if the dealer has a score of 17 or higher
                else
                {
                    _dealer.AddCard(_deck.Deal());
                    DrawTable();
                }
            } // while dealer's turn

        }//DealersTurn method

        private void DeclareWinner()
        {
            DrawTable();
            if (_player.Score > 21)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Dealer wins, Player went over 21");
            }
            else if (_dealer.Score > 21)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Player wins, Dealer went over 21");
            }
            else if (_player.Score > _dealer.Score)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Player wins, Player's score was higher");
            }
            else if (_dealer.Score > _player.Score)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Dealer wins, Dealer's score was higher");
            }
            else
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("No winner, Player and Dealer tied");
            }
        }//DeclareWinner method

        private void DrawTable()
        {
            Console.Clear();
            int x = 0;
            int y = 0;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("---- Dealer's Hand ----");
            Console.SetCursorPosition(x, y + 1);
            _dealer.Print(x, y + 1);
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("---- Player's Hand ----");
            _player.Print(x, y + 11);

        }//DrawTable method

        private void RevealCard(int x, int y)
        {
            Console.SetCursorPosition(x, y + 1);
            _dealer.Print(x, y + 1);
            _dealer.PrintReveal(x, y + 1);
        }

        #endregion





    } // BlackjackGame class
} // Namespace
