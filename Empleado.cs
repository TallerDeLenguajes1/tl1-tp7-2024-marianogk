using Microsoft.VisualBasic;

namespace EspacioEmpresa;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldo;
    private Cargos cargo;

    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public void MostrarEmpleado()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Fecha de nacimiento: " + FechaNacimiento.ToShortDateString());
        Console.WriteLine("Estado civil: " + EstadoCivil);
        Console.WriteLine("Fecha de ingreso: " + FechaIngreso.ToShortDateString());
        Console.WriteLine("Sueldo: " + Sueldo);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Antiguedad: " + CalcularAntiguedad() + " años");
        Console.WriteLine("Edad: " + CalcularEdad() + " años");
        Console.WriteLine("Se jubila en: " + AniosJubilacion() + " años");
        Console.WriteLine("Total Salario: " + CalcularSalario());
    }

    public int CalcularAntiguedad()
    {
        return DateTime.Today.Year - FechaIngreso.Year;
    }

    public int CalcularEdad()
    {
        // Si ya cumplio este año
        if (DateTime.Today.Month < FechaNacimiento.Month && DateTime.Today.Day < FechaNacimiento.Day)
        {
            return DateTime.Today.Year - FechaNacimiento.Year - 1;
        }
        else
        {
            return DateTime.Today.Year - FechaNacimiento.Year;
        }
    }

    public int AniosJubilacion()
    {
        return 65 - CalcularEdad();

    }

    public double CalcularSalario()
    {
        double adicional = 0;

        if (CalcularAntiguedad() < 21)
        {
            adicional = Sueldo * CalcularAntiguedad() / 100;
        }
        else
        {
            adicional = Sueldo * 0.25;
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional += adicional * 0.5;
        }

        if (EstadoCivil == 'C')
        {
            adicional += 150000;
        }

        return Sueldo + adicional;
    }
}