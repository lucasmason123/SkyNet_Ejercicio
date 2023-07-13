using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DAL
{
    public class EliminadorDAL
    {

        private static List<Eliminador> eliminador = new List<Eliminador>();

        public void AgregarEliminador(Eliminador p)
        {
            eliminador.Add(p);
        }

        public List<Eliminador> ObtenerEliminador()
        {
            return eliminador;
        }

        public List<Eliminador> FiltrarEliminador(String numeroDeSerie)
        {
            List<Eliminador> filtrada = new List<Eliminador>();

            return eliminador.FindAll(p => p.NumeroDeSerie == numeroDeSerie);

        }
    }
}
