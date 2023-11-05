using System;

    /** Fecha: 02 de noviembre de 2023
    *  Autor: Raul Fernando Medina Sandoval
    * Descripción: Este código define una interfaz pública llamada IOrdenamiento.
    * La interfaz contiene  un método void llamado Sort que toma un array de enteros y lo ordena,
    un método String llamado name que devuelve el nombre del Método de ordenamiento.
    **/
public interface IOrdenamiento
    {
         // Método para ordenar un array de enteros.
    void Sort(int[] array);
        // Método para obtener el nombre del método de ordenamiento.
    String name();
   
}

