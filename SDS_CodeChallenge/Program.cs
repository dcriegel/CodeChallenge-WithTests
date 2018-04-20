using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDS_CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instantiation of new Menu object, and calling of the 'TurnOn' method, which calls the 'MainMenu' for the
                // console application.
                Menu menu = new Menu();
                menu.TurnOn();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }

        }
    }
}
