using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.MenusCommands;

namespace WebShopCleanCode.Menus
{
    public class PurchaseMenu : MenuStates
    {
        public int CurrentChoice { get; set; }
        public int AmountOfOptions { get; set; }
        public List<string> Options { get; set; }
        public List<IMenuCommand> MenuCommands { get; set; }
        public string Info { get; set; }

        List<ProductProxy> products;
        Customer currentCustomer;

        public PurchaseMenu(List<ProductProxy> products,Customer currentCustomer)
        {
            this.currentCustomer= currentCustomer;
            CurrentChoice = 1;      
            MenuCommands = null;
            Info = "What would you like to purchase?";
            Options = new List<string>();
            this.products = products;
            for (int i = 0; i < products.Count; i++)
            {
                Options.Add(i + 1 + ": " + products[i].Name + ", " + products[i].Price + "kr");
            }
            AmountOfOptions = Options.Count;
            //Console.WriteLine("Your funds: " + currentCustomer.Funds);
        }

        public void ExecuteCurrentChoice(WebShop webShop)
        {
            int index = CurrentChoice - 1;
            ProductProxy product = webShop.products[index];
            if (product.InStock())
            {
                if (currentCustomer.CanAfford(product.Price))
                {
                    currentCustomer.Funds -= product.Price;
                    product.NrInStock--;
                    currentCustomer.Orders.Add(new Order(product.Name, product.Price, DateTime.Now));
                    Console.WriteLine();
                    Console.WriteLine("Successfully bought " + product.Name);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You cannot afford.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not in stock.");
                Console.WriteLine();
            }
        }

        public void Refresh(WebShop webShop)
        {
            if (webShop.currentCustomer != null)
            {
                webShop.curMenu = new PurchaseMenu(webShop.products,webShop.currentCustomer);
            }
            else { webShop.curMenu = new MainMenu(webShop.currentCustomer); }
        }

        public void Back(WebShop webShop)
        {
            webShop.curMenu = new WaresMenu(webShop.currentCustomer);
        }
        /*if (currentCustomer != null)
                           {
                               currentMenu = "purchase menu";
                               info = ;
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
                           break;*/

        /*else if (currentMenu.Equals("purchase menu"))
                        {
                            int index = currentChoice - 1;
                            Product product = products[index];
                            if (product.InStock())
                            {
                                if (currentCustomer.CanAfford(product.Price))
                                {
                                    currentCustomer.Funds -= product.Price;
                                    product.NrInStock--;
                                    currentCustomer.Orders.Add(new Order(product.Name, product.Price, DateTime.Now));
                                    Console.WriteLine();
                                    Console.WriteLine("Successfully bought " + product.Name);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You cannot afford.");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not in stock.");
                                Console.WriteLine();
                            }
                        }
                        break;*/
    }
}
