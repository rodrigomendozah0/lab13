using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.PantallaPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.EncuestaCovid();
                        break;
                    case 2:
                        opcion = Pantallas.DatosRegistrados();
                        break;
                    case 3:
                        opcion = Pantallas.EliminarDatos();
                        break;
                    case 4:
                        opcion = Pantallas.OrdenarLosDatos();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.PantallaPrincipal();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
