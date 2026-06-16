// Trabajo practico de a 2 personas
/*
 Crear un sistema de estacionamiento. El sistema debe registrar diferntes tipos de veiculos que ingresan ycalcular cuanto deben pagar
basandose en los minutos que estuvieron estacionados.
Estructura del sistema:
1. Vehiculos.cs (padre)
2. Auto.cs (Hijo)
3. Moto.cs (Hijo)
4. Estacionamiento.cs
5. Program.cs
Reglas del negocio:
- Todos los vehiculos tienen patente y minutos estacionados
- Las Patentes no pueden ser modificadas
- El auto tiene una tarifa fija de 10 dolares por hora. Si estuvo mas de 120 minutos un descuento del 10%
- Motos Una tarifa de 5 dolares por hora. Si la cilindrada es mayor a 250 se le va a cobrar 20 dolares extras
 */

using System;

namespace Tp1_Sistema_de_Estacionamiento
{
    internal class Program
    {
        static void Main()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            Auto auto1 = new Auto("ABC123", 180);

            Moto moto1 = new Moto(300, "XYZ456", 120);

            Moto moto2 = new Moto(150, "MNO789", 120);

            estacionamiento.AgregarVehiculo(auto1);
            estacionamiento.AgregarVehiculo(moto1);
            estacionamiento.AgregarVehiculo(moto2);

            estacionamiento.MostrarVehiculos();

            Console.ReadKey();
        }
    }
}