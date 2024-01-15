using System;

namespace Lab6
{
    internal class Class1
    {
        public void Pliki()
        {
            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine(content);
            }

            string newContent = Console.ReadLine();

            File.WriteAllText("test.txt", newContent);
            File.AppendAllText("test.txt", newContent);


            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                string newContent = Console.ReadLine();
                while (newContent != "exit")
                {
                    sw.Write(newContent + Environment.NewLine);
                    newContent = Console.ReadLine();
                }
            }


            //Otwieramy stream pliku sample.txt
            using (var sr = new StreamReader("sample.txt"))
            {
                var line = sr.ReadToEnd();
                Console.WriteLine(line);
            }


            //Otwieramy stream pliku sample.txt
            using (var sw = new StreamWriter("sample.txt"))
            {
                sw.WriteLine("Hello World!!");
                sw.WriteLine("From the StreamWriter class");
            }


            //Otwieramy stream pliku sample.txt (dopisuje wartości nie nadpisuje)
            using (var sw = new StreamWriter("sample.txt", append: true))
            {
                sw.WriteLine("Hello World!!");
                sw.WriteLine("From the StreamWriter class");
            }


            StreamWriter sw;
            string path = @"plik.txt";
            sw = File.CreateText(path);
        }
    }
}
