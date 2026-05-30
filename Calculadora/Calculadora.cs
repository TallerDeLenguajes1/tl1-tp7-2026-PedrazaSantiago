namespace EspacioCalculadora;

public class Calculadora
{
    private double dato = 0;
    public double Resultado
    {
        get => dato;
    }
    public void Sumar(double termino)
    {
        dato += termino;
    }

    public void Restar(double termino)
    {
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato /= termino;
        }
        else
        {
            Console.WriteLine("No se puede dividor por cero");
        }
    }

    public void Limpiar()
    {
        dato = 0;
    }
}