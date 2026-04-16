namespace Ovi
{
    internal class Program
    {
        enum oventila
        {
            Auki,
            Kiinni,
            Lukittu
        }
        public class Ovi
        {
            oventila tila = oventila.Auki;
            public void Avaa()
            {
                if (tila == oventila.Kiinni)
                    tila = oventila.Auki;
            }
            public void Sulje()
            {
                if (tila == oventila.Auki)
                    tila = oventila.Kiinni;
            }
            public void Lukitse()
            {
                if (tila == oventila.Kiinni)
                    tila = oventila.Lukittu;
            }
            public void AvaaLukko()
            {
                if (tila == oventila.Lukittu)
                    tila = oventila.Kiinni;
            }
            public override string ToString()
            {
                return tila.ToString();
            }
        }
        static void Main(string[] args)
        {
            Ovi ovi = new Ovi();

            while (true)
            {
                Console.WriteLine($"Ovi on nyt {ovi}");
                Console.WriteLine("Mitä haluat tehdä?");
                string valinta = Console.ReadLine();
                if (valinta == "avaa")
                    ovi.Avaa();
                else if (valinta == "sulje")
                    ovi.Sulje();
                else if (valinta == "lukitse")
                    ovi.Lukitse();
                else if (valinta == "avaa lukko")
                    ovi.AvaaLukko();
                else
                    Console.WriteLine("Tuntematon komento");
            }
        }
    }
}
