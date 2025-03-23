using System;

namespace ZgodnezDIP
{
    //Abstrakcja – interfejs
    public interface IPies
    {
        void Szczepienie();
    }

    public class Pies : IPies
    {
        public void Szczepienie()
        {
            Console.WriteLine("Zaszczepiono psa.");
        }
    }

    public class PiesZRodowodem : IPies
    {
        public void Szczepienie()
        {
            Console.WriteLine("Zaszczepiono psa z rodowodem (dodatkowy wpis do systemu).");
        }
    }

    //Weterynarz zależy od interfejsu, nie od konkretnej klasy
    public class Weterynarz
    {
        private readonly IPies _pies;

        public Weterynarz(IPies pies)
        {
            _pies = pies;
        }

        public void ZaszczepPsa()
        {
            _pies.Szczepienie();
        }
    }

    class Program
    {
        static void Main()
        {
            IPies Pies_1 = new Pies();
            IPies Pies_2 = new PiesZRodowodem();

            var weterynarz1 = new Weterynarz(Pies_1);          
            var weterynarz2 = new Weterynarz(Pies_2);
            weterynarz1.ZaszczepPsa();
            weterynarz2.ZaszczepPsa();

            Console.ReadKey();
        }
    }
}
