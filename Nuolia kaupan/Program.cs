namespace Nuolia_kaupan
{
    internal class Program
    {
        enum kärki
        {
            puu, // 3
            teräs, // 5 
            timantti // 50
        }
        enum perä
        {
            lehti, // 0
            kanansulka, // 1
            kotkansulka // 5
        }
        enum pituus
        {
            pituus, // 60-100 cm
        }

        class Nuoli
        {
            public kärki Kärki { get; set; }
            public perä Perä { get; set; }
            public pituus Pituus { get; set; }
            public Nuoli(kärki kärki, perä perä, pituus pituus)
            {
                this.Kärki = kärki;
                this.Perä = perä;
                this.Pituus = pituus;
            }
        }
        static void Main(string[] args)
        {
            int hinta = 0;

            Console.WriteLine("Valitse nuolen kärki: puu, teräs, timantti");
            string kärkiValinta = Console.ReadLine();
            if (kärkiValinta == "puu")
            {
                hinta += 3;
            }
            else if (kärkiValinta == "teräs")
            {
                hinta += 5;
            }
            else if (kärkiValinta == "timantti")
            {
                hinta += 50;
            }

            Console.WriteLine("Valitse nuolen perä: lehti, kanansulka, kotkansulka");
            string peräValinta = Console.ReadLine();
            if (peräValinta == "lehti")
            {
                hinta += 0;
            }
            else if (peräValinta == "kanansulka")
            {
                hinta += 1;
            }
            else if (peräValinta == "kotkansulka")
            {
                hinta += 5;
            }

            Console.WriteLine("Valitse nuolen pituus (60-100 cm): ");
            if (hinta > 0) 
            {
                int pituus = int.Parse(Console.ReadLine());
                if (pituus >= 60 && pituus <= 100)
                {
                    hinta += (int)(pituus * 0.05);
                }
                else
                {
                    Console.WriteLine("Virheellinen pituus, nuolen hinta ei muutu.");
                }
            }
            Console.WriteLine($"Nuolen hinta on:{hinta} kolikkoa");
        }
    }
}
