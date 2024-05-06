namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList list = new ContactList();

            while (true)
            {
                int option = Menu();

                switch (option)
                {
                    case 1:
                        AddContact(list);
                        break;
                    case 2:
                        RemoveContact(list);
                        break;
                    case 3:
                        list.Print();
                        break;
                    case 0:
                        Console.WriteLine("Quitting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }

        static void AddContact(ContactList list)
        {
            Console.WriteLine("======Add Contact======");

            Console.Write("Enter contact's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter contact's phone: ");
            string phone = Console.ReadLine();

            list.Add(new Contact(name, phone));
        }

        static void RemoveContact(ContactList list)
        {

            Console.WriteLine("======Remove Contact======");
            list.Print();
            Console.WriteLine("===========================");

            Console.Write("Enter contact's name: ");
            string name = Console.ReadLine();

            if (list.RemoveByName(name))
            {
                Console.WriteLine("Contact removed!");
            }
            else
            {
                Console.WriteLine("Can't find that person in contacts!");
            }
        }


        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("======Contact List======");

            Console.WriteLine("Options: ");
            Console.WriteLine("1- Add new contact");
            Console.WriteLine("2- Remove a contact");
            Console.WriteLine("3- List all contacts");
            Console.WriteLine("0- Exit");
            Console.Write("R: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                return option;
            }
            else
            {
                Console.WriteLine("You must enter a number!");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                return Menu();
            }
        }
    }
}
