using System;
using System.Collections.Generic;
using System.Text;

namespace Vocabulary.View
{
    class Menu
    {

        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*.*.*.*.*.* VOCABULARY *.*.*.*.*.*");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("\n1 - Get the meaning of a word");
            Console.WriteLine("2 - Add a new word to your vocabulary");
            Console.WriteLine("3 - Modify an existing word");
            Console.WriteLine("4 - Delete a word from your vocabulary");
            Console.Write("\nType a number of chosen option: ");

          
        }

        public void ShowWrongInputMenu()
        {
            Console.Clear();
            Console.WriteLine("*.*.*.*.*.* VOCABULARY *.*.*.*.*.*");
            Console.WriteLine("\nWrong input! \nBack to Menu press 'Space' \nClose program press 'Esc'");
               
        }

    }
}

