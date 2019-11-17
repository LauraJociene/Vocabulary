using System;
using System.Collections.Generic;
using System.Text;
using Vocabulary.View;

namespace Vocabulary.Controller
{
    class MenuController
    {
        public int hashcodeOfPressedChar { get; set; }

        public MenuController() { }

        public int DisplayMainMenu()
        {
            Menu menu = new Menu();
            int result = menu.ShowMainMenu();
            return result == 0 ? menu.ShowWrongInputMenu() : result;
        }

        public void GetAction(int number)
        {


        }




    }
}
