using AdressBookMajorProject.Model;
using AdressBookMajorProject.Services;
using System;

namespace AdressBookMajorProject
{
    class Program
    {
        static void Main(string[] args)

        {
            byte choise = 255;
            AdressBookService adressbookService = new AdressBookService();

            Console.WriteLine("Welcome to Adress Book Major Information System!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("You can choose following choises from following list:");
                Console.WriteLine();
                Console.WriteLine("1. Create adress book");
                Console.WriteLine("2. Update adress book");
                Console.WriteLine("3. Delete adress book");
                Console.WriteLine("4. Find adress book");
                Console.WriteLine("5. Read adress book");
                Console.WriteLine("0. Exit");

                if (byte.TryParse(Console.ReadLine(), out choise))
                {

                    switch (choise)
                    {
                        case 1:
                            AdressBook newAdressBook = new AdressBook();

                            newAdressBook.Id = adressbookService.Findid();

                            Console.WriteLine("Enter the Name :");
                            newAdressBook.Name = Console.ReadLine();

                            Console.WriteLine("Enter the Surname");
                            newAdressBook.Surname = Console.ReadLine();

                            Console.WriteLine("Enter the address of the user");
                            newAdressBook.Adress = Console.ReadLine();

                            adressbookService.Create(newAdressBook);
                            Console.WriteLine("New user adress book added Succesfully!");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Select ID of the user for uptade");

                            foreach (var item in adressbookService.Read())
                            {
                                Console.WriteLine($"ID: {item.Id}, Name :{item.Name}, Surname :{item.Surname}, Adress: {item.Adress} ");
                            }
                            int adrId = Convert.ToInt32(Console.ReadLine());
                            AdressBook adressBook = adressbookService.Find(adrId);

                            Console.WriteLine($"enter new name {adressBook.Name}:");
                            adressBook.Name = Console.ReadLine();

                            Console.WriteLine($"enter new Surname {adressBook.Surname}:");
                            adressBook.Surname = Console.ReadLine();

                            Console.WriteLine($"enter new Adresss {adressBook.Adress}:");
                            adressBook.Adress = Console.ReadLine();

                            adressbookService.Uptade(adrId, adressBook);
                            Console.WriteLine();

                            break;
                        case 3:
                            Console.WriteLine("Please Choise Id for Delete User!");
                            AdressBook[] adresses2 = adressbookService.Read();

                            for (int i = 0; i < adresses2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {adresses2[i].Id}, Name: {adresses2[i].Name}, Surname: {adresses2[i].Surname}, Adress {adresses2[i].Adress};");
                            }
                            int IdForDelete = Convert.ToInt32(Console.ReadLine());
                            adressbookService.Delete(IdForDelete);

                            Console.WriteLine("User Deleted!");

                            Console.WriteLine();


                            break;
                        case 4:
                            Console.WriteLine("Please enter id of the user");

                            int Id = Convert.ToInt32(Console.ReadLine());

                            AdressBook adress1 = adressbookService.Find(Id);
                            Console.WriteLine($"Id: {adress1.Id}, Name: {adress1.Name}, Surname: {adress1.Surname}, Adress : {adress1.Adress}");

                            Console.WriteLine();

                            break;
                        case 5:
                            AdressBook[] adresses = adressbookService.Read();

                            for (int i = 0; i < adresses.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {adresses[i].Id}, Name: {adresses[i].Name}, Surname: {adresses[i].Surname}, Adress : {adresses[i].Adress} ");
                            }
                            Console.WriteLine();
                            break;

                        case 0:
                            Console.WriteLine("Exit!");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("You can only select from list!");
                            Console.WriteLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Please choise only select from list!");
                    Console.WriteLine();
                    choise = 255;
                }

            } while (choise != 0);

        }
    }
}
