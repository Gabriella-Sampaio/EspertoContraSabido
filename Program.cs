Console.Clear();

int alimento,
reptPicaPau = 0,
alimRaposinha,
alimentoDig,
resto;


Console.Write("Alimentos na mesa: ");
while (!Int32.TryParse(Console.ReadLine(), out alimentoDig))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nValor inválido, tente novamente");
    Console.ResetColor();
    Console.Write("Alimentos na mesa: ");
}
alimento = alimentoDig;
Console.Clear();

Console.WriteLine("Raposinha diz ao Pica-Pau:\n");

while (alimento > 0) 
{
    reptPicaPau++; //nm de repetição/ contador && quantidade de alimento do pica-pau 
    Console.Write($"{reptPicaPau} pra vc");
    // Console.ReadKey();

    int reptRaposinha = 0;
    int colunaRaposinha = 0;
    while (reptPicaPau > colunaRaposinha)
    {
        resto = alimento - colunaRaposinha;
        colunaRaposinha++; //só aumenta neste while

        if (resto - 1 > 0) // SOLUÇÃO!!!!!
        {
            Console.Write($" {colunaRaposinha}");
            reptRaposinha++;
            // bloco é executado, quando sai ele volta a ser 0
        }
        // Console.Write($" (resto: {resto}) ");
    }

    if (alimento > reptPicaPau)
    {
        alimento = alimento - reptPicaPau - 1;
        Console.WriteLine(" pra mim.");
    }

    else if (reptRaposinha == 0)
    {
        alimento = 0;
        Console.WriteLine(".");
    }

    else
    {
        alimento = 0;
        // Console.WriteLine($"resto: {resto}, alimento {alimento}");
        Console.WriteLine(" pra mim.");
    }
}

alimRaposinha = alimentoDig - reptPicaPau;
Console.WriteLine($"\nPica-Pau recebeu {reptPicaPau} alimento(s)\nRaposinha recebeu {alimRaposinha} alimento(s)\n");
