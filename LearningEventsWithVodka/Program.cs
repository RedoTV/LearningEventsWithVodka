using System;

namespace LearningEventsWithVodka
{
    delegate void Vodka();
    class Vodkas
    {
        public static void FewVodka()
        {
            Console.WriteLine("ЭЭЭЭЭ , ЧЁ ТОЛЬКО ОДНУ КУПИЛ, ИДИ КУПИ ЕЩЁ");
        }
        public event Vodka CheckVodka;
        public int amountOfVodka = 0;
        public Vodkas(int amountOfVodka)
        {
            this.amountOfVodka = amountOfVodka;
            if (amountOfVodka == 1)
                CheckVodka += FewVodka;
        }

        public void VodkaHendler()
        {
            for (int i = 0; i < amountOfVodka;)
            {
                Console.WriteLine($"бутылок водки: {amountOfVodka}");
                amountOfVodka--;
            }
            if (amountOfVodka == 0)
            {
                if (CheckVodka != null)
                    CheckVodka();
            }
            Console.WriteLine("");
        }

    }
    class Program
    {
        public static void Message()
        {

            Console.WriteLine("ВОДКИ НЕТ, ИДЁМ ЗАКУПАТЬСЯ");
        }
        public static void SecondAlkash()
        {
            Console.WriteLine("ЁЩЁ БУХЛА");
        }
        static void Main()
        {
            Vodkas voda = new(2);
            voda.CheckVodka += Message;
            voda.VodkaHendler();

            Vodkas Alkash1 = new(1);
            Alkash1.CheckVodka += SecondAlkash;
            Alkash1.VodkaHendler();

            Vodkas Alkash2 = new(2);
            Alkash2.CheckVodka += Message;
            Alkash2.VodkaHendler();

            Vodkas Alkash3 = new(1);
            Alkash3.CheckVodka += Message;
            Alkash3.VodkaHendler();
        }
    }
}