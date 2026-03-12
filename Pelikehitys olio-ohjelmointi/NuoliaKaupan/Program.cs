namespace NuoliaKaupan
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
        class Nuoli
        {
            private kärki _kärki;
            private perä _perä;

            public Nuoli(kärki kärki, perä perä)
            {
                this._kärki = kärki;
                this._perä = perä;
            }

            public kärki GetKärki()
            {
                return _kärki;
            }

            public perä GetPerä()
            {
                return _perä;
            }

            public int LaskeHinta()
            {
                int hinta = 0;
                switch (_kärki)
                {
                    case kärki.puu:
                        hinta += 3;
                        break;
                    case kärki.teräs:
                        hinta += 5;
                        break;
                    case kärki.timantti:
                        hinta += 50;
                        break;
                }
                switch (_perä)
                {
                    case perä.lehti:
                        hinta += 0;
                        break;
                    case perä.kanansulka:
                        hinta += 1;
                        break;
                    case perä.kotkansulka:
                        hinta += 5;
                        break;
                }
                Console.WriteLine("Valitse nuolen pituus (60-100 cm): ");
                if (hinta > 0)
                {
                    int pituusArvo = int.Parse(Console.ReadLine());
                    if (pituusArvo >= 60 && pituusArvo <= 100)
                    {
                        hinta += (int)(pituusArvo * 0.05);
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen pituus, nuolen hinta ei muutu.");
                    }
                }
                return hinta;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse nuolen kärki: puu, teräs, timantti");
            string kärkiValinta = Console.ReadLine();
            kärki valittuKärki = KärkiString(kärkiValinta);

            Console.WriteLine("Valitse nuolen perä: lehti, kanansulka, kotkansulka");
            string peräValinta = Console.ReadLine();
            perä valittuPerä = PeräString(peräValinta);

            Nuoli nuoli = new Nuoli(valittuKärki, valittuPerä);
            int hinta = nuoli.LaskeHinta();

            LopullinenHinta(hinta);
        }

        static kärki KärkiString(string kärkiValinta)
        {
            return kärkiValinta switch
            {
                "puu" => kärki.puu,
                "teräs" => kärki.teräs,
                "timantti" => kärki.timantti,
                _ => kärki.puu
            };
        }

        static perä PeräString(string peräValinta)
        {
            return peräValinta switch
            {
                "lehti" => perä.lehti,
                "kanansulka" => perä.kanansulka,
                "kotkansulka" => perä.kotkansulka,
                _ => perä.lehti
            };
        }

        static void LopullinenHinta(int hinta)
        {
            Console.WriteLine($"Nuolen hinta on: {hinta} kolikkoa");
        }
    }
}
