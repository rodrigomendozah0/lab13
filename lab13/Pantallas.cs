using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class Pantallas
    {
        public static int[] DatosEncuestados = new int[100];
        public static int contador = 0;
        public static int PantallaPrincipal()
        {
            string texto1 = "================================\n" +
              "Encuestas de Calidad\n" +
              "================================\n" +
              "1: Realizar Encuesta\n" +
              "2: Ver datos registrados\n" +
              "3: Eliminar un dato\n" +
              "4: Ordenar datos de menor a mayor\n" +
              "5: Salir\n" +
              "================================\n";

            Console.Write(texto1);
            return Operaciones.getEntero("Ingrese una opción: ", texto1);
        }

        public static int EncuestaCovid()
        {
            string texto = "===================================\n" +
              "Nivel de Satisfacción\n" +
              "===================================\n" +
              "¿Qué tan satisfecho está con la\n" +
              "atención de nuestra tienda?\n" +
              "1: Nada satisfecho\n" +
              "2: No muy satisfecho\n" +
              "3: Tolerable\n" +
              "4: Satisfecho\n" +
              "5: Muy satisfecho\n" +
              "===================================\n";

            Console.Write(texto);
            int satisfaccion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if(satisfaccion <= 5 && satisfaccion > 0)
            {
                DatosEncuestados[contador] = satisfaccion;
                contador++;
                return NivelDeSatifaccion();
            }
            else
            {
                Console.Clear();
                return EncuestaCovid();
            }
        }

        public static int NivelDeSatifaccion()
        {
            string texto = "===================================\n" +
              "Nivel de Satisfacción\n" +
              "===================================\n" +
              "\n\n" +
              "¡Gracias por participar!\n" +
              "\n\n" +
              "===================================\n" +
              "Presione una tecla para\n" +
              "regresar al menú ...\n";

            Console.Clear();
            Console.Write(texto);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrincipal();
        }

        public static int DatosRegistrados()
        {
            string texto1 = "===================================\n" +
              "Ver datos registrados\n" +
              "===================================\n";
            Console.Write(texto1);

            if (contador == 0)
            {
                Console.WriteLine("No hay datos registrados");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.Write("[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = " \n" +
                "===================================\n" +
                "(1) = Nada satisfecho\n" +
                "(2) = No muy satisfecho\n" +
                "(3) = Tolerable\n" +
                "(4) = Satisfecho\n" +
                "(5) = Muy satisfecho\n" +
                "===================================\n";
            Console.Write(texto2);

            int[] ContarNiveles = new int[6];

            for (int i = 0; i < contador; i++)
            {
                int OPCION = DatosEncuestados[i];
                ContarNiveles[OPCION]++;
            }

            Console.Write("\n\n");
            for (int i = 1; i < ContarNiveles.Length; i++)
            {
                Console.WriteLine("(" + i + "): " + ContarNiveles[i] + " personas\t\t");
            }

            string texto3 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";
            Console.Write(texto3);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrincipal();
        }

        public static int EliminarDatos()
        {
            string texto = "===================================\n" +
              "Eliminar un dato\n" +
              "===================================\n\n";
            Console.Write(texto);

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto1 = "\n===================================\n" +
              "Ingrese la posición a eliminar: ";
            Console.Write(texto1);

            int posicion = int.Parse(Console.ReadLine());

            Console.Write("\n===================================\n");

            if (posicion >= 0 && posicion < DatosEncuestados.Length)
            {
                int i;
                for (i = posicion; i < contador - 1; i++)
                {
                    DatosEncuestados[i] = DatosEncuestados[i + 1];
                }
                contador = contador - 1;
            }
            else
            {
                Console.WriteLine("La posición ingresada no es válida.");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";
            Console.Write(texto2);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrincipal();
        }

        public static int OrdenarLosDatos()
        {
            string texto = "===================================\n" +
              "Ordenar datos\n" +
              "===================================\n";
            Console.Write(texto);

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = "\n===================================\n";
            Console.Write(texto2);

            int ordenado = 0;
            while (ordenado == 0)
                ordenado = 1;

            for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < contador - 1; j++)
                {
                    if (DatosEncuestados[j] > DatosEncuestados[j + 1])
                    {
                        int aux = DatosEncuestados[j + 1];
                        DatosEncuestados[j + 1] = DatosEncuestados[j];
                        DatosEncuestados[j] = aux;
                        ordenado = 0;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay datos registrados");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "]");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto3 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";

            Console.Write(texto3);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrincipal();
        }
    }
}
