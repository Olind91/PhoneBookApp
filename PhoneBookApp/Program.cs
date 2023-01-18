using PhoneBookApp.Models;
using PhoneBookApp.Services;
using System;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to this fantastic and not buggy phonebook! What would you like to do?");
                Console.WriteLine("1. Create a new contact");
                Console.WriteLine("2. Show all existing contacts");
                Console.WriteLine("3. Show a specific contact");
                Console.WriteLine("4. Remove a contact");
                Console.WriteLine("5. Exit to lobby");

                var UserInput = Console.ReadLine();

                var contactService = new ContactService();



            
                switch (UserInput)
                {
                    case "1":
                        Console.Clear();
                        var NewContact = new Contacts();
                        
                        Console.WriteLine("Please enter you First and Lastname");
                        NewContact.Name = Console.ReadLine();
                        Console.WriteLine("And your Email");
                        NewContact.Email = Console.ReadLine();
                        Console.WriteLine("Almost done, now please fill in your phonenumber");
                        NewContact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("And finally, what city are you living in?");
                        NewContact.City = Console.ReadLine();

                        contactService.AddToList(NewContact);

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Your contacts");
                        contactService.GetAll();
                        Console.ReadKey();
                        
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please enter a name you wish to find");
                        contactService.Get(null!);
                        Console.ReadLine();

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter the name of the contact you wish to remove");
                        contactService.RemoveFromList(null!);
                        Console.ReadLine();

                        break;

                    case "5":
                        return;


                    default:
                        Console.WriteLine("Please choose correctly");
                        break;


                }

                    
            }

            
        }
    }
}