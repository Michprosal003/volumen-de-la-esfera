using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {

            // Inicializacion de variables al momentos de declararlas

            double radio, volumen, pi;

            volumen = 0.0;
            pi = 3.141592653589793;


            // Entrada de datos 
            Console.Title = "Volumen de una esfera";
            Console.WriteLine("Introduzca el valor del radio la esfera");




            radio = double.Parse(Console.ReadLine());

            // procesamiento de la informacion



            volumen=((4*pi)*(radio*radio*radio)/3);

            // Salida de la informacion

            Console.WriteLine(" El volumen de la esfera=  :" + volumen);

            Console.ReadKey();




        }
    }
}
