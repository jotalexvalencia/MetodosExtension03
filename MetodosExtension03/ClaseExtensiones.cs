using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension03
{
    // La clase donde se guardan las extensiones debe de ser estatica
    static class ClaseExtensiones
    {
        // El método que extiende debe de ser estático
        // El primer parámetro lleva this y representa al tipo que estamos extendiendo
       
        public static bool EsPar(this int i) 
        { 
            //    if(i%2 == 0) 
            //    return true;
            //else 
            //    return false;                                                                       

            bool SoyPar = (i%2==0);

            return SoyPar;
        }

        // Este extiende a un doble
        public static double Dobletea(this double d)
        {
            return d * 2.0;
        }

        // Este extiende solo a las clases que implementen ISaludador
        public static void Sonido(this ISaludador s)
        {
            Console.Beep();
        }
    }
}
