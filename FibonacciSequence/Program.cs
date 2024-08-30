class Program
{
    static void Main(string[] args)
    {
        List<int> sequenciaFibonacci = new List<int> { 0, 1 };

        Console.Write("Seja bem-vindo!\nEsse codigo valida se o numero inserido esta ou nao na sequencia de Fibonacci");
        menu(sequenciaFibonacci);

    }

    static void menu(List<int> sequenciaFibonacci)
    {
        Console.WriteLine();
        Console.Write("Insira o valor para executar a funcao desejada:\n1 = Executar codigo\n2 = Encerrar programa.\n");
        String entradaMenu = Console.ReadLine();
        try
        {
            int selecaoMenu = int.Parse(entradaMenu);

            if (selecaoMenu == 1)
            {
                validarSequenciaFibonacci(sequenciaFibonacci);
            }
            else if (selecaoMenu == 2)
            {
                Console.Write("Encerrando programa...");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.Write("-----------------------------------------------------------------------------------------\n");
                Console.Write("Insira o numero inteiro 1 ou 2!");
                Console.Write("\n-----------------------------------------------------------------------------------------");
                menu(sequenciaFibonacci);
            }

        }
        catch (Exception e)
        {
            Console.Clear();
            Console.Write("-----------------------------------------------------------------------------------------\n");
            Console.Write("Insira o numero inteiro 1 ou 2, nao aceitamos tipo texto, booleanos ou numeros decimais!");
            Console.Write("\n-----------------------------------------------------------------------------------------");
            menu(sequenciaFibonacci);
        }

    }

    static void validarSequenciaFibonacci(List<int> sequenciaFibonacci)
    {

        Console.Write("\nInsira o numero inteiro que deseja saber se esta na sequencia de Fibonacci: ");
        String entradaNumero = Console.ReadLine();

        try
        {
            int numeroInserido = int.Parse(entradaNumero);

            if(numeroInserido < 0)
            {
                Console.Clear();
                Console.Write("-----------------------------------------------------------------------------------------\n");
                Console.Write("Insira um numero INTEIRO maior que ZERO!");
                Console.Write("\n-----------------------------------------------------------------------------------------");
                validarSequenciaFibonacci(sequenciaFibonacci);
            }

            // enquanto nao for identificado o numero na lista executara o bloco de comando
            while (numeroInserido != sequenciaFibonacci[sequenciaFibonacci.Count - 1] && numeroInserido != 0)
            {
                // se o numero estiver entre os 2 numeros que serao somados em seguida, significa que ele nao esta na sequencia e o codigo se encerra
                if ((numeroInserido < (sequenciaFibonacci[sequenciaFibonacci.Count - 1])) && (numeroInserido > (sequenciaFibonacci[sequenciaFibonacci.Count - 2])))
                {
                    Console.Clear();
                    Console.Write("-----------------------------------------------------------------------------------------\n");
                    Console.WriteLine("Seu numero NAO ESTA na sequencia de Fibonacci!");
                    Console.WriteLine(entradaNumero + " esta entre os numeros " + sequenciaFibonacci[sequenciaFibonacci.Count - 2] + " e " + sequenciaFibonacci[sequenciaFibonacci.Count - 1] + ", que estao na sequencia.");
                    Console.Write("\n-----------------------------------------------------------------------------------------");

                    sequenciaFibonacci = new List<int> { 0, 1 };
                    menu(sequenciaFibonacci);
                }

                // se ainda houver possibilidade do numero estar na sequencia de fibonacci as somas sao realizadas e adiconadas na lista
                sequenciaFibonacci.Add((sequenciaFibonacci[sequenciaFibonacci.Count - 1] + sequenciaFibonacci[sequenciaFibonacci.Count - 2]));
            }

            // verificacao apos sair do while para ser imprimido a mensagem de que o numero inserido esta na sequencia de Fibonacci
            if (numeroInserido == sequenciaFibonacci[sequenciaFibonacci.Count - 1] || numeroInserido == 0)
            {
                Console.Clear();
                Console.Write("-----------------------------------------------------------------------------------------\n");
                Console.WriteLine(entradaNumero + " ESTA na sequencia de Fibonacci!");
                Console.Write("\n-----------------------------------------------------------------------------------------");

                sequenciaFibonacci = new List<int> { 0, 1 };
                menu(sequenciaFibonacci);
            }
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.Write("-----------------------------------------------------------------------------------------\n");
            Console.Write("Insira um numero INTEIRO! nao aceitamos tipo texto, booleanos ou numeros decimais!");
            Console.Write("\n-----------------------------------------------------------------------------------------");
            validarSequenciaFibonacci(sequenciaFibonacci);
        }
    }
}