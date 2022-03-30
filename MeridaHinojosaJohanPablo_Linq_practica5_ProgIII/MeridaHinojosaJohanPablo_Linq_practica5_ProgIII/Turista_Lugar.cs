using System;
using System.Collections.Generic;
using System.Text;

namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Turista_Lugar
    {
        public int CI { get; set; }
        public string IdLugar { get; set; }

        public Turista_Lugar(int CI, string IdLugar)
        {
            this.CI = CI;
            this.IdLugar = IdLugar;
        }
    }
}
