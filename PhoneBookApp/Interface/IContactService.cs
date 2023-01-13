using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Interface
{
    internal interface IContactService
    {
        void AddToList(IContacts contacts);


        

        IEnumerable<IContacts> GetAll();

        IContacts Get(Contacts contact);
        
        void RemoveFromList( string Name);
    }
}