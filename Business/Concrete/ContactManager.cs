using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repositoryContact = new Repository<Contact>();

        public int Add(Contact contact)
        {
            if (contact.Mail == "" || contact.Message == "" || contact.Name == "" || contact.Subject == "" || contact.Surname == "" || contact.Mail.Length <= 10 || contact.Subject.Length < 3)
            {
                return -1;
            }

            return repositoryContact.Insert(contact);
        }

        public List<Contact> GetAll()
        {
            return repositoryContact.List();
        }

        public Contact GetContactDetails(int id)
        {
            return repositoryContact.Find(x => x.ContactId == id);
        }
    }
}
