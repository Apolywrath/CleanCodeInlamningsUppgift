using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class MainMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        public List<string> Options { get; set; }
        public string Info { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }

        Customer currentCustomer;
        public MainMenu(Customer currentCustomer)
        {
            Options = new List<string>() { "See Wares", "Customer Info", "Login" };
            CurrentChoice = 1;
            AmountOfOptions= Options.Count;
            this.currentCustomer = currentCustomer;
            Info = "What would you like to do?";
            MenuCommands = new List<IMenuCommand>() { new WaresMenuCommand(), new CustomerMenuCommand(), new LoginMenuCommand() };

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
            webShop.curMenu = new MainMenu(webShop.currentCustomer);
        }

        public void Back(WebShop webShop)
        {
        }


        /*
         
        if (currentMenu.Equals("main menu"))
                        {
                            // Detta borde kunda ändras om till DesignPattern States
                            switch (currentChoice)
                            {
                                case 1:
                                    
                                case 2:
                                    
                                    break;
                                case 3:
                                    
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;
                            }
         * */
    }
}
