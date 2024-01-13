namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tworzenie obiektu klasy SamochodOsobowy
            SamochodOsobowy osobowy = new SamochodOsobowy();

            //Tworzenie dwóch obiektów klasy Samochod
            Samochod samochod1 = new Samochod();
            Samochod samochod2 = new Samochod("Toyota", "Corolla", "Sedan", "Czerwony", 2020, 50000);

            Console.Clear();

            Console.WriteLine("Informacje o samochodzie osobowym");
            osobowy.WyswietlInformacje();
            Console.WriteLine();

            Console.WriteLine("Informacje o samochodzie1");
            samochod1.WyswietlInformacje();
            Console.WriteLine();

            Console.WriteLine("Informacje o samochodzie2");
            samochod2.WyswietlInformacje();
            Console.WriteLine();
        }
    }
}