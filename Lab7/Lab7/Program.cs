namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookManager addressBookManager = new AddressBookManager();

            while (true)
            {
                Console.WriteLine("Menu główne:");
                Console.WriteLine("1. Wyświetl dane");
                Console.WriteLine("2. Dodaj osobę");
                Console.WriteLine("3. Modyfikuj osobę");
                Console.WriteLine("4. Usuń osobę");
                Console.WriteLine("5. Wyjście z programu");

                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBookManager.DisplayData();
                        break;
                    case "2":
                        addressBookManager.AddPerson();
                        break;
                    case "3":
                        addressBookManager.ModifyPerson();
                        break;
                    case "4":
                        addressBookManager.RemovePerson();
                        break;
                    case "5":
                        addressBookManager.SaveToCsv();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Wybierz ponownie.");
                        break;
                }
            }
        }
    }
}