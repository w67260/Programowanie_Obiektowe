using System;

namespace Lab1
{
    internal class Zadanie2
    {
        public void Calculator()
        {
            Console.Clear();

            Console.WriteLine("Wybierz operację wpisując jej numer:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Sinus");
            Console.WriteLine("8. Cosinus");
            Console.WriteLine("9. Tangens");
            DoubleInputClass input = new DoubleInputClass();
            double choice = input.DoubleInput();

            switch (choice)
            {
                case 1:
                    //SUMA
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a= input.DoubleInput();
                    Console.Write("Podaj drugą liczbę: ");
                    double b= input.DoubleInput();
                    double suma = a + b;
                    Console.WriteLine($"Suma {a}+{b}={suma}");
                    break;
                case 2:
                    //ROZNICA
                    Console.Write("Podaj pierwszą liczbę: ");
                    double c= input.DoubleInput();
                    Console.Write("Podaj drugą liczbę: ");
                    double d= input.DoubleInput();
                    double roznica = c - d;
                    Console.WriteLine($"Roznica {c}-{d}={roznica}");
                    break;
                case 3:
                    //ILOCZYN
                    Console.Write("Podaj pierwszy czynnik: ");
                    double e = input.DoubleInput();
                    Console.Write("Podaj drugi czynnik: ");
                    double f = input.DoubleInput();
                    double iloczyn = e * f;
                    Console.WriteLine($"Iloczyn {e}*{f}={iloczyn}");
                    break;
                case 4:
                    //ILORAZ
                    Console.Write("Podaj dzielna: ");
                    double g = input.DoubleInput();
                    Console.Write("Podaj dzielnik: ");
                    double h = input.DoubleInput();
                    double iloraz = g / h;
                    Console.WriteLine($"Iloraz {g}/{h}={iloraz}");
                    break;
                case 5:
                    //POTEGA
                    Console.Write("Podaj liczbę: ");
                    double i= input.DoubleInput();
                    Console.Write("Podaj potęgę: ");
                    double j = input.DoubleInput();
                    double potega=Math.Pow(i,j);
                    Console.WriteLine($"{i} do potęgi {j}={potega}");
                    break;
                case 6:
                    //PIERWIASTEK
                    Console.Write("Podaj liczbę: ");
                    double k = input.DoubleInput();
                    double sqrt=Math.Sqrt(k);
                    Console.WriteLine($"Pierwiastek kwadratowy z liczby {k} to: {sqrt}");
                    break;
                case 7:
                    //SINUS
                    Console.Write("Podaj liczbę: ");
                    double l = input.DoubleInput();
                    double sin=Math.Sin(l);
                    Console.WriteLine($"Sinun z liczby {l} to {sin}");
                    break;
                case 8:
                    //COSINUS
                    Console.Write("Podaj liczbę: ");
                    double m = input.DoubleInput();
                    double cos = Math.Cos(m);
                    Console.WriteLine($"Cosinus z liczby {m} to {cos}");
                    break;
                ; case 9:
                    //TANGENS
                    Console.Write("Podaj liczbę: ");
                    double n = input.DoubleInput();
                    double tan=Math.Tan(n);
                    Console.WriteLine($"Cosinus z liczby {n} to {tan}");
                    break;
                default:
                    Console.WriteLine("Błędny wybór.");
                    break;
            }
        }
    }
}
