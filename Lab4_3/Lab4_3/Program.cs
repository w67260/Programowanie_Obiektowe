namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tworzenie kilku objektów klasy Osoba
            Osoba Osoba = new Osoba { Imie = "Jan", Nazwisko = "Kowalski" };
            Student Student = new Student { Imie = "Anna", Nazwisko = "Nowak", Uczelnia = "Politechnika", Kierunek = "Informatyka", Rok = 2, Semestr = 3 };
            StudentWSIiZ StudentWSIiZ = new StudentWSIiZ { Imie = "Piotr", Nazwisko = "Kwiatkowski", Uczelnia = "WSIiZ", Kierunek = "Ekonomia", Rok = 1, Semestr = 2 };

            //Dodawanie objektów do listy List<Osoba>
            List<IOsoba> listaOsob = new List<IOsoba>
            {
                Osoba,
                Student,
                StudentWSIiZ
            };

            //Wyświetlanie pełnych nazw osób z listy
            /*foreach (var osoba in listaOsob)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }*/

            //Sortowanie osób po nazwisko i ich wypisanie
            listaOsob.PosortujOsobyPoNazwisku();
            listaOsob.WypiszOsoby();

            Console.WriteLine();

            //Tworzenie obiektu Student
            Student student = new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Uczelnia = "WSiZ",
                Kierunek = "Informatyka",
                Rok = 2018,
                Semestr = 4
            };
            student.WypiszPelnaNazweIUczelnie();

            Console.WriteLine();

            foreach (var osoba in listaOsob)
            {
                if (osoba is StudentWSIiZ studentWSIiZ)
                {
                    studentWSIiZ.WypiszPelnaNazweIUczelnie();
                }
            }
        }
    }
}