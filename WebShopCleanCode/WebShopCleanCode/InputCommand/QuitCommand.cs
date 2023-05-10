using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal class QuitCommand : IInputCommand
    {
        public bool ExecuteInputCommand(WebShop webShop, string input)
        {
            if(input.Equals("quit") || input.Equals("q"))
            {
                Console.WriteLine("The console powers down. You are free to leave.");
                webShop.Quit();
                return true;
                
            }
            return false;
        }
    }
}
