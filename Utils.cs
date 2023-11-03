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

        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Enter the number of numbers you want to order");
        Console.WriteLine("2. Sort by Bubble method");
        Console.WriteLine("3. Sort by Shell method");
        Console.WriteLine("4. Sort by selection method");
        Console.WriteLine("5. Sort by insertion method");
        Console.WriteLine("6. Exit");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        else
        {
            return -1; // Valor inválido
        }
    }

    public static void ResolveCase(IOrdenamiento method, int[] numbers)
    {
        method.Sort(numbers);
       Utils.Print(numbers, method.name());
    }
}

