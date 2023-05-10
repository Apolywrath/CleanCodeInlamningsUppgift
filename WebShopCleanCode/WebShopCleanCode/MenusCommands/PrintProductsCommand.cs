using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class PrintProductsCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            Console.WriteLine();
            foreach (ProductProxy product in webShop.products)
            {
                product.PrintInfo();
            }
            Console.WriteLine();
        }
    }
}
