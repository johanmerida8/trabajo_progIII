using System;
using System.Collections.Generic;
using System.Text;

namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Paquete
    {
        public int CodPaquete { get; set; }
        public string NomPaquete { get; set; }


        public Paquete(int CodPaquete, string NomPaquete)
        {
            this.CodPaquete = CodPaquete;
            this.NomPaquete = NomPaquete;
        }
    }
}
