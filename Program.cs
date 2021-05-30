using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Cliente> fila = new Queue<Cliente>();

            Cliente Jorge = new Cliente("Jorge", "Tostitos");
            Cliente Luis = new Cliente("Luis", "Doritos");
            Cliente Martha = new Cliente("Martha", "Pepsi");
            Cliente Roberto = new Cliente("Roberto", "Tortillas");
            Cliente Juan = new Cliente("Juan", "Queso");

            fila.Enqueue(Jorge );
            fila.Enqueue(Luis );
            fila.Enqueue(Martha );
            fila.Enqueue(Roberto );
            fila.Enqueue(Juan );

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                // Pedir opción al usuario
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                {
                    // Escapar caracter "
                    Console.WriteLine("1) Formados");
                    Console.WriteLine("2) Formarse");
                    Console.WriteLine("3) Atender");
                    Console.WriteLine("4) Total atendidos");
                    Console.WriteLine("9) Salir");


                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    // Validar opción ingresada
                    // hasta que se introduzca una opción correcta
                    // (mientras no se haya introducido una opción correcta)
                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta.");
                    }
                }

                // Manejar la opción seleccionada
                if (opcion == "1")
                {
                    Cliente.PrintStack();
                }
                else if (opcion == "2")
                {
                    //  Push
                    Console.WriteLine("Formarse:");
                    string nota = Console.ReadLine();
                    Cliente.Push(nota);
                }
                else if(opcion == "3")
                {
                    //  Pop
                    string nota = Cliente.Pop();
                    Console.WriteLine("Atender:");
                    Console.WriteLine(nota);
                }
                else if(opcion == "4")
                {
                    //  Peek
                    string nota = Cliente.Peek();
                    Console.WriteLine("Total atendidos:");
                    Console.WriteLine(nota);
                }        
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta luego!");
                }
        }
    }
}
