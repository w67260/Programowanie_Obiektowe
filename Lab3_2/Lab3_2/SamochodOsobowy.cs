using System;

namespace Lab3_2
{
    internal class SamochodOsobowy : Samochod
    {
        //Pola klasy SamochodOsobowy
        public double Waga;
        public double PojemnoscSilnika;
        public int IloscOsob;

        //Konstruktor klasy SamochodOsobowy
        public SamochodOsobowy() : base()
        {
            Console.WriteLine("Podaj dane samochodu osobowego:");
            Console.Write("Waga (2 t - 4,5 t): "); //Waga
            do
            {
                Waga = double.Parse(Console.ReadLine());
                if(Waga <= 2 || Waga >= 4.5)
                {
                    Console.WriteLine("Podaj odpowiednią wagę");
                }
            } while (Waga <= 2 || Waga >= 4.5);

            Console.Write("Pojemność silnika (0,8 - 3,0): "); //Pojemność silnika
            do
            {
                PojemnoscSilnika = double.Parse(Console.ReadLine());
                if (PojemnoscSilnika <= 0.8 || PojemnoscSilnika >= 3.0)
                {
                    Console.WriteLine("Podaj odpowiednią pojemność silnika");
                }
            } while (PojemnoscSilnika <= 0.8 || PojemnoscSilnika >= 3.0);

            Console.Write("Ilość osób: "); //Ilość osób
            IloscOsob = int.Parse(Console.ReadLine());
        }

        //Metoda wyświetlająca dane o samochodzie
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje(); // Wywołanie metody klasy bazowej
            Console.WriteLine($"Waga: {Waga} t");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
            Console.WriteLine($"Ilość osób: {IloscOsob}");
        }
    }
}
