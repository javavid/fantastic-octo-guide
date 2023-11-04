using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange (new int[] {1,2,3,4,5,6,7,8 });// AddRange Agrega los elementos de la colección especificada al final de List<T> .

            //Declaramos delegado predicado.

            Predicate<int> Dele = new Predicate<int>(DamePares);
            List<int> numPres = listaNumeros.FindAll(Dele); FindAll Recupera todos los elementos que coinciden con las condiciones definidas por el predicado especificado.

            foreach (int i in numPres) 
            {
                Console.WriteLine(i);
            }*/

            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();

            p1.Nombre1 = "juan";
            p1.Edad1 = 21;

            Personas p2 = new Personas();

            p2.Nombre1 = "marie";
            p2.Edad1 = 19;

            Personas p3 = new Personas();

            p3.Nombre1 = "anna";
            p3.Edad1 = 27;

            Personas p4 = new Personas();

            p4.Nombre1 = "pedro";
            p4.Edad1 = 31;

            gente.AddRange( new Personas[] { p1,p2,p3,p4});

            Predicate<Personas> pernas = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(pernas);// Exists Determina si List<T> contiene elementos que coinciden con las condiciones definidas por el predicado especificado.

            if (existe) Console.WriteLine("si hay personas que se llaman juan");
            else Console.WriteLine("no hay nadie llamado juan");

        }

        static bool ExisteJuan(Personas personas1) //un Delegado Predicado siempre de debe de devolver un tipo bool.
        {
            if(personas1.Nombre1 == "juan" ) return true;
            else return false;
        }

        /*static bool DamePares(int num) 
        {
            if (num % 2 == 0) return true;
            else return false;
        }*/



    }
}
