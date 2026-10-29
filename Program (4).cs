Console.WriteLine("--- Entrada Válida ---");
Console.WriteLine();

int numero;

while (true)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");

    if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0 && numero <= 9)
    {
        break;
    }
}

Console.WriteLine();

if (numero == 0)
{
    Console.WriteLine("Operação cancelada.");
}
else
{
    Console.WriteLine($"Número selecionado = {numero}");
}

Console.WriteLine();
Console.WriteLine("Volte sempre!");
