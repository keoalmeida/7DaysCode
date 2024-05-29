class JogoDeAdivinhacao
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("--------------------");
        Console.WriteLine("--------------------");

        Console.WriteLine("Tente adivinhar qual número eu pensei, entre 1 a 100...");

        Random rand = new Random();
        int numeroQueEuPensei = Convert.ToInt32(rand.Next(1, 101));


        while (true)
        {
            int palpite = Convert.ToInt16(Console.ReadLine());

            if (palpite < numeroQueEuPensei)
            {
                Console.WriteLine($"Pensei em um número maior que esse seu palpite...");
            }
            else if (palpite > numeroQueEuPensei)
            {
                Console.WriteLine($"Pensei em um número menor que esse seu palpite...");
            }
            else
            {
                Console.WriteLine($"Parabéns! Acertou: {numeroQueEuPensei}.");
                break;
            }
        }

    }
}
