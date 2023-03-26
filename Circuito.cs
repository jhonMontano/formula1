namespace formula1;

public class Circuito
{
    private string nombre { get; set; }
    private int vueltas { get; set; }

    private Monoplaza monoplaza = null;
    private List<double> Tiempos = new List<double>();

    public Circuito(string nombre, int vueltas)
    {
        this.nombre = nombre;
        this.vueltas = vueltas;
    }


    public Monoplaza Monoplaza
    {
        get { return monoplaza; }
    }

    public void AgregarMonoplaza(Monoplaza newMonoplaza)
    {
        if (monoplaza == null)
        {
            monoplaza = newMonoplaza;
            Console.WriteLine("El nuevo monoplaza es: " + newMonoplaza);

        }
        else
        {
            Console.WriteLine("Ya hay un monoplaza en el circuito.");
        }
    }

    public void SacarMonoplaza()
    {
        if (monoplaza != null)
        {
            monoplaza = null;

            Console.WriteLine("Se ha retirado exitosamente!");
        }
        else
        {
            Console.WriteLine("No hay monoplaza en el circuito.");

        }
    }

    public void RealizarPrueba()
    {
        if (monoplaza == null)
        {
            Console.WriteLine("No hay monoplaza en el circuito.");
            return;
        }

        monoplaza.Encender();


        double TiempoVuelta = monoplaza.RealizarPrueba();


        Tiempos.Add(TiempoVuelta);


        monoplaza.Apagar();

        Console.WriteLine($"Mejor tiempo: {Tiempos.Min()}");
    }


    public void posiciones()
    {
        for (int i = 0; i < Tiempos.Count; i++)
        {

            Console.WriteLine(Tiempos[i]);
        }


    }
}
