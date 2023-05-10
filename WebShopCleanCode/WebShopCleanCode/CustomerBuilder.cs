using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebShopCleanCode
{
    public class CustomerBuilder
    {
        string username;
        string password;
        string firstName;
        string lastName;
        string email;
        int age;
        string address;
        string phoneNumber;
 
        public CustomerBuilder()
        {
            username = "";
            password = "";
            firstName = "";
            lastName = "";
            email = "";
            age = -1;
            address = "";
            phoneNumber = "";
        }

        public void getInputFromUser(string textToPrint,string dataUpdate)
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Do you want a "+ textToPrint + "? y/n");
                choice = Console.ReadLine().ToLower();
                if (choice.Equals("y"))
                {
                    while (true)
                    {
                        Console.WriteLine("Please write your "+ textToPrint + ".");
                        string dataInput = Console.ReadLine();
                        if (dataInput.Equals(""))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please actually write something.");
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            dataUpdate= dataInput;
                        }
                    }
                }
                if (choice.Equals("n"))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("y or n, please.");
                Console.WriteLine();
            }         
         }
        public CustomerBuilder Username(WebShop webShop)
        {          
            while (true) 
            {
                Console.WriteLine("Please write your username.");
                string newUsername = Console.ReadLine();
                bool usernameInUse = false;
                foreach (Customer customer in webShop.customers)
                {
                    if (customer.Username.Equals(newUsername))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Username already exists.");
                        Console.WriteLine();
                        usernameInUse = true;
                        break; ;
                    }
                }
                if (usernameInUse.Equals(false))
                {
                    username = newUsername;
                    break;
                }
            }
            return this;
        }
        public CustomerBuilder Password()
        {
            getInputFromUser("password", password);

            return this;
        }
        public CustomerBuilder FirstName()
        {
            getInputFromUser("first name", firstName);
            return this;
        }
        public CustomerBuilder LastName()
        {
            getInputFromUser("last name", lastName);
            return this;
        }
        public CustomerBuilder Email()
        {
            getInputFromUser("email", email);
            return this;
        }
        public CustomerBuilder Age()
        {
            string choice;
            int tempAge = 0;
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
                            tempAge = int.Parse(ageString);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please write a number.");
                            Console.WriteLine();
                            continue;
                        }
                        break;
                    }
                }
                if (choice.Equals("n"))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("y or n, please.");
                Console.WriteLine();
            }
            this.age = tempAge;
            return this;
        }
        public CustomerBuilder Address()
        {
            getInputFromUser("adress", address);
            return this;
        }
        public CustomerBuilder PhoneNumber()
        {
            getInputFromUser("phonenumber", phoneNumber);
            return this;
        }

        public Customer Build()
        {
            return new Customer(username,password,firstName,lastName,email, age, address, phoneNumber);
        }
    }
}
