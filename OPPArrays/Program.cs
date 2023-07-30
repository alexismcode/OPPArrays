using System;
using System.Collections.Generic;

public class Program
{
    // Función para comprobar si un número es primo.
    public static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Método para obtener los números primos del array.
    public static int[] NumerosPrimos(int[] array)
    {
        // Utilizamos Array.FindAll para filtrar los números primos del array
        // utilizando la función EsPrimo como criterio de búsqueda.
        return Array.FindAll(array, EsPrimo);
    }

    // Método para obtener los números no repetidos del array.
    public static int[] NumerosNoRepetidos(int[] array)
    {
        // Utilizamos un diccionario para contar las ocurrencias de cada número.
        Dictionary<int, int> ocurrencias = new Dictionary<int, int>();

        foreach (int num in array)
        {
            // Si el número ya está en el diccionario, incrementamos su contador.
            if (ocurrencias.ContainsKey(num))
                ocurrencias[num]++;
            // Si no está en el diccionario, lo agregamos con contador inicial en 1.
            else
                ocurrencias[num] = 1;
        }

        // Utilizamos Array.FindAll para filtrar los números con ocurrencia igual a 1,
        // lo que representa los números que no se repiten.
        return Array.FindAll(array, num => ocurrencias[num] == 1);
    }

    // Método para obtener los números más repetidos del array.
    public static int[] NumerosMasRepetidos(int[] array)
    {
        // Utilizamos un diccionario para contar las ocurrencias de cada número.
        Dictionary<int, int> ocurrencias = new Dictionary<int, int>();

        foreach (int num in array)
        {
            // Si el número ya está en el diccionario, incrementamos su contador.
            if (ocurrencias.ContainsKey(num))
                ocurrencias[num]++;
            // Si no está en el diccionario, lo agregamos con contador inicial en 1.
            else
                ocurrencias[num] = 1;
        }

        // Encontramos la máxima cantidad de repeticiones en el diccionario.
        int maxRepeticiones = ocurrencias.Values.Max();

        // Utilizamos Array.FindAll para filtrar los números con la máxima cantidad de repeticiones.
        return Array.FindAll(array, num => ocurrencias[num] == maxRepeticiones);
    }

    public static void Main()
    {
        // Array de prueba con algunos números.
        int[] numeros = { 1, 2, 3, 4, 5, 2, 7, 8, 6, 7, 8, 9, 10, 4, 6, 11, 12, 13, 14, 15 };

        // Obtener números primos
        int[] primos = NumerosPrimos(numeros);
        Console.WriteLine("Números primos:");
        foreach (int primo in primos)
        {
            Console.Write(primo + " ");
        }
        Console.WriteLine();

        // Obtener números no repetidos
        int[] noRepetidos = NumerosNoRepetidos(numeros);
        Console.WriteLine("Números no repetidos:");
        foreach (int num in noRepetidos)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Obtener números más repetidos
        int[] masRepetidos = NumerosMasRepetidos(numeros);
        Console.WriteLine("Números más repetidos:");
        foreach (int num in masRepetidos)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
