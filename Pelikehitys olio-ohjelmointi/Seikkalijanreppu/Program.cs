namespace Seikkalijanreppu
{
    internal class Program
    {
        public class Tavara
        {

        }
        public class Nuoli : Tavara
        {
        }
        public class Jousi : Tavara
        {
        }
        public class Köysi : Tavara
        {
        }
        public class Vesi : Tavara
        {
        }
        public class Ruoka : Tavara
        {
        }
        public class Miekka : Tavara
        {
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
