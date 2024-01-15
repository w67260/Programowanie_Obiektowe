using System;

namespace Lab4_3
{
    internal class StudentWSIiZ : Student
    {
        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{base.ZwrocPelnaNazwe()} - WSIiZ";
        }
    }
}
