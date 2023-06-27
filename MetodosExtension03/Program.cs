using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este programa muestra el uso de métodos de extensión

            // Extensión del int
            int numero = 25;

            bool par = numero.EsPar(); // AQUÍ ENCONTRAMOS LA EXTENSIÓN!!!

            Console.WriteLine("{0} es {1}", numero,par);

            // extensión del double
            double valor = 55.18;

            Console.WriteLine(valor.Dobletea());

            // Exgtensión ISaludador
            MiInt entero = new MiInt(7);
            entero.Sonido();
        }
    }
}
