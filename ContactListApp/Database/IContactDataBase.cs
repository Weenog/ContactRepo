using ContactListApp.Controllers;
using ContactListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListApp.Database

{
    public interface IContactDatabase
    {
        IEnumerable<Contact> GetContacts();
        Contact Insert(Contact contact);
        Contact GetContact(int id);
        void Delete(int id);
        void Update(int id, Contact contact);
    }


    public class ContactDatabase : IContactDatabase
    {
        private int _counter;
        private readonly List<Contact> _contacts;

        public ContactDatabase()
        {

            if (_contacts == null)
            {
                _contacts = new List<Contact>();
            }
        }

        public Contact GetContact(int id)
        {
            return _contacts.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }

        public Contact Insert(Contact contact)
        {
            _counter++;
            contact.Id = _counter;
            _contacts.Add(contact);
            return contact;
        }

        public void Delete(int id)

        {

            var contact = _contacts.SingleOrDefault(x => x.Id == id);

            if (contact != null)

            {

                _contacts.Remove(contact);

            }

        }
        public void Update(int id, Contact updatedContact)
        {
            var contact = _contacts.SingleOrDefault(x => x.Id == id);
            if (contacts != null)
            {
                contact.FirstName = updatedContact.FirstName;
                contact.Lastname = updatedContact.LastName;
                contact.Email = updatedContact.Email;
                contact.TelNr = updatedContact.TelNr;
                contact.Adress = updatedContact.Adress;
                contact.Description = updated.Description;
            }






        }
    }
}

 