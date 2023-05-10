using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class AddFundsCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            Console.WriteLine("How many funds would you like to add?");
            string amountString = Console.ReadLine();
            try
            {
                int amount = int.Parse(amountString);
                if (amount < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Don't add negative amounts.");
                    Console.WriteLine();
                }
                else
                {
                    webShop.currentCustomer.Funds += amount;
                    Console.WriteLine();
                    Console.WriteLine(amount + " added to your profile.");
                    Console.WriteLine();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine("Please write a number next time.");
                Console.WriteLine();
            }
        }
    }
}
