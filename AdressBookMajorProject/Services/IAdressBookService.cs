using AdressBookMajorProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookMajorProject.Services
{
    interface IAdressBookService
    {
        AdressBook Create(AdressBook adressBook);
        AdressBook Uptade(int id, AdressBook adressBook);
        AdressBook[] Read();
        bool Delete(int id);
        AdressBook Find(int id);
        int Findid();

    }
}
