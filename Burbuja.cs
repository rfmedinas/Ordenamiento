using System;


/**
 * Fecha: 26 de octubre de 2023
 * Autor: Raúl Fernando Medina Sandoval
 * Descripción: Este código implementa el algoritmo de ordenamiento de burbuja, implementa la interfaz 'IOrdenamiento' y proporciona una implementación específica del método 'Sort'.
 **/
public class Burbuja : IOrdenamiento
{
    public string name()
    //Devuelve el nombre del Método de ordenamiento.
    {
        return "Bubble";
    }

    public void Sort(int[] array)
    /**Este método toma un arreglo de enteros como entrada y ordena los elementos usando el algoritmo de burbuja.
    *Parámetros:  Un array de enteros que se va a ordenar.
    * Resultado: El array de entrada es modificado y ordenado en orden ascendente utilizando el algoritmo de Burbuja.
    **/
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Intercambiar array[j] y array[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}