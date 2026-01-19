namespace Tehtävä_1___Ovi
{
    internal class Program
    {
        enum oventila
        {
            Auki,
            Kiinni,
            Lukittu
        }
        static void Main(string[] args)
        {
            
            oventila tila = oventila.Auki;
            while (true)
            {
                Console.WriteLine($"Ovi on nyt {tila}");
                Console.WriteLine("Mitä haluat tehdä?");
                string valinta = Console.ReadLine();
                if (valinta == "avaa" && tila == oventila.Kiinni)
                {   
                    tila = oventila.Auki;
                }
                else if (valinta == "sulje" && tila == oventila.Auki)
                {
                    tila = oventila.Kiinni;
                }
                else if (valinta == "lukitse" && tila == oventila.Kiinni)
                {
                    tila = oventila.Lukittu;
                }
                else if (valinta == "avaa lukko" && tila == oventila.Lukittu)
                { 
                    tila = oventila.Kiinni;
                }
            }
        }
    }
}
