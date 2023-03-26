namespace formula1;

public abstract class Monoplaza : IMonoplaza
{
    public string Escuderia { get; set; }
    public bool Encendido { get; set; }
    public bool Detenido { get; set; }
    public int VueltasTotales { get; set; }
    public int VueltasRestantes { get; set; }
    public double MejorTiempo { get; set; }

    public Monoplaza(string escuderia, int vueltas)
    {
        Escuderia = escuderia;
        VueltasTotales = vueltas;
    }

    public void Encender()
    {
        if (!Encendido)
        {
            Encendido = true;
            Console.WriteLine($"El monoplaza de {Escuderia} ha sido encendido. ");
        }
    }

    public void Apagar()
    {
        if (Encendido && Detenido)
        {
            Encendido = false;
            Console.WriteLine($"El monoplaza de {Escuderia} ha sido apagado. ");
        }
    }

    public void Detener()
    {
        if (Encendido && !Detenido)
        {
            Detenido = true;
            Console.WriteLine($"El monoplaza de {Escuderia} ha sido detenido. ");
        }
    }

    public void Movimiento()
    {
        if (Encendido && Detenido)
        {
            Detenido = false;
            Console.WriteLine($"El monoplaza de {Escuderia} está en movimiento. ");
        }
    }

    public double RealizarPrueba()
    {
        if (!Encendido)
        {
            Encender();
        }

        VueltasRestantes = VueltasTotales;
        MejorTiempo = double.MaxValue;

        while (VueltasRestantes > 0)
        {
            double tiempo = GenerarTiempo();
            Console.WriteLine($"Tiempo de vuelta: {tiempo}");
            if (tiempo < MejorTiempo)
            {
                MejorTiempo = tiempo;
            }
            VueltasRestantes--;
        }

        Detener();
        Apagar();
        
        return MejorTiempo;
    }

    private static double GenerarTiempo()
    {
        Random random = new Random();
        return random.NextDouble() * 1000000;
    }
}

