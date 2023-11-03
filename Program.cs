using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
    {
    

    static void Main()
        {

        IOrdenamiento orden;
               
        int option;
        int size = 0;
        int[] numbers = new int [size];
        do
        {
            option = Utils.MostrarMenu();

            switch (option)
            {
                /** 
				 ** Case 1 Imprime la información del tren y calcula y muestra el porcentaje de ocupación del tren
				  **/
                case 1:
                    Console.WriteLine("Digite la Cantidad de numeros a ordenar");
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        numbers = Utils.readNumber(size);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        
                    }
                    
                    break;
                case 2:
                    orden = new Burbuja();
                    orden.Sort(numbers);
                    Utils.Print(numbers, orden.name());
                    break;
                case 3:
                    orden = new Shell();
                    orden.Sort(numbers);
                    Utils.Print(numbers, orden.name());
                    break;
                case 4:
                    orden = new Seleccion();
                    orden.Sort(numbers);
                    Utils.Print(numbers, orden.name());
                    break;
                case 5:
                    orden = new Insercion();
                    orden.Sort(numbers);
                    Utils.Print(numbers, orden.name());
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

        } while (option != 6);
    }
}
 