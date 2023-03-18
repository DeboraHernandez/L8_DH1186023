// See https://aka.ms/new-console-template for more information

Console.WriteLine("a. Sumatoria");
Console.WriteLine("b. Tablas de multiplicar");
Console.WriteLine("c. Numeros perfectos");

char opcion = Convert.ToChar(Console.ReadLine());

switch (opcion)
{
    case 'a':
        Console.WriteLine("Ingrese un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int resultado = 0;

        while (n > 0)
        {
            resultado = resultado + n;
            n--;
        }
        Console.WriteLine("Sumatoria = " + resultado);
        break;
    case 'b':
        
        for (int i = 1; i < 11; i++)
        {
            Console.Write(i + ": ");
            for (int j = 1; j < 11; j++)
            {
                Console.Write((i*j)+"\t");
            }
            Console.Write("\n");
        }
        break;
    case 'c':
        Console.WriteLine("Ingrese el numero que desea evaluar: ");
        n = Convert.ToInt32(Console.ReadLine());
        int c = 0;
        int d = 0;
        int b = n;
        for (int x = 1; x < b; x++)
        {
            if (n % x == 0)
            {
                c = c + x;
            }   
        }
        if (c == n)
            {
                Console.WriteLine(n + " es un numero perfecto");
            }
            else
            {
                Console.WriteLine(n + " no es un numero perfecto");
            }
        
        break;
}

