﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode
{
    internal class Temp
    {
        /*
         * if (currentMenu.Equals("main menu"))
                        {
                            // Detta borde kunda ändras om till DesignPattern States
                            switch (currentChoice)
                            {
                                case 1:
                                    option1 = "See all wares";
                                    option2 = "Purchase a ware";
                                    option3 = "Sort wares";
                                    if (currentCustomer == null)
                                    {
                                        option4 = "Login";
                                    }
                                    else
                                    {
                                        option4 = "Logout";
                                    }
                                    amountOfOptions = 4;
                                    currentChoice = 1;
                                    currentMenu = "wares menu";
                                    info = "What would you like to do?";
                                    break;
                                case 2:
                                    if (currentCustomer != null)
                                    {
                                        option1 = "See your orders";
                                        option2 = "Set your info";
                                        option3 = "Add funds";
                                        option4 = "";
                                        amountOfOptions = 3;
                                        currentChoice = 1;
                                        info = "What would you like to do?";
                                        currentMenu = "customer menu";
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Nobody is logged in.");
                                        Console.WriteLine();
                                    }
                                    break;
                                case 3:
                                    if (currentCustomer == null)
                                    {
                                        option1 = "Set Username";
                                        option2 = "Set Password";
                                        option3 = "Login";
                                        option4 = "Register";
                                        amountOfOptions = 4;
                                        currentChoice = 1;
                                        info = "Please submit username and password.";
                                        username = null;
                                        password = null;
                                        currentMenu = "login menu";
                                    }
                                    else
                                    {
                                        option3 = "Login";
                                        Console.WriteLine();
                                        Console.WriteLine(currentCustomer.Username + " logged out.");
                                        Console.WriteLine();
                                        currentChoice = 1;
                                        currentCustomer = null;
                                    }
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        else if (currentMenu.Equals("customer menu")) {
                            switch (currentChoice)
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
                            }
                        }
                        else if (currentMenu.Equals("sort menu"))
                        {
                            bool back = true;
                            switch (currentChoice)
                            {
                                case 1:
                                    bubbleSort("name", false);
                                    Console.WriteLine();
                                    Console.WriteLine("Wares sorted.");
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    bubbleSort("name", true);
                                    Console.WriteLine();
                                    Console.WriteLine("Wares sorted.");
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    bubbleSort("price", false);
                                    Console.WriteLine();
                                    Console.WriteLine("Wares sorted.");
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    bubbleSort("price", true);
                                    Console.WriteLine();
                                    Console.WriteLine("Wares sorted.");
                                    Console.WriteLine();
                                    break;
                                default:
                                    back = false;
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;
                            }
                            if (back)
                            {
                                option1 = "See all wares";
                                option2 = "Purchase a ware";
                                option3 = "Sort wares";
                                if (currentCustomer == null)
                                {
                                    option4 = "Login";
                                }
                                else
                                {
                                    option4 = "Logout";
                                }
                                amountOfOptions = 4;
                                currentChoice = 1;
                                currentMenu = "wares menu";
                                info = "What would you like to do?";
                            }
                        }
                        else if (currentMenu.Equals("wares menu"))
                        {
                            switch (currentChoice)
                            {
                                case 1:
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
                                    break;
                            }
                        }
                        else if (currentMenu.Equals("login menu"))
                        {
                            switch (currentChoice)
                            {
                                case 1:
                                    Console.WriteLine("A keyboard appears.");
                                    Console.WriteLine("Please input your username.");
                                    username = Console.ReadLine();
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    Console.WriteLine("A keyboard appears.");
                                    Console.WriteLine("Please input your password.");
                                    password = Console.ReadLine();
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    if (username == null || password == null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Incomplete data.");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        bool found = false;
                                        foreach (Customer customer in customers)
                                        {
                                            if (username.Equals(customer.Username) && customer.CheckPassword(password))
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(customer.Username + " logged in.");
                                                Console.WriteLine();
                                                currentCustomer = customer;
                                                found = true;
                                                option1 = "See Wares";
                                                option2 = "Customer Info";
                                                if (currentCustomer == null)
                                                {
                                                    option3 = "Login";
                                                }
                                                else
                                                {
                                                    option3 = "Logout";
                                                }
                                                info = "What would you like to do?";
                                                currentMenu = "main menu";
                                                currentChoice = 1;
                                                amountOfOptions = 3;
                                                break;
                                            }
                                        }
                                        if (found == false)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid credentials.");
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Please write your username.");
                                    string newUsername = Console.ReadLine();
                                    foreach (Customer customer in customers)
                                    {
                                        if (customer.Username.Equals(username))
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Username already exists.");
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                    // Would have liked to be able to quit at any time in here.
                                    choice = "";
                                    bool next = false;
                                    string newPassword = null;
                                    string firstName = null;
                                    string lastName = null;
                                    string email = null;
                                    int age = -1;
                                    string address = null;
                                    string phoneNumber = null;
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want a password? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your password.");
                                                newPassword = Console.ReadLine();
                                                if (newPassword.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want a first name? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your first name.");
                                                firstName = Console.ReadLine();
                                                if (firstName.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want a last name? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your last name.");
                                                lastName = Console.ReadLine();
                                                if (lastName.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want an email? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your email.");
                                                email = Console.ReadLine();
                                                if (email.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want an age? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your age.");
                                                string ageString = Console.ReadLine();
                                                try
                                                {
                                                    age = int.Parse(ageString);
                                                }
                                                catch (FormatException e)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please write a number.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                next = true;
                                                break;
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want an address? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your address.");
                                                address = Console.ReadLine();
                                                if (address.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            next = false;
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want a phone number? y/n");
                                        choice = Console.ReadLine();
                                        if (choice.Equals("y"))
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Please write your phone number.");
                                                phoneNumber = Console.ReadLine();
                                                if (phoneNumber.Equals(""))
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Please actually write something.");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                                else
                                                {
                                                    next = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (choice.Equals("n") || next)
                                        {
                                            break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("y or n, please.");
                                        Console.WriteLine();
                                    }

                                    Customer newCustomer = new Customer(newUsername, newPassword, firstName, lastName, email, age, address, phoneNumber);
                                    customers.Add(newCustomer);
                                    currentCustomer = newCustomer;
                                    Console.WriteLine();
                                    Console.WriteLine(newCustomer.Username + " successfully added and is now logged in.");
                                    Console.WriteLine();
                                    option1 = "See Wares";
                                    option2 = "Customer Info";
                                    if (currentCustomer == null)
                                    {
                                        option3 = "Login";
                                    }
                                    else
                                    {
                                        option3 = "Logout";
                                    }
                                    info = "What would you like to do?";
                                    currentMenu = "main menu";
                                    currentChoice = 1;
                                    amountOfOptions = 3;
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Not an option.");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        else if (currentMenu.Equals("purchase menu"))
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
         */





        /*if (currentMenu.Equals("main menu"))
                        {
                            Console.WriteLine();
                            Console.WriteLine("You're already on the main menu.");
                            Console.WriteLine();
                        }
                        else if (currentMenu.Equals("purchase menu"))
                        {
                            option1 = "See all wares";
                            option2 = "Purchase a ware";
                            option3 = "Sort wares";
                            if (currentCustomer == null)
                            {
                                option4 = "Login";
                            }
                            else
                            {
                                option4 = "Logout";
                            }
                            amountOfOptions = 4;
                            currentChoice = 1;
                            currentMenu = "wares menu";
                            info = "What would you like to do?";
                        }
                        else
                        {
                            option1 = "See Wares";
                            option2 = "Customer Info";
                            if (currentCustomer == null)
                            {
                                option3 = "Login";
                            }
                            else
                            {
                                option3 = "Logout";
                            }
                            info = "What would you like to do?";
                            currentMenu = "main menu";
                            currentChoice = 1;
                            amountOfOptions = 3;
                        }*/
    }
}
