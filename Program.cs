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
    Console.Write($"{reptPicaPau} pra vc. ");
    // Console.ReadKey();

    if (alimento > reptPicaPau)
    {
        alimento = alimento - reptPicaPau - 1;
    }

    else // ???
    {
        alimento = resto;
    }



    //             TESTES
        //1ª   20    =   22     -      1      - 1
        //2ª   17    =   20     -      2      - 1
        //3ª   13    =   17     -      3      - 1
        //4ª    8    =   13     -      4      - 1
        //5ª    2    =    8     -      5      - 1
        //6ª   -5    =    2     -      6      - 1

    int colunaRaposinha = 0;
    while (reptPicaPau > colunaRaposinha )//|| alimento > 0 || resto > 0 ???
    {
        colunaRaposinha++; //só aumenta neste while
        Console.Write($"{colunaRaposinha} "); //só exibe a quantidade de vezes que esse 
                                              // bloco é executado, quando sai ele volta a ser 0
        
        resto = alimento - colunaRaposinha; // ???
        // Console.ReadKey();
    }
    
    Console.WriteLine($"pra mim. Teste qt alimento - {alimento}");
}

alimRaposinha = alimentoDig - reptPicaPau;
Console.WriteLine($"\nPica-Pau recebeu {reptPicaPau} alimento(s)\nRaposinha recebeu {alimRaposinha} alimento(s)");