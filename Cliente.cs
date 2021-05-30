using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Cliente
    {
        public string nombre;
        
        public string producto;

        public Cliente(string nombre, string producto)
        {
            this.nombre = nombre;
            this.producto = producto;
        }

       Queue<string> clientes1 = new Queue<string>();

       public int count
        {
            get => this.clientes1.Count;
        }    

        //  Imprimir Stack

        public void Push(string clientes2)
        {
            //La parte de arriba de el Stack es el final de la List
            this.clientes1.Add(clientes2);
        }

        public string Pop()
        {
            //  1. Devolver valor
            //  2. Borrar

            //  Respaldar valor
            string value = this.clientes1[this.clientes1.Count -1];

            //  Borrar de la lista
            this.clientes1.RemoveAt(this.clientes1.Count -1);

            //  Devolver el valor respaldado
            return value; //  <----- La funcion llega hasta aqui
        }

        public string Peek()
        {
            return this.clientes1[this.clientes1.Count - 1];
        }

        public void PrintStack()
        {
            //  Todo: Implementar
            for(int i = this.clientes1.Count -1; i >= 0; i--)
            {
                Console.WriteLine(clientes1[i]);
            }    
    }
}