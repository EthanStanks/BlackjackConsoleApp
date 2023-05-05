using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public class ReadMethods
    {
        public static int ReadInteger(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {

            do
            {
                Console.Write(prompt);
                string userInput;
                bool yes = int.TryParse(userInput = Console.ReadLine(), out int userNumber);
                if (yes == true)
                {
                    if (userNumber <= max && userNumber >= min)
                    {
                        return userNumber;
                    } // if the user actual did something correct for once lol
                    else
                    {
                        Console.WriteLine("Please enter a number between " + min + " and " + max);
                    } // if they don't enter a number between the min and max
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again . . .");
                } // if they don't enter a number
            } while (true); // do while loop
        } // read int

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            } // loop for each option
            Console.WriteLine(); // new line
            selection = ReadInteger(prompt, 1, options.Length); // gives them the prompt and take their input
        } // read choice



    } // end of class

}
