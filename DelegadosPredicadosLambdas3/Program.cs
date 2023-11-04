using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambdas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();

            p1.Nombre1 = "juan";
            p1.Edad1 = 21;

            Personas p2 = new Personas();

            p2.Nombre1 = "marie";
            p2.Edad1 = 25;


            /*gente.AddRange(new Personas[] { p1, p2 });

            Predicate<Personas> pernas = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(pernas);// Exists Determina si List<T> contiene elementos que coinciden con las condiciones definidas por el predicado especificado.

            if (existe) Console.WriteLine("si hay personas que se llaman juan");
            else Console.WriteLine("no hay nadie llamado juan");
        }

        static bool ExisteJuan(Personas personas1) //un Delegado Predicado siempre de debe de devolver un tipo bool.
        {
            if (personas1.Nombre1 == "juan") return true;
            else return false;
        }*/





            //uso del delegado.

            //OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);funsiona llamando al metod.
            //OperacionesMatematicas operacion1 = new OperacionesMatematicas(Suma);funsiona llamando al metod.
            //OperacionesMatematicas operacion1 = new OperacionesMatematicas((num1,num2) => num1+num2);//<- expresion lambda.
            //OperacionesMatematicas operacion = new OperacionesMatematicas(num => num*num);//(num => num*num) <- esta es una expresion lambda.

            //Console.WriteLine(operacion1(5,5));
            //Console.WriteLine(operacion(5));


            //List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //List<int> numPares = num.FindAll(i => i % 2 == 0);//<- expresion lambda.

            //foreach (int N in numPares) Console.WriteLine(N);

            //numPares.ForEach(i => Console.WriteLine(i));//<- expresion lambda.

            ComparePersonas compareedad = ((persona1,persona2) => persona1 == persona2);//<-expresion lambda.

            Console.WriteLine(compareedad(p1.Edad1,p2.Edad1));

        }


        public delegate bool ComparePersonas(int edad1, int edad2);

        class Personas
        {
            private string Nombre;
            private int Edad;

            public string Nombre1 { get => Nombre; set => Nombre = value; }
            public int Edad1 { get => Edad; set => Edad = value; }
        }

        
        //public delegate int OperacionesMatematicas(int num1, int num2);

        /*public static int Cuadrado(int num)
        {
            return num * num;
        }*/

        /*public static int Suma(int num1, int num2)
        {
            return num1+num2;
        }*/
    }
}
