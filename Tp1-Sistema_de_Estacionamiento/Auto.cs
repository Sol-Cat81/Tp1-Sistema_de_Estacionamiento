using System;

namespace Tp1_Sistema_de_Estacionamiento
{
    internal class Auto : Vehiculo
    {
        public Auto(string patente, double tiempoEstacionado)
            : base(patente, tiempoEstacionado)
        {
        }

        public override double CalcularPago()
        {
            double horas = TiempoEstacionado / 60.0;

            double pago = horas * 10;

            // Descuento del 10% si supera los 120 minutos
            if (TiempoEstacionado > 120)
            {
                pago = pago * 0.90;
            }

            return pago;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Tipo: Auto");
            Console.WriteLine($"Total a pagar: ${CalcularPago()}");
        }
    }
}