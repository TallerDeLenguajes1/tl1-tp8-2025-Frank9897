using System;
using System.Collections.Generic;
using esOperacion;

namespace esCalculadora
{
    public class Calculadora
    {
        private double dato;
        private List<Operacion> historial;

        public Calculadora(double dato = 0)
        {
            this.dato = dato;
            historial = new List<Operacion>();
        }

        public double Resultado => dato;
        public List<Operacion> Historial => historial;

        public void Sumar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
            dato += termino;
        }

        public void Restar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No se puede hacer la operación con 0.");
            }
        }

        public void Limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }

        public void MostrarHistorial()
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("No hay operaciones registradas.");
                return;
            }

            Console.WriteLine("\n--- Historial de Operaciones ---");
            foreach (var op in historial)
            {
                Console.WriteLine($"{op.Tipo}: {op.ResultadoAnterior} con {op.NuevoValor} = {op.Resultado}");
            }
            Console.WriteLine("--------------------------------\n");
        }

    }
}
