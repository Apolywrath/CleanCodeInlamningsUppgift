using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class CustomerMenuCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            if (webShop.currentCustomer != null)
            {
                webShop.curMenu = new CustomerMenu(webShop.currentCustomer);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nobody is logged in.");
                Console.WriteLine();
            }
            
        }
    }
}
