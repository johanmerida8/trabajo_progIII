using System;
using System.Collections.Generic;
using System.Text;

namespace SandovalDevon_MeridaJohan_Lambda
{
    class Turista
    {
        public int CI { get; set; }
        public string NomTurista { get; set; }
        public string CodTour { get; set; }

        public int CodPaquete { get; set; }

        public Turista(int ci , string Nt,string Ct,int Cp )
        {
            CI = ci;
            NomTurista = Nt;
            CodTour = Ct;
            CodPaquete = Cp;

         }
    }
}
