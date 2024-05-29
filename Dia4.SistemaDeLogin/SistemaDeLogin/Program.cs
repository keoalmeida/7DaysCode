class SistemaDeLogin
{
    static void Main(string[] args)
    {
        var credentials = new string[2];

        Console.Clear();

        Console.WriteLine("____TELA DE REGISTRO____");
        Console.WriteLine("------------------------");

        Console.WriteLine("| Escolha seu nome:    |");
        string name = Console.ReadLine();

        Console.WriteLine("| Escolha sua senha:   |");
        Console.WriteLine("| Apenas números...    |");
        string password = Console.ReadLine();

        credentials[0] = name;
        credentials[1] = password;

        Console.WriteLine("Legal! Nome e senha salvos.");
        Console.WriteLine("Agora, faça seu login.");        
        Thread.Sleep(2000);
        
        Console.Clear();

        Console.WriteLine("_____TELA DE LOGIN_____");
        Console.WriteLine("-----------------------");
        Console.WriteLine("| Digite seu nome:    |");
        string nameDigitado = Console.ReadLine();
        Console.WriteLine("| Digite sua senha:   |");
        string passwordDigitado = Console.ReadLine();

        if (nameDigitado == name && passwordDigitado == password)
        {
            Console.WriteLine($"  Boas-vindas, {name}! ");
        }
        else{
            Console.WriteLine($"Opa, {nameDigitado}, tá de migué?");
        }

    }
}