namespace Kertaus_tehtävä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ritari_hp = 15;
            int orkki_hp = 15;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tapa örkki");
            Console.ResetColor();

            while (true)
            {
                Tilanne(ritari_hp, orkki_hp);

                RitariHyokkaus(random, ref orkki_hp, ref ritari_hp);
                OrkkiHyokkaus(random, ref ritari_hp);
                if (Lopputulos(ritari_hp, orkki_hp))
                    break;
            }
        }

        static void Tilanne(int ritari_hp, int orkki_hp)
        {
            Console.WriteLine($"Ritari HP: {ritari_hp} / 15 | Örkki HP: {orkki_hp} / 15");
        }

        static void RitariHyokkaus(Random random, ref int orkki_hp, ref int ritari_hp)
        {
            int ritari_damage = random.Next(1, 5);
            int ritari_heal = random.Next(1, 3);

            Console.WriteLine("Anna komento: 1 hyökkää, 2 puolusta");
            string vastaus = Console.ReadLine();

            if (vastaus == "1")
            {
                orkki_hp -= ritari_damage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hyökkäsit örkkiä vastaan ja aiheutit {ritari_damage} vahinkoa!");
            }
            else if (vastaus == "2")
            {
                ritari_hp += ritari_heal;
                if (ritari_hp > 15) ritari_hp = 15;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Puolustit itseäsi ja paransit {ritari_heal} HP!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("En ymmärrä!");
            }

            Console.ResetColor();
        }

        static void OrkkiHyokkaus(Random random, ref int ritari_hp)
        {
            int orkki_damage = random.Next(1, 5);

            ritari_hp -= orkki_damage;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Örkki teki {orkki_damage} vahinkoa");
            Console.ResetColor();
        }

        static bool Lopputulos(int ritari_hp, int orkki_hp)
        {
            if (ritari_hp <= 0 && orkki_hp <= 0)
            {
                Console.WriteLine("TASA PELI.");
                return true;
            }
            else if (ritari_hp <= 0)
            {
                Console.WriteLine("HÄVISIT PELIN.");
                return true;
            }
            else if (orkki_hp <= 0)
            {
                Console.WriteLine("VOITIT PELIN.");
                return true;
            }

            return false;
        }
    }
}
