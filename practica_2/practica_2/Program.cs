using System;
using System.Text;

namespace practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------
            // Iñaki Domene Castillo
            // Curso DAM
            // Modalidad Semipresencial
            // Práctica nº 2
            // --------------------------------------------

            //Pido Cadena1
            //Usuario mete cadena
            //Convierto en char
            //pido letra
            //usuario mete letra
            //recorre el stringbuilder y comprueba si la letra es true o false
            //si true cambia la letra de la posición, si false suma 1 al contador de errores (muestra el resto de la cadena "_")
            string cadena;
            char letra;
            int i;
            bool existe = false;

            Console.WriteLine("Cadena: ");
            cadena = Console.ReadLine();

            StringBuilder cadena2 = new StringBuilder(cadena);
                cadena2.ToString();

            Console.WriteLine("Introduce una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            for (i = 0; i < cadena2.Length; i++)
            {
                if (letra == )
            }

        }
    }
}