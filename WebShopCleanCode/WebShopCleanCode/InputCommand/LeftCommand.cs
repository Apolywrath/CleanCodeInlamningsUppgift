using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal class LeftCommand : IInputCommand
    {
        public bool ExecuteInputCommand(WebShop webShop,string input)
        {
            if(input.Equals("l") || input.Equals("left"))
            { 
                if (webShop.curMenu.CurrentChoice > 1)
                {
                    webShop.curMenu.CurrentChoice--;
                }
                return true;
            }
            return false;

        }
    }
}
