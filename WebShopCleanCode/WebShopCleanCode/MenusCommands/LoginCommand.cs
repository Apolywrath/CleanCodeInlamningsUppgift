using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class LoginCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            if (webShop.username == null || webShop.password == null)
            {
                Console.WriteLine();
                Console.WriteLine("Incomplete data.");
                Console.WriteLine();
            }
            else
            {
                bool found = false;
                foreach (Customer customer in webShop.customers)
                {
                    if (webShop.username.Equals(customer.Username) && customer.CheckPassword(webShop.password))
                    {
                        Console.WriteLine();
                        Console.WriteLine(customer.Username + " logged in.");
                        Console.WriteLine();
                        webShop.currentCustomer = customer;
                        found = true;
                        webShop.curMenu = new MainMenu(webShop.currentCustomer);
                    }
                }
                if (found == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid credentials.");
                    Console.WriteLine();
                }
            }
        }
    }
}
