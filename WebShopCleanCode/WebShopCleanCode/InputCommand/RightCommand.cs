using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal class RightCommand : IInputCommand
    {
        public bool ExecuteInputCommand(WebShop webShop,string input)
        {
            if(input.Equals("right")||input.Equals("r"))
            {
                if (webShop.curMenu.CurrentChoice < webShop.curMenu.AmountOfOptions)
                {
                    webShop.curMenu.CurrentChoice++;
                }
                return true;
            }
            return false;

        }
    }
}
