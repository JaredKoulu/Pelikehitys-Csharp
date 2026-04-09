namespace Seikkalijanreppu
{
    internal class Program
    {
        public class Tavara
        {
            public double Paino { get; set; }
            public double Tilavuus { get; set; }

            public Tavara(double paino, double tilavuus)
            {
                Paino = paino;
                Tilavuus = tilavuus;
            }
        }
        public class Nuoli : Tavara
        {
            public Nuoli() : base(0.1, 0.05)
            {

            }
        }
        public class Jousi : Tavara
        {
            public Jousi() : base(1, 4)
            {
            }
        }
        public class Köysi : Tavara
        {
            public Köysi() : base(1, 1.5)
            {
            }
        }
        public class Vesi : Tavara
        {
            public Vesi() : base(2, 2)
            {
            }

        }
        public class Ruoka : Tavara
        {
            public Ruoka() : base(1, 0.5)
            {
            }
        }
        public class Miekka : Tavara
        {
            public Miekka() : base(5, 3)
            {
            }
        }
        public class Reppu
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Repussasi on tällähetkellä: 0/10 tavaraa, 0/30 painoa ja 0/20 tilavuus.");
            Console.WriteLine("Mitä haluat lisätä?");
            Console.WriteLine("1. Nuoli");
            Console.WriteLine("2. Jousi");
            Console.WriteLine("3. Köysi");
            Console.WriteLine("4. Vesi");
            Console.WriteLine("5. Ruoka");
            Console.WriteLine("6. Miekka");
            Console.ReadLine();
        }

    }
}
