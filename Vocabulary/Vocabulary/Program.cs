using System;
using System.Data.SqlClient;
using Vocabulary.Controller;

namespace Vocabulary
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuController menu = new MenuController();
            menu.DisplayMainMenu();

        }
    }
}
