using System;
using System.Diagnostics;
using System.IO;
using System.Linq;




    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Please enter 10 different numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
               /* try
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--;
                }
                //catch (CustomException ex)
                catch (Excepcion ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }*/
            }
            /*Burbuja burbuja = new Burbuja();
            burbuja.Sort(numbers);
            Console.Write("the ordered numbers are:" + numbers);
            Shell shell = new Shell();
            shell.Sort(numbers);
            Console.Write("the ordered numbers  are:" + numbers);
            Seleccion seleccion = new Seleccion();
            seleccion.Sort(numbers);
            Console.Write("the ordered numbers  are:" + numbers);*/
            
            Insercion insercion = new Insercion();
            insercion.Sort(numbers);
            StreamWriter orden = File.AppendText("Ordenamiento.txt");
            orden.Write("\n The numbers ordered using the Insertion method are: \n ");
         foreach (var number in numbers)
        {
            orden.Write(number + " ");
        }
        Console.WriteLine();
        Process.Start(new ProcessStartInfo { FileName = @"Ordenamiento.txt" });
        orden.Close();
       
           //Console.WriteLine("The numbers ordered using the Insertion method are:" + numbers);
           

        }
    }
 
