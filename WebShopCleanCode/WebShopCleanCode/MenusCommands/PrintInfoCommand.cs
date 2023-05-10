using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class PrintInfoCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            webShop.currentCustomer.PrintInfo();
        }
    }
}
