namespace formula1;

public interface IMonoplaza
{
    string Escuderia { get;set;}
    bool Encendido { get;set; }
    bool Detenido { get;set; }
    void Encender();
    void Apagar();
    void Detener();
    void Movimiento();
}
