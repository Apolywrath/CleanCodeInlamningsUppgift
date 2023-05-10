using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public interface MenuStates
    {
        void ExecuteCurrentChoice(WebShop webShop);
        void Refresh(WebShop webShop);
        void Back(WebShop webShop);
        int CurrentChoice { get; set; }
        int AmountOfOptions { get; set; }
        List<string> Options { get; set; }
        List<IMenuCommand> MenuCommands { get; set; }
        string Info { get; set; }
    }
}
