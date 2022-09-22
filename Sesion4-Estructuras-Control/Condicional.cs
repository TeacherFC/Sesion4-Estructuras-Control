using System;
public class Condicional
{
	public Condicional()
	{
	}
	public void CondicionalSimple()
	{
        /* Mi primer programa C#, para determinar si un numero es mayor a 12.
        */
        Console.WriteLine("Hello, World!");
        int nNumero = 0;
        int nNumero2 = 0;

        Console.WriteLine("Ingrese un numero1:");
        nNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero2:");
        nNumero2 = int.Parse(Console.ReadLine());

        if (nNumero > 12 || nNumero2 <12 )
        {
            Console.WriteLine("El numero 1 es mayor a 12");
            Console.WriteLine("La suma de ambos es: " + (nNumero + nNumero2));
        }
        else
        {
            Console.WriteLine("El numero 1 es menor o igual a 12");
            Console.WriteLine("La suma de ambos es: " + (nNumero + nNumero2));
        }
        Thread.Sleep(10000); //Espera 10 seg = 10000 Milisegundos
    }
    public void CondicionalMultiple()
    {
        //calcular si el numero ingresado pertenece a las unidades o decenas o centenas o miles
        Console.WriteLine("Ingrese el Numero a Evaluar:");
        int nNumero = int.Parse(Console.ReadLine());
        int nOrden = nNumero.ToString().Length;

        switch (nOrden)
        {
            case 1:
                Console.WriteLine("El Numero pertenece Orden de las unidades");
                break;
            case 2:
                Console.WriteLine("El Numero pertenece Orden de las Decenas");
                break;
            case 3:
                Console.WriteLine("El Numero pertenece Orden de las Centenas");
                break;
            case 4:
                Console.WriteLine("El Numero pertenece Orden de los miles");
                break;
            default :
                Console.WriteLine("El Numero es mayor al orden de los miles");
                break;
        }

    }

}
