using System;

namespace Tp1_Sistema_de_Estacionamiento
{
    internal class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(int cilindrada, string patente, double tiempoEstacionado)
            : base(patente, tiempoEstacionado)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularPago()
        {
            double horas = TiempoEstacionado / 60.0;

            double pago = horas * 5;

            if (Cilindrada > 250)
            {
                pago += 20;
            }

            return pago;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Tipo: Moto");
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
            Console.WriteLine($"Total a pagar: ${CalcularPago()}");
        }
    }
}