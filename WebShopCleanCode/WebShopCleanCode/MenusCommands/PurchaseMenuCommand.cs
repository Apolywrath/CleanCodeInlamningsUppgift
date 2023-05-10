using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class PurchaseMenuCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            if (webShop.currentCustomer != null)
            {
                webShop.curMenu = new PurchaseMenu(webShop.products, webShop.currentCustomer);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You must be logged in to purchase wares.");
                Console.WriteLine();
            }
            
        }
    }
}
