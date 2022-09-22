using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4_Estructuras_Control
{
    public class BucleFor
    {
        public BucleFor() { 
        }

        public void LeerNumeroFor() {
            Console.Title = "Utilizando la estructura FOR";
            int contador = 1;
            Double suma = 0;
            int N;
            Double prom;
            Console.WriteLine("Ingrese la cantidad de numeros a leer");
            int nRepetidor = int.Parse(Console.ReadLine());

            for (int i=1; i<= nRepetidor; i++)
            {
                Console.WriteLine("Ingrese un numero entero:[{0}] ", contador);
                N = int.Parse(Console.ReadLine());
                suma = suma + N;
                contador = contador + 1;
            }
            Console.WriteLine("La suma de los [{0}] numeros ingresados es: "+suma, nRepetidor);
            prom = suma / nRepetidor;
            Console.WriteLine("El promedio de los numeros ingresados es: " + Math.Round(prom, 3));
            Console.ReadKey();
        }

    }
}
