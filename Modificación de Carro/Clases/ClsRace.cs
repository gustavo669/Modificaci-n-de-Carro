using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificación_de_Carro.Clases
{
    internal class ClsRace
    {
        private Carro CarroA;
        private Carro CarroB;
        private Carro CarroC;


        public void PedirDatosCarrera()
        {

            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
            Console.WriteLine("Ahora datos del C");
            CarroC = GetData();
        }

        public void IniciarCarrera()
        {
            IniciarCarrera(CarroA);
        }

        public void IniciarCarrera(Carro carroA)
        {
            string msgCarroA, msgCarroB, msgCarroC;

            Random velRandom = new Random();

            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            msgCarroC = CarroC.EncenderMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($">{CarroC.Marca} {msgCarroC}");


            for (int i = 0; i < 10; i++)
            {
                int acelera;
                acelera = velRandom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelera);


                Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB} {CarroC.owner}:{msgCarroC}");

            }

            if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual())
            {
                Console.WriteLine($"{CarroA.owner} Wins!!!");
            }
            else
            {
                Console.WriteLine($"{CarroB.owner} Wins!!!");
            }

            if (CarroC.GetVelocidadActual() > CarroA.GetVelocidadActual())
            {
                Console.WriteLine($"{CarroC.owner} Wins!!!");
            }
            else
            {
                Console.WriteLine($"{CarroA.owner} Wins!!!");
            }
        }


        private Carro GetData()
        {
            string marca;
            int modelo;
            int velocidad;
            string propietario;
            Carro carroTemporal;


            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();

            Console.WriteLine("ingrese modelo");
            modelo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese velocidad max");
            velocidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Propietario:");
            propietario = Console.ReadLine();
            carroTemporal = new Carro(marca, modelo, velocidad, propietario);
            return carroTemporal;
        }
    }
}