using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String txt = "cursos@pildorasinformaticas.es";

            String re1 = ".*?";//Non-greedy match on filler
            String re2 = "(@)";//Any single character 1
            String re3 = ".*?";//Non-greedy match on filler
            String re4 = "(\\.)";//Any single character 2

            Regex r = new Regex(re1+re2+re3+re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);

            if (m.Success) 
            {

                Console.WriteLine("Email correcto");
                /*String c1 = m.Groups[1].ToString();
                   String c2 = m.Groups[2].ToString();
                   Console.WriteLine("(" + c1.ToString() + ")" + "(" + c2.ToString() + ")" + "\n");*/
            }
            else 
            {
                Console.WriteLine("Email no correcto");
            }



            //String frase = "Mi web es https://www.pildorasinformaticas.es";
            //String frase = "Mi nombre es David Crr24j Cll40Nor 123 INT 102 TEL: (+54)345-67-89 cel: (+34)643-12-32";

            //String patron = @"https://(www.)?pildorasinformaticas.es";
            //String patron = @"\+34|\+54";//numeros de telefonos.
            //String patron = @"\d{3}-";//buscando bloques de 3 numeros.
            //String patron = @"[D]";//buscando D mayuscula.

            //Regex mirex = new Regex(patron);

            //MatchCollection elmatch = mirex.Matches(frase);

            /*if (elmatch.Count > 0) Console.WriteLine("se ha encontrado una D");
            else Console.WriteLine("no se ha encontrado D");*/

            /*if (elmatch.Count > 0) Console.WriteLine("se ha encontrado numeros ");
            else Console.WriteLine("no se ha encontrado numeros ");*/

            /*if (elmatch.Count > 0) Console.WriteLine("se ha encontrado numeros de telefonos ");
            else Console.WriteLine("no se ha encontrado numeros de telefonos ");*/

            /*if (elmatch.Count > 0) Console.WriteLine("se ha encontrado web ");
            else Console.WriteLine("no se ha encontrado web ");*/
        }
    }
}
