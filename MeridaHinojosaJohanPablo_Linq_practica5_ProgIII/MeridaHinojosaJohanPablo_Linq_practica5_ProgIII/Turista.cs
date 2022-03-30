using System;
using System.Collections.Generic;
using System.Text;

namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Turista
    {
        public int CI { get; set; }
        public string nomTurist { get; set; }
        public string CodTour { get; set; }
        public int CodPaquete { get; set; }


        public Turista(int CI, string nomTurist, string CodTour, int CodPaquete)
        {
            this.CI = CI;
            this.nomTurist = nomTurist;
            this.CodTour = CodTour;
            this.CodPaquete = CodPaquete;
        }
    }
}
