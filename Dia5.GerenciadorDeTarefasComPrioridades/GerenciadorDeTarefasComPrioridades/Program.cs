class Program{
    static void Main (string[] args)
    {
        var listaDeTarefas = new string[3];
        
        Console.Clear();

        Console.WriteLine("  GERENCIADOR DE TAREFAS  ");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Dê um título para tarefa:");
        string titulo = Console.ReadLine();
        Console.WriteLine("Descreva a tarefa:");
        string tarefa = Console.ReadLine();
        Console.WriteLine("Qual a prioridade?");
        Console.WriteLine("1- Se não fizer, vai dar ruim");
        Console.WriteLine("2- Dá pra fazer depois");
        Console.WriteLine("3- Pode procrastinar");
        string prioridade = Console.ReadLine();

        listaDeTarefas[0] = titulo;
        listaDeTarefas[1] = tarefa;
        listaDeTarefas[2] = prioridade;

        for (int i = 0; i < listaDeTarefas.Length; i++)
        {
            Console.WriteLine(listaDeTarefas[i]);
        }
    }
}