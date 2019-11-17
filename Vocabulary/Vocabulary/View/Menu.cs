using System;
using System.Collections.Generic;
using System.Text;

namespace Vocabulary.View
{
    class Menu
    {

        public int ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Vocabulary!");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("\n1 - Get the meaning of a word");
            Console.WriteLine("2 - Add a new word to your vocabulary");
            Console.WriteLine("3 - Modify an existing word");
            Console.WriteLine("4 - Delete a word from your vocabulary");
            Console.Write("\nType a number of chosen option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    //Console.WriteLine("Get");
                    return 1;
                case "2":
                    // Console.WriteLine("Add");
                    return 2;
                case "3":
                    // Console.WriteLine("Modify");
                    return 3;
                case "4":
                    //Console.WriteLine("Delete");
                    return 4;
                default:
                    return 0;


            }
        }

        public int ShowWrongInputMenu()
        {
            bool goodInput = true;
            int output;
            do
            {
                Console.Clear();
                Console.WriteLine("Wrong input. \nBack to menu press 'Space', close program press 'Esc'");
                ConsoleKeyInfo pressedChar = Console.ReadKey();
                System.Threading.Thread.Sleep(250);
                int hashCode = pressedChar.Key.GetHashCode();
                // Console.WriteLine(hashCode);
                if (hashCode == 27 || hashCode == 32) //Esc or Space
                {
                    goodInput = true;
                    output = hashCode;
                }
                else
                {
                    goodInput = false;
                    output = 0;
                }

            }
            while (!goodInput);

            return output;



        }

    }
}

