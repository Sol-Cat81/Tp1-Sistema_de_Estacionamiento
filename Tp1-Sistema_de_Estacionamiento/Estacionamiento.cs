using System;
using System.Collections.Generic;

namespace Tp1_Sistema_de_Estacionamiento
{
    internal class Estacionamiento
    {
        private List<Vehiculo> vehiculos;

        public Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void MostrarVehiculos()
        {
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine("----------------------");
                v.MostrarDatos();
            }
        }
    }
}