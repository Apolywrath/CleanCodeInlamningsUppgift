using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class CustomerMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        //int currentChoice = 1;
        public List<string> Options { get; set; }
        //int amountOfOptions;
        public string Info { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }

        Customer currentCustomer;

        public CustomerMenu(Customer currentCustomer)
        {
            Options = new List<string>() { "See your orders", "Set your info", "Add funds" };
            CurrentChoice = 1;
            AmountOfOptions = Options.Count;
            this.currentCustomer = currentCustomer;
            Info = "What would you like to do?";
            MenuCommands = new List<IMenuCommand>() {new PrintOrdersCommand(),new PrintInfoCommand(), new AddFundsCommand() };
        }

        

        public void ExecuteCurrentChoice(WebShop webShop)
        {
            MenuCommands[CurrentChoice-1].ExecuteMenuCommand(webShop);
        }

        public void Refresh(WebShop webShop)
        {
            if(webShop.currentCustomer!= null) { 
            webShop.curMenu = new CustomerMenu(webShop.currentCustomer);
            }
            else { webShop.curMenu = new MainMenu(webShop.currentCustomer); }

        }

        public void Back(WebShop webShop)
        {
            webShop.curMenu = new MainMenu(webShop.currentCustomer);
        }

        //Detta ska man kunna göra i detta statet:
        /*switch (currentChoice)
                            {
                                case 1:
                                    currentCustomer.PrintOrders();
                                    break;
                                case 2:
                                    currentCustomer.PrintInfo();
                                    break;
                                case 3:
                                    Console.WriteLine("How many funds would you like to add?");
                                    string amountString = Console.ReadLine();
                                    try
                                    {
                                        int amount = int.Parse(amountString);
                                        if (amount < 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Don't add negative amounts.");
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            currentCustomer.Funds += amount;
                                            Console.WriteLine();
                                            Console.WriteLine(amount + " added to your profile.");
                                            Console.WriteLine();
                                        }
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Please write a number next time.");
                                        Console.WriteLine();
                                    }
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;
                            }*/
    }
}
