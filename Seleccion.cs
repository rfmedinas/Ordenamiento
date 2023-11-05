using System;
public class Seleccion : IOrdenamiento
/**
* Fecha: 26 de octubre de 2023
* Autor: Raul Fernando Medina Sandoval
* Descripción: Implementa la interfaz IOrdenamiento para proporcionar un algoritmo de ordenamiento de selección.
**/
{
    public string name()
    //Devuelve el nombre del Método de ordenamiento.
    {
        return "Selection";
    }

    public void Sort(int[] array)
    /**Este método ordena el array de enteros utilizando el algoritmo de selección. Recorre el array y en cada iteración, encuentra el elemento mínimo en la sublista no ordenada y lo intercambia con el primer elemento no ordenado. Este proceso continúa hasta que todo el array esté ordenado de forma ascendente.
    *Parámetros:  Un array de enteros que se va a ordenar.
    * Resultado: El array de entrada es modificado y ordenado en orden ascendente utilizando el algoritmo de Selección.
    **/
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // Intercambiar el elemento mínimo encontrado con el primer elemento no ordenado
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}