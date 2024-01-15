using System;

namespace Lab4_3
{
    internal interface IOsoba
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string ZwrocPelnaNazwe();
    }
}
