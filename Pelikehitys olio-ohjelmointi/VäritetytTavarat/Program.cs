namespace VäritetytTavarat
{
    public class VäritettyTavara<T>
    {
        public T Esine { get; }
        public ConsoleColor Väri { get; }

        public VäritettyTavara(T esine, ConsoleColor väri)
        {
            Esine = esine;
            Väri = väri;
        }

        public void NäytäTavara()
        {
            ConsoleColor alkuperäinenVäri = Console.ForegroundColor;
            Console.ForegroundColor = Väri;
            Console.WriteLine(Esine.ToString());
            Console.ForegroundColor = alkuperäinenVäri;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vesi Vesi = new Vesi();
            Miekka Miekka = new Miekka();
            Ruoka Ruoka = new Ruoka();
            Köysi Köysi = new Köysi();

            VäritettyTavara<Vesi> sininenVesi = new VäritettyTavara<Vesi>(Vesi, ConsoleColor.Blue);
            VäritettyTavara<Miekka> punainenMiekka = new VäritettyTavara<Miekka>(Miekka, ConsoleColor.Red);
            VäritettyTavara<Ruoka> vihreäRuoka = new VäritettyTavara<Ruoka>(Ruoka, ConsoleColor.Green);
            VäritettyTavara<Köysi> keltainenKöysi = new VäritettyTavara<Köysi>(Köysi, ConsoleColor.Yellow);
            sininenVesi.NäytäTavara();
            punainenMiekka.NäytäTavara();
            vihreäRuoka.NäytäTavara();
            keltainenKöysi.NäytäTavara();
        }
    }
}
