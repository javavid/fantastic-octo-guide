using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Nuemros = new Queue<int>();

            //Rellenando o agregando elementos a la cola.

            foreach (int num in new int[5] {10,9,8,7,6}) 
            {
             Nuemros.Enqueue(num);
            }

            //Recorriendo la cola.

            Console.WriteLine("recorriendo el queue(cola)");

            foreach (int num in Nuemros) 
            {
                Console.WriteLine(num);
            }

            //Eliminando elementos del queue(cola).

            Console.WriteLine("Eliminando elementos");

            Nuemros.Dequeue();

            foreach (int num in Nuemros)
            {
                Console.WriteLine(num);
            }




            //***************************************************************************************
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("prueva del Stack ");
            // aca utilisaresmos la collections Stack.
            Stack<int> Nros = new Stack<int>();

            //Rellenando o agregando elementos al Stack.

            foreach (int num in new int[5] { 10, 9, 8, 7, 6 })
            {
                Nros.Push(num);
            }

            //Recorriendo la Stack.

            Console.WriteLine("recorriendo el Stack");

            foreach (int num in Nros)
            {
                Console.WriteLine(num);
            }

            //Eliminando elementos del Stack.

            Console.WriteLine("Eliminando elementos");

            Nros.Pop();

            foreach (int num in Nros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
