using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4_Estructuras_Control
{
    public class BucleWhile
    {
        public BucleWhile() {
        
        }
        public void LeerNumeros() {
            Console.Title = "Utilizando la estructura WHILE";
            int contador = 1; 
            Double suma = 0; 
            int N; 
            Double prom; 
            while (contador <= 5)
            {
                Console.WriteLine("Ingrese un numero entero:[{0}] ", contador); 
                N = int.Parse(Console.ReadLine()); 
                suma = suma + N;
                contador = contador + 1;
            }
            Console.WriteLine("La suma de los 5 numeros ingresados es: " + suma); 
            prom = suma / 5;
            Console.WriteLine("El promedio de los numeros ingresados es: " + Math.Round(prom, 3));
            Console.ReadKey();
        }

        public void LeerNumerosDoWhile() {
            Console.Title = "Utilizando la estructura WHILE";
            int contador = 1;
            Double suma = 0;
            int N;
            Double prom;
            do
            {
                Console.WriteLine("Ingrese un numero entero:[{0}] ", contador);
                N = int.Parse(Console.ReadLine());
                suma = suma + N;
                contador = contador + 1;
            } while (contador <= 5);

            Console.WriteLine("La suma de los 5 numeros ingresados es: " + suma);
            prom = suma / 5;
            Console.WriteLine("El promedio de los numeros ingresados es: " + Math.Round(prom, 3));
            Console.ReadKey();
        }
    }
}

