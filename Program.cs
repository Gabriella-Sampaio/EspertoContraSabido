Console.Clear();

int alimento, 
nrRepeticaoPicaPau = 0,
alimentoRaposinha = 0;

Console.Write("Alimentos na mesa: ");
alimento = Convert.ToInt32(Console.ReadLine());

while (alimento !> 0)
{
    nrRepeticaoPicaPau = nrRepeticaoPicaPau + 1;
    alimento = alimento - nrRepeticaoPicaPau - 1; //ok?

    Console.Write($"Repetição: {nrRepeticaoPicaPau}; Alimento: {alimento} ");
    Console.ReadKey();
}