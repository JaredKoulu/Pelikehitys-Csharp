namespace Koordinaatisto
{
    public struct Koordinaatti  
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        Koordinaatti(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool OnVieressa(Koordinaatti toinen)
        {
            if (X == toinen.X && Y == toinen.Y)
            {
                return false;
            }
            return Math.Abs(X - toinen.X) <= 1 && Math.Abs(Y - toinen.Y) <= 1;
        }
        static void Main(string[] args)
        {
            Koordinaatti keskiPiste = new Koordinaatti(0, 0);
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    Koordinaatti tutkittava = new Koordinaatti(x, y);

                    if (tutkittava.X == keskiPiste.X && tutkittava.Y == keskiPiste.Y)
                    {
                        Console.WriteLine($"Annettu koordinaatti {tutkittava.X},{tutkittava.Y} on koordinaatissa {keskiPiste.X},{keskiPiste.Y}.");
                    }
                    else if (tutkittava.OnVieressa(keskiPiste))
                    {
                        Console.WriteLine($"Annettu koordinaatti {tutkittava.X},{tutkittava.Y} on koordinaatin {keskiPiste.X},{keskiPiste.Y} vieressä.");
                    }
                }
            }
        }
    }
}
