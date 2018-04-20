using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDS_CodeChallenge
{
    public class Menu
    {
        // Declaration of 'counter' variable which is updated by +1 on the console application each time the user
        // presses '1' (Proceeds to the next day).  This action causes the UpdateQuality method is execute as well.
        private int counter;

        // Instantiation of 'ManagementSystem' object so we are able to utilize the 'Items' list and UpdateQuality method.
        ManagementSystem _ms = new ManagementSystem();

        public void TurnOn()
        {
            MainMenu();
        }

        // This is the default menu view for the console application.
        private void MainMenu()
        {
            bool isMainFinished = false;

            while (!isMainFinished)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("**SDS INN - Inventory and Quality Management System**");
                Console.WriteLine();
                Console.WriteLine($"Days Passed: {counter}");
                Console.WriteLine();
                Console.WriteLine("{0,-25}{1,-19}{2,-20}", " Item Name", "Current SellIn", "Current Quality");
                Console.WriteLine("------------------------------------------------------------");

                // Looping through the Items list to display each item's Name,
                // as well as its current 'SellIn' and 'Quality' values.
                for (var i = 0; i < _ms.Items.Count; i++)
                {
                    Console.WriteLine("{0,-25}{1,-19}{2,-20}", " " + _ms.Items[i].Name, "\t" + _ms.Items[i].SellIn, _ms.Items[i].Quality);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Select option '1' or '0' below.");
                Console.WriteLine();
                Console.WriteLine("(1) Proceed to Next Day; Update 'SellIn' & 'Quality' values for each Item");
                Console.WriteLine();
                Console.WriteLine("(0) Quit");

                // When a user selects '1', the 'counter' variable is updated (+1), the UpdateQuality method is executed
                char userChoice = Console.ReadKey().KeyChar;
                if (userChoice == '1')
                {
                    counter += 1;
                    _ms.UpdateQuality();
                }
                // User can select '0' to quit/exit the program.
                else if (userChoice == '0')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Invalid selection. Please select '1' or '0'.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
