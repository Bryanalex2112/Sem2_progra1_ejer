// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using semana2ejer.entidades;
using semana2ejer.negocio;

Numeros numeros = new Numeros();

ClsNumeros clsNumeros = new ClsNumeros();

Console.WriteLine("digite su primer numero");
numeros.Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite su segundo numero");
numeros.Num2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(clsNumeros.Res(numeros));



