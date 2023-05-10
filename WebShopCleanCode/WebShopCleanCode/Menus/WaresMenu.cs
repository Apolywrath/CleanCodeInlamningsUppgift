using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class WaresMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        public List<string> Options { get; set; }
        public string Info { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }

        Customer currentCustomer;

        public WaresMenu(Customer currentCustomer)
        {
            Options = new List<string>() { "See all wares", "Purchase a ware", "Sort wares", "Login" };
            CurrentChoice = 1;
            AmountOfOptions = Options.Count;
            this.currentCustomer = currentCustomer;
            Info = "What would you like to do?";
            MenuCommands = new List<IMenuCommand>() { new PrintProductsCommand(), new PurchaseMenuCommand(),new SortMenuCommand(),new LoginMenuCommand() };
            if (currentCustomer != null)
            {
                Options[3] = "Logout";
                MenuCommands[3] = new LogoutCommand();
            }
        }

        public void ExecuteCurrentChoice(WebShop webShop)
        {
            MenuCommands[CurrentChoice-1].ExecuteMenuCommand(webShop);
        }

        public void Refresh(WebShop webShop)
        {
            webShop.curMenu = new WaresMenu(currentCustomer);
        }

        public void Back(WebShop webShop)
        {
            webShop.curMenu = new SortMenu(currentCustomer);
        }
    }
}
/*case 1:
                                    Console.WriteLine();
                                    foreach (Product product in products)
                                    {
                                        product.PrintInfo();
                                    }
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    if (currentCustomer != null)
                                    {
                                        currentMenu = "purchase menu";
                                        info = "What would you like to purchase?";
                                        currentChoice = 1;
                                        amountOfOptions = products.Count;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You must be logged in to purchase wares.");
                                        Console.WriteLine();
                                        currentChoice = 1;
                                    }
                                    break;
                                case 3:
                                    option1 = "Sort by name, descending";
                                    option2 = "Sort by name, ascending";
                                    option3 = "Sort by price, descending";
                                    option4 = "Sort by price, ascending";
                                    info = "How would you like to sort them?";
                                    currentMenu = "sort menu";
                                    currentChoice = 1;
                                    amountOfOptions = 4;
                                    break;
                                case 4:
                                    if (currentCustomer == null)
                                    {
                                        option1 = "Set Username";
                                        option2 = "Set Password";
                                        option3 = "Login";
                                        option4 = "Register";
                                        amountOfOptions = 4;
                                        info = "Please submit username and password.";
                                        currentChoice = 1;
                                        currentMenu = "login menu";
                                    }
                                    else
                                    {
                                        option4 = "Login";
                                        Console.WriteLine();
                                        Console.WriteLine(currentCustomer.Username + " logged out.");
                                        Console.WriteLine();
                                        currentCustomer = null;
                                        currentChoice = 1;
                                    }
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;*/