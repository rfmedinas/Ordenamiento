using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
/**
* Fecha: 03 de noviembre de 2023
* Autor: Raúl Fernando Medina Sandoval
* Descrpición:Este programa realiza operaciones de ordenamiento utilizando los métodos de ordenamineto, Burbuja, Shell, Selección e Inserción.
**/
{


    static void Main()
        {
        // Declaración de la interfaz IOrdenamiento para el polimorfismo.
        IOrdenamiento orden;
        // Variable para almacenar la opción seleccionada por el usuario.        
        int option;
        // Tamaño del arreglo de números a ordenar.
        int size = 0;
        // Arreglo de enteros que almacenará los números a ordenar.
        int[] numbers = new int [size];
        // Bucle do -while que ejecuta el programa hasta que el usuario elige salir.
        do
         {
            // Muestra el menú y obtiene la opción del usuario. 
            option = Utils.MostrarMenu();

            switch (option)
            {
                 
				 //Case 1 Solicita la Informacion de la cantidad de numeros que se van a ordenar
				 
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
                
                // Proceso que realiza el ordenamiento con el método Burbuja
               
                case 2:
                    if (size != 0)
                    {
                        Utils.ResolveCase(new Burbuja(), numbers);
                    }
                    else
                    {
                        Console.WriteLine("Please complete Option 1 before proceeding to Option 2.");
                    }
                    break;

                // Proceso que realiza el ordenamiento con el método Shell


                case 3:
                    if (size != 0)
                    {
                        Utils.ResolveCase(new Shell(), numbers);
                    }
                    else
                    {
                        Console.WriteLine(" Please complete option 1 before proceeding to Option 3 .");
                    }
                    break;

                // Proceso que realiza el ordenamiento con el método Selección

                case 4:
                    if (size != 0)
                    {
                        Utils.ResolveCase(new Seleccion(), numbers);
                    }
                    else
                    {
                        Console.WriteLine(" Please complete option 1 before proceeding to Option 4 .");
                    }
                    break;

                // Proceso que realiza el ordenamiento con el método de Inserción

                case 5:

                    if (size != 0)
                    {
                        Utils.ResolveCase(new Insercion(), numbers);
                    }
                    else
                    {
                        Console.WriteLine(" Please complete option 1 before proceeding to Option 5.");
                    }
                    break;

                // salir del programa

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
 