using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal class DefaultCommand : IInputCommand
    {
        public bool ExecuteInputCommand(WebShop webShop, string input)
        { 
            Console.WriteLine("That is not an applicable option.");
            return true;

        }
    }
}
