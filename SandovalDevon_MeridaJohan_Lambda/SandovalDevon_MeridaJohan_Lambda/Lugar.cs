using System;
using System.Collections.Generic;
using System.Text;

namespace SandovalDevon_MeridaJohan_Lambda
{
    class Lugar
    {
        public string CodLugar { get; set; }
        public string NomLugar { get; set; }
        public int Paquete { get; set; }
    
    public Lugar(string Cl ,string Nl ,int p)
        {
            CodLugar = Cl;
            NomLugar = Nl;
            Paquete = p;
        }
    
    }
}
