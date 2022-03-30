using System;
using static Praktika.currency;

namespace Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange(Currency.Usd,2));
        }

        static double Exchange(Enum e, double azn)
        {
            if (e is Currency)
            {
                switch (e)
                {
                    case Currency.Eur:
                        return azn * 0.57;
                        break;
                    case Currency.TRY:
                        return azn * 999999;
                        break;
                    case Currency.Usd:
                        return azn * 1.7;
                        break;
                    default:
                        return -1;
                        break;
                }
            }
            return -1;
        }
    }
}
