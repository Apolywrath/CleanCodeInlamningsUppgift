using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class LoginMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        
        public List<string> Options { get; set; }
        public string Info { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }

        Customer currentCustomer;
        public LoginMenu(Customer currentCustomer)
        {
            Options = new List<string>() { "Set Username", "Set Password", "Login", "Register" };
            AmountOfOptions = Options.Count;
            this.currentCustomer = currentCustomer;
            Info = "Please submit username and password.";
            CurrentChoice = 1;
            MenuCommands= new List<IMenuCommand>() {new SetUsernameCommand(),new SetPasswordCommand(),new LoginCommand(),new RegisterCommand() };
            if (currentCustomer != null)
            {
                Options[2] = "Logout";
                MenuCommands[2] = new LogoutCommand();
            }
        }
        public void ExecuteCurrentChoice(WebShop webShop)
        {

            MenuCommands[CurrentChoice-1].ExecuteMenuCommand(webShop);
        }

        public void Refresh(WebShop webShop)
        {
            webShop.curMenu = new LoginMenu(webShop.currentCustomer);
        }

        public void Back(WebShop webShop)
        {
            webShop.curMenu = new MainMenu(webShop.currentCustomer);
        }
    }
}

