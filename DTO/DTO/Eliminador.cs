using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Eliminador
    {
        private String numeroDeSerie;
        private String tipo;
        private int prioridadBase;
        private String objetivo;
        private Int32 añoDestino;

        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int PrioridadBase { get => prioridadBase; set => prioridadBase = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int AñoDestino { get => añoDestino; set => añoDestino = value; }
    }
}
