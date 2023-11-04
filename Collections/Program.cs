using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros= new List<int>();// declarar una lista (coleccion de tipo lista).
            /*numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);

            //de esta manera se almasena o guarda una array en una list.
            int[] listanum = new int[] { 7, 2, 3, 4, 5 };

            for(int e = 0;e < 5 ; e++ ) //este for me almacena los elementos en la list (numeros.add).
            {
                numeros.Add(listanum[e]);
            }


            for(int i = 0; i < 5; i++) // este for me recorre la list almacenada y me la muestra en pantalla.
            {
                Console.WriteLine(numeros[i]);
            }

            /*foreach(int i in numeros) //tambien se puede recorrer con foreach.
            {
                Console.WriteLine(i);
            }*/
            // una list pude ser modificada mientras esta en funcion lo que no se puede en un array.
            // el metodo Add es para agregar.
            
            Console.WriteLine("¿Cuantos elementos quieres introducir?");
            int lista = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("digite los datos");

            for (int i = 0; i < lista; i++) // con la propiedad Count se le dice a tu programa cuantos elememtos se ingresaron.
            {                               // Ejemplo   for (int i = 0; i < numeros.count; i++) asi se utiliza en el for en caso que no sepas cuantos elementos hay en lista.
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("");
            Console.WriteLine("imprimendo datos ingresados");
            for (int i = 0; i < lista; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
