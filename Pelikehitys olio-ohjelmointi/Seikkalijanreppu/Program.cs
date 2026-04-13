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
            List<Tavara> tavarat;

            public int maxMaara;
            public double maxPaino;
            public double maxTilavuus;

            public Reppu(int maxMaara, double maxPaino, double maxTilavuus)
            {
                this.maxMaara = maxMaara;
                this.maxPaino = maxPaino;
                this.maxTilavuus = maxTilavuus;

                tavarat = new List<Tavara>();

            }
            public int TavaraMaara
            {
                get { return tavarat.Count; }
            }
            public double NykyPaino
            {
                get
                {
                    double summa = 0;
                    foreach (Tavara t in tavarat)
                    {
                        summa += t.Paino;
                    }
                    return summa;
                }
            }
            public double NykyTilavuus
            {
                get
                {
                    double summa = 0;
                    foreach (Tavara t in tavarat)
                    {
                        summa += t.Tilavuus;
                    }
                    return summa;
                }
            }
            public bool Lisää(Tavara tavara)
            {
                if (TavaraMaara + 1 > maxMaara)
                    return false;
                if (NykyPaino + tavara.Paino > maxPaino)
                    return false;
                if (NykyTilavuus + tavara.Tilavuus > maxTilavuus)
                    return false;

                tavarat.Add(tavara);
                return true;
            }
        }
        static void Main(string[] args)
        {
            Reppu reppu = new Reppu(10, 30, 20);
            while (true)
            {
                Console.WriteLine($"Repussasi on tällähetkellä: {reppu.TavaraMaara}/{reppu.maxMaara} tavaraa, {reppu.NykyPaino}/{reppu.maxPaino} painoa ja {reppu.NykyTilavuus}/{reppu.maxTilavuus} tilavuus.");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1. Nuoli (painaa 0.1 ja tilavuus 0.05)");
                Console.WriteLine("2. Jousi (painaa 1 ja tilavuus 4)");
                Console.WriteLine("3. Köysi (painaa 1 ja tilavuus 1.5)");
                Console.WriteLine("4. Vesi (painaa 2 ja tilavuus 2)");
                Console.WriteLine("5. Ruoka (painaa 1 ja tilavuus 0.5)");
                Console.WriteLine("6. Miekka (painaa 5 ja tilavuus 3)");
                string lisäysValinta = Console.ReadLine();
                if (lisäysValinta == "1")
                {
                    Nuoli nuoli = new Nuoli();
                    if (reppu.Lisää(nuoli))
                    {
                        Console.WriteLine("Nuoli lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Nuolia ei voitu lisätä reppuun.");
                    }
                }
                if (lisäysValinta == "2")
                {
                    Jousi jousi = new Jousi();
                    if (reppu.Lisää(jousi))
                    {
                        Console.WriteLine("Jousi lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Jousia ei voitu lisätä reppuun.");
                    }
                }
                if (lisäysValinta == "3")
                {
                    Köysi köysi = new Köysi();
                    if (reppu.Lisää(köysi))
                    {
                        Console.WriteLine("Köysi lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Köysiä ei voitu lisätä reppuun.");
                    }
                }
                if (lisäysValinta == "4")
                {
                    Vesi vesi = new Vesi();
                    if (reppu.Lisää(vesi))
                    {
                        Console.WriteLine("Vesi lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Vettä ei voitu lisätä reppuun.");
                    }
                }
                if (lisäysValinta == "5")
                {
                    Ruoka ruoka = new Ruoka();
                    if (reppu.Lisää(ruoka))
                    {
                        Console.WriteLine("Ruoka lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Ruokaa ei voitu lisätä reppuun.");
                    }
                }
                if (lisäysValinta == "6")
                {
                    Miekka miekka = new Miekka();
                    if (reppu.Lisää(miekka))
                    {
                        Console.WriteLine("Miekka lisätty reppuun.");
                    }
                    else
                    {
                        Console.WriteLine("Miekkaa ei voitu lisätä reppuun.");
                    }
                }
            }
        }
    }
}
