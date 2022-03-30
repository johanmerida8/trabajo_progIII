using System;
using System.Collections.Generic;
using System.Text;

namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Lugar
    {
        public string CodLugar { get; set; }
        public string NomLugar { get; set; }
        public int Paquete { get; set; }
        public Lugar(string CodLugar, string NomLugar, int Paquete)
        {
            this.CodLugar = CodLugar;
            this.NomLugar = NomLugar;
            this.Paquete = Paquete;
        }
    }
}
