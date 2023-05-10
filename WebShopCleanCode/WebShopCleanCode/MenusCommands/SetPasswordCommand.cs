using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class SetPasswordCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            Console.WriteLine("A keyboard appears.");
            Console.WriteLine("Please input your password.");
            webShop.password = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
