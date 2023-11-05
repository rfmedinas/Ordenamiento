using System;
public class Insercion : IOrdenamiento
/**
* Fecha: 26 de octubre de 2023
* Autor: Raul Fernando Medina Sandoval
* Descripción: Implementa la interfaz IOrdenamiento para proporcionar un algoritmo de ordenamiento de inserción.
**/
{
    public string name()
    //Devuelve el nombre del Método de ordenamiento.
    {
        return "Insertion";
    }

    public void Sort(int[] array)
        /**Ordena un array de enteros utilizando el algoritmo de ordenamiento de inserción.
         *Parámetros:  Un array de enteros que se va a ordenar.
         * Resultado: El array de entrada es modificado y ordenado en orden ascendente utilizando el algoritmo de inserción.
        **/
    {
        int n = array.Length;
        for (int i = 1; i < n; ++i)
        {
            int k = array[i];
            int j = i - 1;

            // Mover los elementos del array[0..i-1] que son mayores que k
            // a una posición adelante de su posición actual
            while (j >= 0 && array[j] > k)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = k;
        }
    }
}