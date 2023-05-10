using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class SortMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        public List<string> Options { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }
        public string Info { get; set; }
        Customer currentCustomer;

        public SortMenu(Customer currentCustomer)
        {
            Options = new List<string>() { "Sort by name, descending", "Sort by name, ascending", "Sort by price, descending", "Sort by price, ascending" };
            AmountOfOptions = Options.Count;
            this.currentCustomer = currentCustomer;
            Info = "How would you like to sort them?";
            CurrentChoice = 1;
            MenuCommands = new List<IMenuCommand>() { new SortNameDescendingCommand(), new SortNameAscendingCommand(), 
                new SortPriceDescendingCommand(), new SortPriceAscendingCommand(), };
        }

        public void ExecuteCurrentChoice(WebShop webShop)
        {
            MenuCommands[CurrentChoice-1].ExecuteMenuCommand(webShop);
        }

        public void Refresh(WebShop webShop)
        {
            webShop.curMenu = new SortMenu(currentCustomer);
        }

        public void Back(WebShop webShop)
        {
            webShop.curMenu = new WaresMenu(currentCustomer);
        }
    }
}
