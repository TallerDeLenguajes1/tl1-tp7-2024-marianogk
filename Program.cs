// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora(0);

int seguir = 0;

do
{
    Console.WriteLine("Elija la opcion:");
    Console.WriteLine("\n1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("5.Limpiar");
    int opcion = int.Parse(Console.ReadLine());

    Console.WriteLine("\nIngrese un numero");
    double numero = float.Parse(Console.ReadLine());



    switch (opcion)
    {
        case 1:
            miCalculadora.Sumar(numero);
            break;
        case 2:
            miCalculadora.Restar(numero);
            break;
        case 3:
            miCalculadora.Multiplicar(numero);
            break;
        case 4:
            miCalculadora.Dividir(numero);
            break;
        case 5:
            miCalculadora.Limpiar();
            break;
        default:
            Console.WriteLine("\nOpcion incorrecta");
            break;
    }

    double rParcial = miCalculadora.Resultado;
    Console.WriteLine("\nResultado parcial: " + rParcial);

    Console.WriteLine("\nRealizar otra operacion? :  1. Si  2. No");
    seguir = int.Parse(Console.ReadLine());


} while (seguir == 1);

double resultado = miCalculadora.Resultado;

Console.WriteLine("\nRESULTADO: " + resultado);