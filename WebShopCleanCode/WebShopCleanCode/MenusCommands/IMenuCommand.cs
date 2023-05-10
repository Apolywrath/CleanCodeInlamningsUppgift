using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode.MenusCommands
{
    public interface IMenuCommand
    {
        void ExecuteMenuCommand(WebShop webShop);
    }
}
