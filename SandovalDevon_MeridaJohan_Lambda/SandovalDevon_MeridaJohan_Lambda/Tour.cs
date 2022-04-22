using System;
using System.Collections.Generic;
using System.Text;

namespace SandovalDevon_MeridaJohan_Lambda
{
    class Tour
    {
        public string CodTour { get; set; }
        public string Nomtour { get; set; }
        public string Responsable { get; set; }

        public Tour(string Ctu,string Nt,string Res)
        {
            CodTour = Ctu;
            Nomtour = Nt;
            Responsable = Res;

        }
    }
}
