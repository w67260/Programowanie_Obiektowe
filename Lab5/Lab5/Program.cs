using Lab2;
using System.Reflection.Metadata;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie wpisując jego numer:");
            Console.WriteLine("1. Zadanie 1");
            Console.WriteLine("2. Zadanie 2");
            Console.WriteLine("3. Zadanie 3");
            Console.WriteLine("4. Zadanie 4 i 5");
            int choice = new IntInputClass().IntInput();

            switch (choice)
            {
                case 1:
                    //ZADANIE 1
                    try
                    {
                        string input = null;
                        Length.PrintLength(input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Obsłużony wyjątek: " + ex.Message);
                        Console.WriteLine("Ślad stosu wywołań: " + ex.StackTrace);
                    }
                    break;

                case 2:
                    //ZADANIE 2
                    try
                    {
                        RandomExceptionGenerator.ThrowRandomException();
                    }
                    catch (CustomException1 ex1)
                    {
                        Console.WriteLine("Złapany CustomException1: " + ex1.Message);
                    }
                    catch (CustomException2 ex2)
                    {
                        Console.WriteLine("Złapany CustomException2: " + ex2.Message);
                    }
                    catch (CustomException3 ex3)
                    {
                        Console.WriteLine("Złapany CustomException3: " + ex3.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Złapany ogólny wyjątek: " + ex.Message);
                    }
                    break;

                case 3:
                    //ZADANIE 3
                    SomeClass someClassObj = new SomeClass();
                    try
                    {
                        someClassObj.CanThrowException();
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine("Wyjątek w pierwszej instrukcji: " + e1.Message);
                    }

                    try
                    {
                        someClassObj.CanThrowException();
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Wyjątek w drugiej instrukcji: " + e2.Message);
                    }

                    try
                    {
                        someClassObj.CanThrowException();
                    }
                    catch (Exception e3)
                    {
                        Console.WriteLine("Wyjątek w trzeciej instrukcji: " + e3.Message);
                    }

                    try
                    {
                        someClassObj.CanThrowException();
                    }
                    catch (Exception e4)
                    {
                        Console.WriteLine("Wyjątek w czwartej instrukcji: " + e4.Message);
                    }

                    try
                    {
                        someClassObj.CanThrowException();
                    }
                    catch (Exception e5)
                    {
                        Console.WriteLine("Wyjątek w piątej instrukcji: " + e5.Message);
                    }
                    break;

                case 4:
                    try
                    {
                        //Utwórzenie obiektu do skopiowania
                        SampleClass originalObject = new SampleClass(42, "Konrad");

                        //Kopiowanie obiektu
                        SampleClass copiedObject = new CopyClass().Copy(originalObject);

                        //Wyświetlenie oryginalnego i skopiowanego obiektu
                        Console.WriteLine("Oryginalny obiekt: " + originalObject.IntValue + ", " + originalObject.StringValue);
                        Console.WriteLine("Skopiowany obiekt: " + copiedObject.IntValue + ", " + copiedObject.StringValue);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Wystąpił błąd: " + ex.Message);
                    }

                    try
                    {
                        //Próba skopiowania null
                        SampleClass nullObject = null;
                        SampleClass copiedNullObject = new CopyClass().Copy(nullObject);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Wystąpił błąd: " + ex.Message);
                    }
                    break;
            }
        }
    }
}