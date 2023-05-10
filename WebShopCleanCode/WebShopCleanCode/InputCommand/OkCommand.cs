using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal class OkCommand : IInputCommand
    {
        public bool ExecuteInputCommand(WebShop webShop, string input)
        {
            if(input.Equals("ok") || input.Equals("k") || input.Equals("o"))
            {
                webShop.curMenu.ExecuteCurrentChoice(webShop);
                return true;
            }
            return false;
        }
    }
}
