using System;
public class Insercion : IOrdenamiento
{
    public string name()
    {
       return "Insertion";
    }

    public void Sort(int[] array)
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