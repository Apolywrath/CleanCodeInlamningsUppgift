using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.InputCommand
{
    internal interface IInputCommand
    {
        bool ExecuteInputCommand(WebShop webShop, string input);
    }
}
