// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int nNumero = 0;
Console.WriteLine("Ingrese un numero:");
nNumero = int.Parse(Console.ReadLine());

if (nNumero > 12)
    Console.WriteLine("El numero es mayor a 12");
else
    Console.WriteLine("El numero es menor o igual a 12");

Thread.Sleep(10000); //Espera 10 seg = 10000 Milisegundos
