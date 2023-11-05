using System;
using System.Diagnostics;
using System.IO;

/**
 * Fecha: 02 de noviembre de 2023
 * Autor: Raúl Fernando Medina Sandoval
 * Descripción:La clase Utils contiene métodos de utilidad para operaciones relacionadas con ordenamiento de números.
 * Incluye métodos para imprimir los números ordenados en un archivo de texto, verificar si un número ya existe en un array,
 * leer números desde la entrada estándar y mostrar un menú de opciones para que el usuario elija la operación de ordenamiento.
 * También contiene un método ResolveCase que toma una interfaz IOrdenamiento y un array de números para ordenarlos usando el método 
 * especificado y luego imprimir los números ordenados en un archivo de texto.
  **/
public static class Utils
   /**Este método imprime los números ordenados en un archivo de texto llamado "Ordenamiento.txt"
    *junto con el nombre del método de ordenamiento utilizado.
  **/
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
      /**Este método verifica si un número ya existe en un array dado.Retorna true si el número
        * ya existe en el array y false en caso contrario.
        **/
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
    public static int[] readNumber(int size){
        /**Este método solicita al usuario ingresar una cantidad de números diferentes y los almacena en un array.Si el usuario
        *    ingresa un número que ya existe en el array, se le solicita ingresar otro número.
        **/
    
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
     return numbers;   }
    // Este método muestra un menú de opciones para que el usuario elija la operación de ordenamiento que desea realizar.

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
        /** Este método toma una interfaz IOrdenamiento y un array de números como entrada.
        *   Llama al método Sort de la interfaz IOrdenamiento para ordenar los números y luego utiliza el método Print para imprimir los números
        *   ordenados en el archivo de texto junto con el nombre del método de ordenamiento utilizado
       **/
    {
        method.Sort(numbers);
       Utils.Print(numbers, method.name());
    }
}

