using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class WaresMenuCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            webShop.curMenu = new WaresMenu(webShop.currentCustomer);
        }
    }
}
