int numberOne, numberTwo, aux, max;

do
{
    numberOne = 1;
    numberTwo = -1;
    aux = 1;

    max = int.Parse(Console.ReadLine());

    for (int i = 0; i < max; i++)
    {
        aux = numberTwo;
        numberTwo = numberOne;
        numberOne += aux;
        Console.Write($"{numberOne} ");
    }

    Console.WriteLine();
} while (max != 0);

Console.ReadKey();