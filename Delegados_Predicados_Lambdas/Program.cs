using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_Predicados_Lambdas
{
    internal class Program
    {
        //Definicion del objeto delegado.
        delegate void objetoDelegado();
        static void Main(string[] args)
        {
            //Creacion del objeto delegado apuntando a MensajeWelcome.
            objetoDelegado bmw = new objetoDelegado(MensajeWelcome.SaludoBienvenida);

            //Utilizacion del delegado para llamar al metodo SaludoBienvenida.
            bmw();

            bmw = new objetoDelegado(MensajeDespedida.SaludoDespedida);

            bmw();

        }
    }
}
