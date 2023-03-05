try
{
    Console.WriteLine("---El valor de n  debe ser positivo mayor a 0----");
    Console.WriteLine("Ingrese el valor de n: ");
    int numero = int.Parse(Console.ReadLine());

    int[] ncuadrado = new int[numero];
    for (int i = 1; i <= numero; i++)
    {
        ncuadrado[i - 1] = i * i;
    }
    Console.WriteLine("Los numeros primos menores o iguales a N son: ");

    for (int i = 2; i <= numero; i++)
    {
        bool esPrimo = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                esPrimo = false;
                break;
            }
        }
        if (esPrimo)
        {
            Console.Write(" - " + i);
        }
    }
    Console.WriteLine();
    Console.WriteLine("Numeros multiplos de 4 menores o iguales a N: ");

    for (int i = 4; i <= numero; i += 4)
    {
        Console.Write(" - " + i);
    }
    Console.WriteLine();
    Console.WriteLine("Numeros que comienzan en 1 se incrementan en 3 hasta ser mayores a N: ");

    for (int i = 1; i <= numero; i++)
    {
        if (i % 10 == 1)
        {
            Console.Write(" - " + i);
            int j = i;
            while (j < numero)
            {
                j += 3;
                Console.Write(" - " + j);

            }
            Console.WriteLine();
        }

    }
    Console.WriteLine("impresion de valores guardados en el areglo");

    for (int i = 0; i < numero; i++)
    {
        Console.Write(" - " + ncuadrado[i]);
    }

}
catch(Exception ex)
{
    Console.WriteLine("Era un numero positivo mayor que o. ");
    Console.WriteLine(ex.Message);

}

