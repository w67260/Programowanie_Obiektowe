using System;

namespace Lab3_2
{
    internal class Samochod
    {
        //Pola w kasie Samochod
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public int Przebieg { get; set; }

        //Konstruktor bez parametrów
        public Samochod()
        {
            Console.WriteLine("Podaj dane samochodu:");
            Console.Write("Marka: "); //Marka
            Marka = Console.ReadLine();

            Console.Write("Model: "); //Model
            Model = Console.ReadLine();

            Console.Write("Nadwozie: "); //Nadwozie
            Nadwozie = Console.ReadLine();

            Console.Write("Kolor: "); //Kolor
            Kolor = Console.ReadLine();

            Console.Write("Rok produkcji: "); //Rok produkcji
            RokProdukcji = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Przebieg: ");
                Przebieg = int.Parse(Console.ReadLine());
                if ( Przebieg < 0)
                {
                    Console.WriteLine("Podaj poprawny przebieg");
                }
            } while (Przebieg < 0);
        }

        //Konstruktor z 6 parametrami
        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        //Metoda wyświetlająca dane o samochodzie
        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {Nadwozie}");
            Console.WriteLine($"Kolor: {Kolor}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Przebieg: {Przebieg} km");
        }
    }
}
