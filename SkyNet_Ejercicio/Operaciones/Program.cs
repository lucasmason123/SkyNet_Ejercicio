using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.DAL;

namespace SkyNet_Ejercicio
{
    public partial class Program
    {
        static void IngresarEliminador()
        {
            String numeroDeSerie;
            String tipo;
            int prioridadBase;
            String objetivo;
            Int32 añoDestino;
            Boolean validador;

            Console.WriteLine(" Bienvenido a SkyNet");

            do
            {
                Console.WriteLine("Ingrese Numero de Serie del Eliminador (7 Caracteres)");
                numeroDeSerie = Console.ReadLine().Trim().ToUpper();
            } while (numeroDeSerie.Equals(string.Empty) || numeroDeSerie.Length != 7);

            do
            {
                Console.WriteLine("Ingrese un tipo de Eliminador");
                Console.WriteLine("a)T-1");
                Console.WriteLine("b)T-800");
                Console.WriteLine("c)T-1000");
                Console.WriteLine("d)T-3000");
                tipo = Console.ReadLine().Trim().ToLower();
                if (tipo != ("a") && tipo != ("b") && tipo != ("c") && tipo != ("d"))
                {
                    validador = false;
                }
                else
                {
                    validador = true;
                    switch (tipo)
                    {
                        case "a":
                            tipo = "T-1";
                            break;
                        case "b":
                            tipo = "T-800";
                            break;
                        case "c":
                            tipo = "T-1000";
                            break;
                        case "d":
                            tipo = "T-3000";
                            break;
                    }
                }

            } while (validador != true);

            do
            {
                Console.WriteLine("Ingrese prioridad base del Objetivo ( Entre 1 y 5)");
                validador = int.TryParse(Console.ReadLine().Trim(), out prioridadBase);

            } while (!validador || (prioridadBase < 1 || prioridadBase > 5));

            do
            {
                Console.WriteLine("Ingrese objetivo del Eliminador");
                objetivo = Console.ReadLine().Trim().ToUpper();


                List<Eliminador> filtradas = new EliminadorDAL().FiltrarEliminador(objetivo);
                filtradas.ForEach(eliminador => prioridadBase = 999);

            } while (objetivo.Equals(string.Empty));

            do
            {
                Console.WriteLine("Ingrese Año de destino del Eliminador (Entre 1997 y 3000)");
                validador = Int32.TryParse(Console.ReadLine().Trim(), out añoDestino);
            } while (!validador || añoDestino < 1997 || añoDestino > 3000);


            Eliminador e = new Eliminador()
            {
                NumeroDeSerie = numeroDeSerie,
                Tipo = tipo,
                PrioridadBase = prioridadBase,
                Objetivo = objetivo,
                AñoDestino = añoDestino
            };

            new EliminadorDAL().AgregarEliminador(e);

            Console.WriteLine("Numero de serie: {0}", e.NumeroDeSerie);
            Console.WriteLine("Tipo: {0}", e.Tipo);
            Console.WriteLine("Prioridad: {0}", e.PrioridadBase);
            Console.WriteLine("Objetivo: {0}", e.Objetivo);
            Console.WriteLine("Año de destino: {0}", e.AñoDestino);

        }
        static void MostrarEliminador()
        {
            List<Eliminador> eliminador = new EliminadorDAL().ObtenerEliminador();
            for (int i = 0; i < eliminador.Count(); i++)
            {
                Eliminador actual = eliminador[i];
                Console.WriteLine("{0}: Numero de serie: {1} Tipo: {2} Objetivo: {3}", i, actual.NumeroDeSerie, actual.Tipo, actual.Objetivo);
            }
        }


        static void BuscarEliminador()

        {
            Console.WriteLine("Ingrese un numero de Serie");
            List<Eliminador> filtradas = new EliminadorDAL().FiltrarEliminador(Console.ReadLine().Trim().ToUpper());
            filtradas.ForEach(e => Console.WriteLine("Numero de serie: {0} Tipo: {1} Objetivo: {2}", e.NumeroDeSerie, e.Tipo, e.Objetivo));
        }
    }
}
