using System;
using System.Collections.Generic;
using System.Text;
using Vocabulary.View;

namespace Vocabulary.Controller
{
    class MenuController
    {
        Menu menu = new Menu();
        public int hashcodeOfPressedChar { get; set; }

        public MenuController() { }

        public void DisplayMainMenu()
        { 
            menu.ShowMainMenu();
            ProgramController program = new ProgramController();
            program.StartProgram(GetAction());
         
        }

        public int GetAction()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                default:
                   return GetActionOnWrongMenuInput();

            }

        }

        public int GetActionOnWrongMenuInput ()
        {

            bool goodInput = true;
            int output;
            do
            {
                menu.ShowWrongInputMenu();
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
            //Console.WriteLine(output);
            return output;

        }



    }
}
