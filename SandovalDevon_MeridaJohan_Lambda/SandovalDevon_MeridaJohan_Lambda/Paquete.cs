using System;
using System.Collections.Generic;
using System.Text;

namespace SandovalDevon_MeridaJohan_Lambda
{
    class Paquete
    {
        public int CodPaquete { get; set; }
        public string NomPaquete { get; set; }
    
        public Paquete(int Cp,string Np)
        {
            CodPaquete = Cp;
            NomPaquete = Np;
        }

    
    }
}
