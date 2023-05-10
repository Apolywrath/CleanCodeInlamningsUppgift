using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode.MenusCommands
{
    public class RegisterCommand : IMenuCommand
    {
        public void ExecuteMenuCommand(WebShop webShop)
        {
            CustomerBuilder customerBuilder= new CustomerBuilder();

            customerBuilder.Username(webShop).Password().FirstName().LastName().Email().Age().Address().PhoneNumber();
            Customer newCustomer = customerBuilder.Build();
            webShop.currentCustomer= newCustomer;

            Console.WriteLine();
            Console.WriteLine(newCustomer.Username + " successfully added and is now logged in.");
            Console.WriteLine();

            webShop.curMenu = new MainMenu(webShop.currentCustomer);
        }
    }
}
