using PhoneBookApp.Interface;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Services
{

    
    internal class ContactService : IContactService
    {
        private List<Contacts> contacts = new List<Contacts>();
        
       
        
        public void AddToList(IContacts contact)
        {                       
            contacts.Add((Contacts)contact);
                   
        }

        

        public IContacts Get(Contacts contact)
        {
            var _name = Console.ReadLine();

            bool NameFound = false;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name == _name)
                {
                    Console.WriteLine("The contact was found!");
                    Console.WriteLine(contacts[i].Name);
                    NameFound = true;
                }
            }
                if (!NameFound)
                {
                    Console.WriteLine("404 could not find, did you spell the name correctly?");
                }

            
            return null!;

        }

        public IEnumerable<IContacts> GetAll()
        {
            foreach (var contact in contacts)
                Console.WriteLine($"{contact.Name} {contact.Email} {contact.PhoneNumber} {contact.City}");
            return contacts;
                    
            
        }

        public void RemoveFromList(string Name)
        {
            var _name = Console.ReadLine();

            bool NameFound = false;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name == _name)
                {
                    Console.WriteLine(contacts[i].Name);
                    NameFound = true;
                    Console.WriteLine("The contact was found, are you sure you want to remove it? (y/n)");

                    var UserInput = Console.ReadLine();
                    if (UserInput == "y")
                    {
                        contacts.Remove(contacts[i]);
                        Console.WriteLine("The contact has been removed!");
                    }
                    else if (UserInput == "n")
                    {
                        Console.WriteLine("That's what i thought! You need this contact");
                    }
                }
            }
            if (!NameFound)
            {
                Console.WriteLine("404 could not find, did you spell the name correctly?");
            }


            
        }
    }
}
