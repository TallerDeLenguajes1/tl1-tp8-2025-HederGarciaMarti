namespace EspacioCalculadora;

public enum TipoOperacion
{
    Suma,
    Restar,
    Multiplicar,
    Dividir,
    Limpiar
}
public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public double NuevoValor
    {
        get
        {
            return nuevoValor;
        }
    }
    public double ResultadoAnterior
    {
        get
        {
            return resultadoAnterior;
        }
    }
    public TipoOperacion TipoOperacionOperacion {
        get
        {
            return operacion;
        }
    }

    public double Resultado()
    {
        switch (operacion)
        {
            case TipoOperacion.Suma:
                return resultadoAnterior + nuevoValor;
            case TipoOperacion.Restar:
                return resultadoAnterior - nuevoValor;
            case TipoOperacion.Multiplicar:
                return resultadoAnterior * nuevoValor;
            case TipoOperacion.Dividir:
                if (nuevoValor != 0)
                {
                    return resultadoAnterior / nuevoValor;
                }
                else
                {
                    return 0;
                }
            default:
                return 0;
        }
    }


}