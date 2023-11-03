using System;
using System.Diagnostics;
using System.IO;


    public static class Utils
    {
    public static void Print(int[] numbers, String nameMethod)
    {
        StreamWriter orden = File.AppendText("Ordenamiento.txt");
        orden.Write("\n The numbers ordered using the " + nameMethod +" method are: \n ");
         foreach (var number in numbers)
        {
            orden.Write(number + " ");
        }
        Console.WriteLine();
        Process.Start(new ProcessStartInfo { FileName = @"Ordenamiento.txt" });
        orden.Close();
    }
    public static Boolean existNumber(int[] numbers,int newNumber)
    {
        Boolean exist = false;
        foreach (var number in numbers)
        {
          if (number == newNumber)
            {
                exist = true;
                break;
            }
        }
             return exist;
    }
    public static int[] readNumber(int size)
    {
        int[] numbers = new int[size];
        Console.WriteLine("Please enter " + size +" different numbers:");

        for (int i = 0; i < size; i++)
        {

            try
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (Utils.existNumber(numbers, number))
                {
                    Console.WriteLine("This Number already exist");
                    i--;
                }
                else
                {
                    numbers[i] = number;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }
     return numbers;

    }
    public static int MostrarMenu()
    {

        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Digite la cantidad de numeros que desea ordenar");
        Console.WriteLine("2. Ordenar por metodo Burbuja.");
        Console.WriteLine("3. Ordenar por metodo Shell.");
        Console.WriteLine("4. Ordenar por metodo seleccion");
        Console.WriteLine("5. Ordenar por metodo insercion");
        Console.WriteLine("6. Salir.");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        else
        {
            return -1; // Valor inválido
        }
    }

    /*public static void ResolveCase(IOrdenamiento method, int[] numbers)
    {
        method = new Burbuja();
        method.Sort(numbers);
       Utils.Print(numbers, method.name());
    }*/
}

