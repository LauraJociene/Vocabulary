using System;
using System.Collections.Generic;
using System.Text;

namespace Vocabulary.Controller
{
    class ProgramController
    {
        public int Action { get; set; }

        public ProgramController ()
        {
            //this.Action = number;
        }

        internal void StartProgram(int action)
        {
            switch (action)
            {
                case 1:
                    GetExistingWords();
                    break;
                case 2:
                    AddNewWords();
                    break;
                case 3:
                    ModifyExistingWords();
                    break;
                case 4:
                    DeleteExistingWords();
                    break;
                case 32:
                    MenuController menu = new MenuController();
                    menu.DisplayMainMenu();
                    break;
                case 27:
                    Console.WriteLine("...Closing program... BYE!!!");
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }
        }

        public void GetExistingWords()
        {
            Console.WriteLine("Getting word from DB...");

        }

        public void AddNewWords()
        {
            Console.WriteLine("Adding new word to DB...");
        }

        public void ModifyExistingWords()
        {
            Console.WriteLine("Modifying word in DB...");
        }

        public void DeleteExistingWords()
        {
            Console.WriteLine("Deleting word from DB...");
        }
    }
}
