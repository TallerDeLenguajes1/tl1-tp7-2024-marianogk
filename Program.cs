// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora(0);

double resultado = miCalculadora.Resultado;

miCalculadora.Sumar(10);
miCalculadora.Restar(5);
miCalculadora.Multiplicar(6);
miCalculadora.Dividir(3);

Console.WriteLine("Suma: "+resultado);