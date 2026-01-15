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
                int ritari_damage = random.Next(1, 5);
                int ritari_heal = random.Next(1, 3);
                int orkki_damage = random.Next(1, 5);
                Console.WriteLine($"Ritari HP: {ritari_hp} / 15 | Örkki HP: {orkki_hp} / 15");
                Console.WriteLine("Anna komento: 1 hyökkää, 2 puolusta");
                string vastaus = Console.ReadLine();
                if (vastaus == "1")
                {
                    orkki_hp -= ritari_damage;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hyökkäsit örkkiä vastaan ja aiheutit {ritari_damage} vahinkoa!");
                    Console.ResetColor();
                }
                else if (vastaus == "2")
                {
                    ritari_hp += ritari_heal;
                    if (ritari_hp > 15) ritari_hp = 15;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Puolustit itseäsi ja paransit {ritari_heal} HP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("En ymmärrä!");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                ritari_hp -= orkki_damage;
                Console.WriteLine($"Örkki teki {orkki_damage} vahinkoa");
                Console.ResetColor();
                if (ritari_hp <= 0 && orkki_hp <= 0)
                {
                    Console.WriteLine($"Ritari HP: {ritari_hp} / 15 | Örkki HP: {orkki_hp} / 15");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TASA PELI.");
                    break;
                }
                if (ritari_hp <= 0)
                {
                    Console.WriteLine($"Ritari HP: {ritari_hp} / 15 | Örkki HP: {orkki_hp} / 15");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HÄVISIT PELIN.");
                    break;
                }
                if (orkki_hp <= 0)
                {
                    Console.WriteLine($"Ritari HP: {ritari_hp} / 15 | Örkki HP: {orkki_hp} / 15");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOITIT PELIN.");
                    break;
                }
            }
        }
    }
}
