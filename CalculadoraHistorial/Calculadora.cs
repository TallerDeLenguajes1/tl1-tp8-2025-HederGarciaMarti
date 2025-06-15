namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public List<Operacion> Operaciones { get; set; } = new List<Operacion>();

        public Calculadora()
        {
            dato = 0;
        }
        public double Resultado
        {
            get
            {
                return dato;
            }
        }
         public void Sumar(double termino)
        {
            Operacion operacion = new Operacion(dato, termino, TipoOperacion.Suma);
            dato = dato + termino;
            Operaciones.Add(operacion);
        }

        public void Restar(double termino)
        {
            var operacion = new Operacion(dato, termino, TipoOperacion.Restar);
            dato = dato - termino;
            Operaciones.Add(operacion);
        }

        public void Multiplicar(double termino)
        {
            var operacion = new Operacion(dato, termino, TipoOperacion.Multiplicar);
            dato = dato * termino;
            Operaciones.Add(operacion);
        }
         public void Dividir(double termino)
        {
            if (termino != 0)
            {
                var operacion = new Operacion(dato, termino, TipoOperacion.Dividir);
                dato = dato / termino;
                Operaciones.Add(operacion);
            }
            else
            {
                dato = -9999;
            }
        }

        public void Limpiar()
        {
            dato = 0;
        }

    }
}