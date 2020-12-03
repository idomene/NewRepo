using System;
using System.Text;

//-------------------------------------------------------------
// Cecilia Arcos Francisco
// 1º DAM
// Semipresencial
// Práctica nº 2
// ------------------------------------------------------------

namespace practica_2
{
    class Program
    {
        static void Main(string[] args)
        {

            char letra = ' '; 
            string cadena = "";
            int intentos = 0;
            bool encendido = false;
            int posicion = 0;
            bool cto = false;

            Console.Write("cadena: ");          //Pido cadena a adivinar
            cadena = Console.ReadLine().ToLower();        //Cojo dato cadena

            StringBuilder cadena2 = new StringBuilder(cadena);  //Modifico cadena para obtener los datos 1 a 1 
            cadena2.ToString();


            for (int i = 0; i < cadena.Length; i++)                 //Bucle para crear _ _ _ de acuerdo con el 
            {                                                       //nº de datos de cadena2
                cadena2[i] = '_';

            }

            do
            {
                do
                {
                    try
                    {
                        Console.Write("letra: ");                           //Capturo excepción para que no me metan un 
                        letra = Convert.ToChar(Console.ReadLine().ToLower());         //me metan un erroneo a modo de letra
                        Console.WriteLine();
                        cto = true;
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("--> Dato no válido, introdúcelo de nuevo.");  //Si se ponen un dato erroneo salta el mensaje
                        cto = false;
                    }


                } while (!cto);                 //La excepción se repite hasta que me den una letra/caracter correcto



                if (cadena.Contains(letra) == true)     //Si la letra está dentro de la cadena entonces hace lo siguiente:
                {
                    for (int i = 0; i < cadena.Length; i++) //bucle para encontrar en qué sitio está la letra y si se repite
                    {
                        if (cadena.IndexOf(letra, i) >= 0)
                        {
                            posicion = cadena.IndexOf(letra, i);
                            cadena2[posicion] = letra;
                        }

                    }

                    Console.Write(cadena2);          // muestro cadena2
                    Console.WriteLine();


                    if (String.Equals(cadena, Convert.ToString(cadena2)) == true)  // igualo cadena tipo String con un StringBuilder (cadena2)
                    {                                                              // y si es igual entonces se reproduce el mensaje de 
                        Console.WriteLine("¡¡¡Enhorabuena!!!");                    // "enhorabuena" y sale del programa
                        encendido = true;
                    }

                }
                //Si la letra no está dentro de cadena entonces:
                else
                {

                    intentos++;         //sumamos un intento y entramos en el switch



                    switch (intentos)       // en caso de que se haga cierta cantidad de intentos sale un dibujo X
                    {
                        case 1:             // En el caso de un intento: 
                            {

                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");    //Solo sale la cabeza
                                Console.WriteLine("|");
                                Console.WriteLine("|");
                                Console.WriteLine("|____________");
                                Console.WriteLine();

                                //Console.WriteLine(cadena2);      //Muestro la cadena2 a acertar
                                //Console.WriteLine();
                                break;

                            }

                        case 2:             //En el caso del segundo intento
                            {
                                //Primer brazo ahorcado

                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");
                                Console.WriteLine("|   /");
                                Console.WriteLine("|");
                                Console.WriteLine("|____________");
                                Console.WriteLine();

                                //Console.WriteLine(cadena2);      //Muestro la cadena2 a acertar
                                //Console.WriteLine();

                                break;


                            }

                        case 3:
                            {

                                //Pecho ahorcado

                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");
                                Console.WriteLine("|   /| ");
                                Console.WriteLine("|");
                                Console.WriteLine("|____________");
                                Console.WriteLine();

                                //Console.WriteLine(cadena2);      //Muestro la cadena2 a acertar
                                //Console.WriteLine();

                                break;
                            }

                        case 4:
                            {
                                //Segundo brazo ahorcado

                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");
                                Console.WriteLine("|   /|\\ ");  //aquí hay que poner dos barras por que si no no sale.
                                Console.WriteLine("|");
                                Console.WriteLine("|____________");
                                Console.WriteLine();

                                //Console.WriteLine(cadena2);      //Muestro la cadena2 a acertar
                                //Console.WriteLine();

                                break;
                            }

                        case 5:
                            {
                                //Primera pierna ahorcado

                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");
                                Console.WriteLine("|   /|\\ ");
                                Console.WriteLine("|   /");
                                Console.WriteLine("|____________");
                                Console.WriteLine();

                                //Console.WriteLine(cadena2);      //Muestro la cadena2 a acertar
                                //Console.WriteLine();

                                break;

                            }

                        case 6:                     //En el caso de llegar al sexto intento se muestra el muñeco ahorcado 100%
                            {
                                //Segunda pierna ahorcado
                                Console.WriteLine("______");
                                Console.WriteLine("|    |");
                                Console.WriteLine("|    o");
                                Console.WriteLine("|   /|\\ ");
                                Console.WriteLine("|   / \\");
                                Console.WriteLine("|___________");
                                Console.WriteLine();

                                Console.WriteLine("R.I.P La palabra correcta era: {0}.", cadena); //Muestro el mensaje de RIP y la palabra correcta

                                encendido = true; // Salgo del programa

                                break;

                            }

                    }


                }


            } while (!encendido) ;   //que se repita mientras haya intentos (máx 6) ó no se acierte la cadena.

            
        }

    }

}