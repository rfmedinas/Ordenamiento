using System;
public class Shell : IOrdenamiento
/**
*Fecha: 26 de octubre de 2023
*Autor: Raul Fernando Medina Sandoval
* Descripción: Implementa la interfaz IOrdenamiento para proporcionar un algoritmo de ordenamiento por le método Shell.
**/
{
    public string name()
    //Devuelve el nombre del Método de ordenamiento.
    {
        return "Shell";
}

public void Sort(int[] array)
    /**Este método ordena el array de enteros utilizando el algoritmo de Shell Sort. El algoritmo divide el array en subarrays más pequeños y luego ordena cada subarray utilizando el algoritmo de inserción. La diferencia clave con el algoritmo de inserción está en la forma en que se eligen los elementos a comparar y cambiar de posición.
    *Parámetros:  Un array de enteros que se va a ordenar.
    * Resultado: El array de entrada es modificado y ordenado en orden ascendente utilizando el algoritmo de Shell.
    **/
    {
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = array[i];
                int j;
                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
        }
    }
}