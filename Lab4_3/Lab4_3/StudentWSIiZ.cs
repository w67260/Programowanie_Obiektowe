using System;

namespace Lab4_3
{
    internal class StudentWSIiZ : Student
    {
        public override void WypiszPelnaNazweIUczelnie()
        {
            Console.WriteLine($"{base.ZwrocPelnaNazwe()} - WSIiZ");
        }
    }
}
