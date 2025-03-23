using System;

namespace NaruszenieDIP
{
    public class Weterynarz
    {
        public void ZaszczepPsa()
        {
            //Moduł wysokiego poziomu zależy od konkretnej klasy Pies
            Pies pies = new Pies();
            pies.Szczepienie();
        }
    }

    public class Pies
    {
        public void Szczepienie()
        {
            Console.WriteLine("Zaszczepiono psa.");
        }
    }

    public class PiesZRodowodem
    {
        public void Szczepienie()
        {
            Console.WriteLine("Zaszczepiono psa z rodowodem (dodatkowy wpis do systemu).");
        }
    }

    class Program
    {
        static void Main()
        {
            var weterynarz = new Weterynarz();
            weterynarz.ZaszczepPsa();

            Console.ReadKey();
        }
    }
}
