using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLinkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();//linkedlist es mas eficiente que list, mas rapida. 

            foreach (int num in new int[]{ 6,5,4,3,2,1,}) 
            {
                numeros.AddFirst(num);// AddFirst cada numero que agrega lo pone de primera.
            }

            numeros.Remove(4);//con esto se elimina el numero asignado de la linkedlist.
            numeros.AddLast(8);// De esta forma agregamos un nuevo dato a la linkedlist.

            /*foreach (int num in numeros) 
            {
                Console.WriteLine(num);
            }*/

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next) 
            {
             int num = nodo.Value;
                Console.WriteLine(num);
            }
        }
    }
}
