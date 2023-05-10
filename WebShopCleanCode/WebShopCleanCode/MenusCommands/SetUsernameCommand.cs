using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public class SetUsernameCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            Console.WriteLine("A keyboard appears.");
            Console.WriteLine("Please input your username.");
            webShop.username = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
