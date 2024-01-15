using System;

namespace Lab4_2
{
    internal class Osoba
    {
        //Pola klasy Osoba
        public string Imie;
        public string Nazwisko;
        public string Pesel;

        //Metody ustawiające Imie, Nazwisko i Pesel
        public void SetFirstName(string firstName)
        {
            Imie = firstName;
        }
        public void SetLastName(string lastName)
        {
            Nazwisko = lastName;
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        //Metody pobierające wiek i płeć
        public int GetAge()
        {
            int birthYear = int.Parse(Pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year;
            int century;

            if (birthYear < currentYear % 100)
            {
                century = 2000;
            }
            else
            {
                century = 1900;
            }

            int age = currentYear - century - birthYear;
            return age;
        }
        public char GetGender()
        {
            if(Pesel[9] % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        //Metody GetEducationInfo, GetFullName, CanGoAloneToHome
        public virtual string GetEducationInfo()
        {
            return "Brak informacji o edukacji";
        }

        public string GetFullName()
        {
            return $"{Imie} {Nazwisko}";
        }

        public virtual bool CanGoAloneToHome()
        {
            return true;
        }
    }
}
