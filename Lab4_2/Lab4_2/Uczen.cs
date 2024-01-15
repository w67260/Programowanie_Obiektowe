using System;

namespace Lab4_2
{
    internal class Uczen : Osoba
    {
        //Pola klasy Uczen
        public string Szkola;
        public bool MozeSamWracacDoDomu;

        //Metody SetSchool, ChangeSchool, SetCanGoHomeAlone
        public void SetSchool(string szkola)
        {
            Szkola = szkola;
        }
        public void ChangeSchool(string nowaSzkola)
        {
            Szkola = nowaSzkola;
        }
        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            MozeSamWracacDoDomu = canGoHomeAlone;
        }

        //Metody GetEducationInfo, CanGoAloneToHome
        public override string GetEducationInfo()
        {
            return $"Uczeń uczęszcza do szkoły: {Szkola}";
        }
        public override bool CanGoAloneToHome()
        {
            if (GetAge() < 12 && !MozeSamWracacDoDomu)
            {
                Console.WriteLine($"{GetFullName()} nie może sam wracać do domu poniżej 12 lat, chyba że ma pozwolenie.");
                return false;
            }

            return true;
        }
    }
}
