using System;
namespace Lab2
{
    internal class Data
    {
        //Składowa przechowująca bieżącą datę
        private DateTime biezacaData;

        //Konstruktor inicjalizujący składową bieżącą datą
        public Data()
        {
            biezacaData = DateTime.Now;
        }

        //Bierząca data
        public DateTime BiezacaData()
        {
            return biezacaData;
        }

        //Data o jeden tydzień w przód
        public void DataWprzod()
        {
            biezacaData = biezacaData.AddDays(7);
        }

        //Data o jeden tydzień w tył
        public void DataWstecz()
        {
            biezacaData = biezacaData.AddDays(-7);
        }

    }
}
