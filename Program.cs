// // See https://aka.ms/new-console-template for more information

// using EspacioCalculadora;

// Calculadora miCalculadora = new Calculadora(0);

// int seguir = 0;

// do
// {
//     Console.WriteLine("Elija la opcion:");
//     Console.WriteLine("\n1.Sumar");
//     Console.WriteLine("2.Restar");
//     Console.WriteLine("3.Multiplicar");
//     Console.WriteLine("4.Dividir");
//     Console.WriteLine("5.Limpiar");
//     int opcion = int.Parse(Console.ReadLine());

//     Console.WriteLine("\nIngrese un numero");
//     double numero = float.Parse(Console.ReadLine());



//     switch (opcion)
//     {
//         case 1:
//             miCalculadora.Sumar(numero);
//             break;
//         case 2:
//             miCalculadora.Restar(numero);
//             break;
//         case 3:
//             miCalculadora.Multiplicar(numero);
//             break;
//         case 4:
//             miCalculadora.Dividir(numero);
//             break;
//         case 5:
//             miCalculadora.Limpiar();
//             break;
//         default:
//             Console.WriteLine("\nOpcion incorrecta");
//             break;
//     }

//     double rParcial = miCalculadora.Resultado;
//     Console.WriteLine("\nResultado parcial: " + rParcial);

//     Console.WriteLine("\nRealizar otra operacion? :  1. Si  2. No");
//     seguir = int.Parse(Console.ReadLine());


// } while (seguir == 1);

// double resultado = miCalculadora.Resultado;

// 

// -Ejercicio 2-

using System.IO.Pipes;
using EspacioEmpresa;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado
{
    Nombre = "Mario",
    Apellido = "Gomez",
    FechaNacimiento = new DateTime(1960, 2, 20),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(1999, 4, 12),
    Sueldo = 5000,
    Cargo = Empleado.Cargos.Ingeniero
};

empleados[1] = new Empleado
{
    Nombre = "Jose",
    Apellido = "Guerra",
    FechaNacimiento = new DateTime(1987, 5, 10),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(2009, 1, 22),
    Sueldo = 4500,
    Cargo = Empleado.Cargos.Especialista
};

empleados[2] = new Empleado
{
    Nombre = "Juana",
    Apellido = "Perez",
    FechaNacimiento = new DateTime(1999, 10, 1),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(2021, 8, 21),
    Sueldo = 4000,
    Cargo = Empleado.Cargos.Administrativo
};

Console.WriteLine("\nEMPLEADO 1\n");
empleados[0].MostrarEmpleado();

Console.WriteLine("\nEMPLEADO 2\n");
empleados[1].MostrarEmpleado();

Console.WriteLine("\nEMPLEADO 3\n");
empleados[2].MostrarEmpleado();

// Proximo a jubilarse

static void ProximoJubilado(Empleado[] empleados)
{
    int anos = empleados[0].AniosJubilacion();
    int indice = 0;

    for (int i = 0; i < 3; i++)
    {
        if (empleados[i].AniosJubilacion() < anos)
        {
            anos = empleados[i].AniosJubilacion();
            indice = i;
        }
    }

    Console.WriteLine("\n-Proximo empleado a jubilarse: \n");
    empleados[indice].MostrarEmpleado();
}

ProximoJubilado(empleados);