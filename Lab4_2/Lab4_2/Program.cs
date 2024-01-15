namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uczen uczen1 = new Uczen();
            uczen1.SetFirstName("Jan");
            uczen1.SetLastName("Kowalski");
            uczen1.SetPesel("04230515246");
            uczen1.SetSchool("Szkoła Podstawowa Nr 1");

            Uczen uczen2 = new Uczen();
            uczen2.SetFirstName("Anna");
            uczen2.SetLastName("Nowak");
            uczen2.SetPesel("01282228984");
            uczen2.SetSchool("Szkoła Podstawowa Nr 2");

            Nauczyciel nauczyciel = new Nauczyciel();
            nauczyciel.SetFirstName("Piotr");
            nauczyciel.SetLastName("Nowakowski");
            nauczyciel.SetPesel("72102876421");
            nauczyciel.TytulNaukowy = "mgr";
            nauczyciel.PodwladniUczniowie.Add(uczen1);
            nauczyciel.PodwladniUczniowie.Add(uczen2);

            // Sprawdzenie, którzy uczniowie mogą iść sami do domu
            DateTime dateToCheck = DateTime.Now;
            nauczyciel.WhichStudentCanGoHomeAlone(dateToCheck);
        }
    }
}