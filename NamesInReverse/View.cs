using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesInReverse
{
    public class View
    {
        Logic logic = new Logic();

        public void TitleAndInfo()
        {
            Console.Clear();
            Console.WriteLine("----- Name Randomizer and in Reverse -----");
            Console.WriteLine();
            Console.WriteLine("This program prints your name in reverse first, then shuffles your name 4 times and prints the results to the screen.");
            Console.WriteLine();
        }

        public string GetFirstName()
        {
            string input;
            do
            {
                Console.Write("Enter your first name (min 3 chars): ");
                input = Console.ReadLine();
            } while (input == "" || input.Length < 3);

            return input;
        }

        public string GetLastName()
        {
            string input;
            do
            {
                Console.Write("Enter your last name (min 3 chars): ");
                input = Console.ReadLine();
            } while (input == "" || input.Length < 3);

            return input;
        }

        public void DisplayNameInReverse(Person person)
        {
            Person reverseperson = logic.ReverseName(person);
            Console.WriteLine();
            Console.Write("Your name spelled backwords: ");
            Console.Write("{0} {1}", reverseperson.FirstName, reverseperson.LastName);
            Console.WriteLine();
        }

        public void DisplayNameInRandomOrder(Person person)
        {
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Person randomperson = logic.RandomizeName(person);
                Console.Write("Your name in random order(#{0}): ", i + 1);
                Console.Write("{0} {1}", randomperson.FirstName, randomperson.LastName);
                Console.WriteLine();
            }
        }

        public void PauseForUser()
        {
            Console.WriteLine();
            Console.Write("Press any key to quit... ");
            Console.ReadKey();
        }
    }
}