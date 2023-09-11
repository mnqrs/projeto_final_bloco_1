namespace Projeto_Final
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1, produto;

            while (opcao != 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("   \r\n     _/_-.-_\\_        _/.-.-.\\_        _/.-.-.\\_       _/.-.-.\\_\r\n    / __} {__ \\      /|( o o )|\\      ( ( o o ) )     ( ( o o ) )\r\n   / //  \"  \\\\ \\    | //  \"  \\\\ |      |/  \"  \\|       |/  \"  \\|\r\n  / / \\'---'/ \\ \\  / / \\'---'/ \\ \\      \\'/^\\'/         \\ .-. /\r\n  \\ \\_/`\"\"\"`\\_/ /  \\ \\_/`\"\"\"`\\_/ /      /`\\ /`\\         /`\"\"\"`\\\r\n   \\           /    \\           /      /  /|\\  \\       /       \\");
                Console.WriteLine("                                                     ");
                Console.WriteLine("             Monkey and co                           ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Cadastrar produto                    ");
                Console.WriteLine("            2 - Listar produtos                      ");
                Console.WriteLine("            3 - Buscar                               ");
                Console.WriteLine("            4 - Atualizar Produto                    ");
                Console.WriteLine("            5 - Apagar Produto                       ");
                Console.WriteLine("            0 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                opcao = Convert.ToInt32(Console.ReadLine());

            }


            if (opcao == 6)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\nMonkey and co");
                Console.ResetColor();
                System.Environment.Exit(0);
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o produto a ser cadastrado:");
                    produto = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2: Console.WriteLine("Listar todos os produtos:");
                    break;
                case 3: Console.WriteLine("Buscar produtos:");
                    break;
                case 4: Console.WriteLine("Atualizar produto:");
                    break;
                case 5: Console.WriteLine("Apagar produto");
                    break;
                default: Console.WriteLine();
                    break;

            }



        }
    }
}