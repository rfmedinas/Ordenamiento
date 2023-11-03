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
				 ** Case 1 Solicita la Informacion de la cantidad de numeros que se van a ordenar
				  **/
                case 1:
                    Console.WriteLine("Enter the number of numbers to order");
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
                    Utils.ResolveCase(new Burbuja(), numbers);
                    break;
                case 3:
                    Utils.ResolveCase(new Shell(), numbers);
                    break;
                case 4:
                    Utils.ResolveCase(new Seleccion(), numbers);
                    break;
                case 5:
                    Utils.ResolveCase(new Insercion(), numbers);
                     break;
                case 6:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option");
                    break;
            }

        } while (option != 6);
    }
}
 