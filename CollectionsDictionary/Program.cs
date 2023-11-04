using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dictionary1 = new Dictionary<string,int>();

            //Rellenar el diccionario.

            dictionary1.Add("pedro", 50);//se agrega por medio Add.
            dictionary1.Add("santi", 20);
            dictionary1["aleja"] = 22;   //se agrega por medio de Array.
            dictionary1["pamela"] = 35;

            //Recorrer el diccionario.
            foreach(KeyValuePair<string,int> Persona in dictionary1) 
            {
                Console.WriteLine("Nombre:" + Persona.Key + "  Edad:" + Persona.Value);
            }
        }
    }
}
