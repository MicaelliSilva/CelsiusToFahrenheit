double celsius, fahrenheit;
char opcao;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Conversor de Temperatura\n");
Console.ForegroundColor = ConsoleColor.White;

do
{
    Console.Write("\nInforme a temperatura em celsius: ");
    celsius = double.Parse(Console.ReadLine());

    fahrenheit = (9 * celsius) / 5 + 32;

    Console.WriteLine("Equivalente a fahrenheit: " + fahrenheit);

    Console.WriteLine("\nDeseja repetir (s/n)?");
    opcao = char.Parse(Console.ReadLine());

    while (opcao != 's' && opcao != 'n')
    {
        Console.WriteLine("\nOpção inválida! Digite novamente.\n");
        opcao = char.Parse(Console.ReadLine());
    }

} while (opcao == 's');