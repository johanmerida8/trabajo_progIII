using System;
using System.Collections.Generic;
using System.Text;

namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Tour
    {
        public string CodTour { get; set; }
        public string NomTour { get; set; }
        public string Responsable { get; set; }

        public Tour(string CodTour, string NomTour, string Responsable)
        {
            this.CodTour = CodTour;
            this.NomTour = NomTour;
            this.Responsable = Responsable;
        }
    }
}
