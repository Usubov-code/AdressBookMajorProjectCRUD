using AdressBookMajorProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookMajorProject.Services
{
    class AdressBookService : IAdressBookService
    {
         private AdressBook[] AdressBooks=new AdressBook[0];
        public AdressBook Create(AdressBook adressBook)
        {
            Array.Resize(ref AdressBooks, AdressBooks.Length + 1);
            AdressBooks[AdressBooks.Length - 1] = adressBook;
            return adressBook;
        }

        public bool Delete(int id)
        {
            AdressBooks = Array.FindAll(AdressBooks, e => e.Id != id);

            return true;
        }

        public AdressBook Find(int id)
        {
            AdressBook foundAdressBooks = Array.Find(AdressBooks, e => e.Id == id);
            return foundAdressBooks;
        }

        public int Findid()
        {
            if (AdressBooks.Length==0)
            {
                return 1;

            }
            return AdressBooks[AdressBooks.Length - 1].Id + 1;
        }

        public AdressBook[] Read()
        {
            return this.AdressBooks;
        }

        public AdressBook Uptade(int id, AdressBook adressBook)
        {
            AdressBook uptadeAdressBook = Array.Find(AdressBooks, e => e.Id == id);

            uptadeAdressBook = adressBook;
            return adressBook;
        }
    }
}
