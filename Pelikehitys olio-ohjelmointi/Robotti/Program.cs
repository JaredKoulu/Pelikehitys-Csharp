namespace Robotti
{
    public interface IRobottiKäsky
    {
        public void Suorita(Robotti robotti);
    }

    public class Robotti
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool OnKäynnissä { get; set; }
        public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];
        public void Suorita()
        {
            foreach (IRobottiKäsky? käsky in Käskyt)
            {
                käsky?.Suorita(this);
                Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robotti robotti = new Robotti();
            Console.WriteLine("Kerro robotille 3 komentoa. Vaihtoehdot: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen.");
            for (int i = 0; i < robotti.Käskyt.Length; i++)
            {
                string komento = Console.ReadLine() ?? "";
                switch (komento)
                {
                    case "Käynnistä":
                        robotti.Käskyt[i] = new Käynnistä();
                        break;
                    case "Sammuta":
                        robotti.Käskyt[i] = new Sammuta();
                        break;
                    case "Ylös":
                        robotti.Käskyt[i] = new YlösKäsky();
                        break;
                    case "Alas":
                        robotti.Käskyt[i] = new AlasKäsky();
                        break;
                    case "Oikea":
                        robotti.Käskyt[i] = new OikeaKäsky();
                        break;
                    case "Vasen":
                        robotti.Käskyt[i] = new VasenKäsky();
                        break;
                }
            }
            robotti.Suorita();
        }
    }
}
