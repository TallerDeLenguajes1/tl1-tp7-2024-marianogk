namespace EspacioCalculadora;

public class Calculadora
{
    private double numero;

    public Calculadora(valorInicial)
    {
        numero=valorInicial;
    }


    public void Sumar(double termino) {
        numero += termino
    }  

    public void Restar(double termino) {
        numero -= termino
    }

    public void Multiplicar(double termino) {
        numero *= termino
    }

    public void Dividir(double termino) {
        numero /= termino
    }           

    public double resultado {get=> n1;}
}