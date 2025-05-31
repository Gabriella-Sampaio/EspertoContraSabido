Console.Clear();

int alimento,
reptPicaPau = 0,
alimRaposinha,
alimentoDig,
resto = 0;

Console.Write("Alimentos na mesa: ");
alimentoDig = Convert.ToInt32(Console.ReadLine());
alimento = alimentoDig;

while (alimento > 0) //enquanto o alimento é maior q 0
{
    reptPicaPau++; //nm de repetição/ contador && quantidade de alimento do pica-pau 
    Console.Write($"{reptPicaPau} pra vc");
    // Console.ReadKey();

    if (resto >= 0) //??? n pode exibir se n tiver nada pra raposinha após (teste nm 28)
    {
        Console.Write(", ");
    }


    int colunaRaposinha = 0;
    while (reptPicaPau > colunaRaposinha) //|| resto >0
    {
        resto = alimento - colunaRaposinha;

        colunaRaposinha++; //só aumenta neste while

        if (resto - 1 > 0) // SOLUÇÃO!!!!!
        {
            Console.Write($"{colunaRaposinha} "); //só exibe a quantidade de vezes que esse 
                                                  // bloco é executado, quando sai ele volta a ser 0
            //add contador??? pra questão do último "pra mim"
        }

        Console.Write($" (resto: {resto}) ");
        //RESOLVER A QUESTÃO DO TESTE NM 28, A VIRGULA NO NM E 
    }

    // if (alimento > 0) //??? não pode exibir se o while a cima n exibir nada (teste nm 22)
    // {
        
    // }


    if (resto > 0)
    {
        alimento = alimento - reptPicaPau - 1;
        Console.WriteLine($"pra mim. ");
    }

    else
    {
        alimento = 0;
        // Console.WriteLine($"resto: {resto}, alimento {alimento}");
    }

}

alimRaposinha = alimentoDig - reptPicaPau;
Console.WriteLine($"\nPica-Pau recebeu {reptPicaPau} alimento(s)\nRaposinha recebeu {alimRaposinha} alimento(s)");