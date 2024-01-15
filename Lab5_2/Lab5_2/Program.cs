namespace Lab5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            Console.WriteLine("Lista liczb parzystych:");
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                {
                    Console.WriteLine(myList[i]);
                }
            }
        }
    }
}