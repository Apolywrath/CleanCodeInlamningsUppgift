using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebShopCleanCode.InputCommand;
using WebShopCleanCode.Menus;

namespace WebShopCleanCode
{
    public class WebShop
    {
        bool running = true;
        Database database = new Database();
        public List<ProductProxy> products = new List<ProductProxy>();
        public List<Customer> customers = new List<Customer>();
        public MenuStates curMenu { get; set; }
        private List<IInputCommand> inputCommands = new List<IInputCommand>();
        public string username = null;
        public string password = null;
        public Customer currentCustomer;

        public WebShop()
        {
            products = database.GetProductProxies();
            customers = database.GetCustomers();
            curMenu = new MainMenu(currentCustomer);
            inputCommands.Add(new LeftCommand());
            inputCommands.Add(new RightCommand());
            inputCommands.Add(new OkCommand());
            inputCommands.Add(new QuitCommand());
        }


        public void Run()
        {
            Console.WriteLine("Welcome to the WebShop!");
            while (running)
            {
                PrintMenu();

                string choice = Console.ReadLine().ToLower();

                bool validOption = false;
                foreach(IInputCommand command in inputCommands) 
                {
                    if(command.ExecuteInputCommand(this, choice))
                    {
                        validOption = true;
                        break;
                    }
                }
                if(validOption = false)
                {
                    new DefaultCommand().ExecuteInputCommand(this,choice);
                }
               
            }
        }
        public void Quit()
        {
            running = false;
        }
        private void PrintMenu()
        {
            Console.WriteLine(curMenu.Info);

            for (int opt = 1; opt <= curMenu.AmountOfOptions; opt++)
            { Console.WriteLine(opt + ": " + curMenu.Options[opt - 1]); }

            // Skriver ut hur många Options den tar med och sedan en TAB
            for (int i = 0; i < curMenu.AmountOfOptions; i++)
            {
                Console.Write(i + 1 + "\t");
            }
            Console.WriteLine();
            // Kollar om currentChoice som default är på 1 om i < 1 vilket är 1 < 1 Men currentChoice Kan ökas.
            for (int i = 1; i < curMenu.CurrentChoice; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("|");

            Console.WriteLine("Your buttons are Left, Right, OK, Back and Quit.");
            // Kollar om man är inloggad eller ej
            if (currentCustomer != null)
            {
                Console.WriteLine("Current user: " + currentCustomer.Username);
            }
            else
            {
                Console.WriteLine("Nobody logged in.");
            }
        }
    }
}
