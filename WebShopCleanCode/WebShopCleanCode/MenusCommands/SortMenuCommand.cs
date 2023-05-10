using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class SortMenuCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            webShop.curMenu = new SortMenu(webShop.currentCustomer);
        }
    }
}
