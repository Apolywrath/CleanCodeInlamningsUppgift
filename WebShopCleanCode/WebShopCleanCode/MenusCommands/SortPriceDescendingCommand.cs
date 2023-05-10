using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class SortPriceDescendingCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.SelectionSort("price", false, webShop.products);
            Console.WriteLine();
            Console.WriteLine("Wares sorted.");
            Console.WriteLine();
            webShop.curMenu.Back(webShop);
        }
    }
}
