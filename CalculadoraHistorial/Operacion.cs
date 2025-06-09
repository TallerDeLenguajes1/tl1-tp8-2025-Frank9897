namespace esOperacion
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
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
        public double Resultado => operacion switch
        {
            TipoOperacion.Suma => resultadoAnterior + nuevoValor,
            TipoOperacion.Resta => resultadoAnterior - nuevoValor,
            TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
            TipoOperacion.Division => nuevoValor != 0 ? resultadoAnterior / nuevoValor : double.NaN,
            TipoOperacion.Limpiar => 0,
            _ => double.NaN
        };

        public double NuevoValor => nuevoValor;
        public TipoOperacion Tipo => operacion;
        public double ResultadoAnterior => resultadoAnterior;
    }
}
