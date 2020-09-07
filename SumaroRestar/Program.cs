using Microsoft.VisualBasic;
using System;
using System.Text.Json;

namespace SumaroRestar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Soy Una calculadora :D, mis funciones basicas son Sumar(s) o Restar(r)");

            Console.WriteLine("Que operacion quieres realizar? s o  r>");

            string operacion = Console.ReadLine();

            if (operacion == "s")
            {
                Console.WriteLine("La operacion que elegiste es {0}, Correcto? y/n", operacion);
                string yon = Console.ReadLine();

                if (yon == "y")
                {
                    Console.WriteLine("Eliga el primero numero");
                    string valnumero1 = Console.ReadLine();
                    int numero1 = Convert.ToInt32(valnumero1);

                    Console.WriteLine("Eliga el Segundo numero");
                    string valnumero2 = Console.ReadLine();
                    int numero2 = Convert.ToInt32(valnumero2);

                    Console.WriteLine("El resultado de la Operacion {0} + {1} es = {2}",numero1,numero2,numero1+numero2);
                }
                else {
                    Console.WriteLine("Por Favor intentelo de nuevo");
                }


            }
            else if(operacion == "r"){
                Console.WriteLine("La operacion que elegiste es {0}, Correcto? y/n", operacion);
                string yon = Console.ReadLine();

                if (yon == "y")
                {
                    Console.WriteLine("Eliga el primero numeo");
                    string valnumero1 = Console.ReadLine();
                    int numero1 = Convert.ToInt32(valnumero1);

                    Console.WriteLine("Eliga el Segundo numero");
                    string valnumero2 = Console.ReadLine();
                    int numero2 = Convert.ToInt32(valnumero2);

                    Console.WriteLine("El resultado de la Operacion {0} - {1} es = {2}", numero1,  numero2, numero1 - numero2);
                }
                else
                {
                    Console.WriteLine("Por Favor intentelo de nuevo");
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese valores validos");
            }


        }
    }
}
