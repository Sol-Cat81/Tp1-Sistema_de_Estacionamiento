using System;

namespace Tp1_Sistema_de_Estacionamiento
{
    internal abstract class Vehiculo
    {
        public string Patente { get; }

        public double TiempoEstacionado { get; set; }

        public Vehiculo(string patente, double tiempoEstacionado)
        {
            Patente = patente;
            TiempoEstacionado = tiempoEstacionado;
        }

        // Método que cada hijo deberá implementar
        public abstract double CalcularPago();

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Patente: {Patente}");
            Console.WriteLine($"Tiempo estacionado: {TiempoEstacionado} minutos");
        }
    }
}