using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class LogoutCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            
            Console.WriteLine();
            Console.WriteLine(webShop.currentCustomer.Username + " logged out.");
            Console.WriteLine();
            webShop.currentCustomer = null;
            webShop.curMenu.Refresh(webShop);
        }
    }
}
