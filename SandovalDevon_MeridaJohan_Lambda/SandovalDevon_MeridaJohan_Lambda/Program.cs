using System;
using System.Collections.Generic;
using System.Linq;

namespace SandovalDevon_MeridaJohan_Lambda
{
    class Program
    {
        delegate void mar();
        static void Main(string[] args)
        {

            //TuristandTour1();
            //lugarNomturistvisit2();
            //paqLugVisiPaq3();
            //turNomResTur4();
            //nomTurResTour5();
            //turLugVisitar6();
            //cantTurLugVisi7();
            //nomTurAgruNomPaq8();

            Turista[] turistas = {
             new Turista(123,"Elias Andrade","TA",4),
             new Turista(234,"Moira Alen","TA",2),
             new Turista(345,"Lony Labbe","TG",8),
             new Turista(456,"Sidney Sommer","TA",3),
             new Turista(567,"Ari Hass","TG",8),
             new Turista(678,"Rita Asis","TC",5),
             new Turista(789,"Marco Esteves","TA",3),
             new Turista(890,"Julia Lang","TG",6),
             new Turista(901,"Ingrid RamosAsis","TC",5)};

            Tour[] excursiones = {
             new Tour("TA","Turismo Aventura","Magic Tours"),
             new Tour("TG","Turismo Gastronómico","Turismo Kronos"),
             new Tour("TC","Turismo Compras","Eva's Tours Co."),
             new Tour("TP","Turismo Paseos","Alex Tours")};

            Lugar[] lugares = {
             new Lugar("PV","Puerto Varas",4),
             new Lugar("BRLCH","Bariloche",3),
             new Lugar("BRA","Rio de Janeiro",3),
             new Lugar("CHLT","Chalten",1),
             new Lugar("PA","Punta Arenas",5),
             new Lugar("PN","Puerto Natales",8),
             new Lugar("VAL","Valdivia",6),
             new Lugar("BA","Buenos Aires",2),
             new Lugar("SP","San Pablo",1),
             new Lugar("FLO","Florianópolis",2)
             };

            Turista_Lugar[] turista_visita = {
                 new Turista_Lugar(123,"BRLCH"),
                 new Turista_Lugar(123,"PV"),
                 new Turista_Lugar(123,"BRA"),
                 new Turista_Lugar(123,"FLO"),
                 new Turista_Lugar(234,"SP"),
                 new Turista_Lugar(234,"BA"),
                 new Turista_Lugar(345,"PN"),
                 new Turista_Lugar(345,"VAL"),
                 new Turista_Lugar(456,"BRA"),
                 new Turista_Lugar(456,"BA"),
                 new Turista_Lugar(567,"PN"),
                 new Turista_Lugar(678,"PA"),
                 new Turista_Lugar(678,"PV"),
                 new Turista_Lugar(789,"BRA"),
                 new Turista_Lugar(789,"SP"),
                 new Turista_Lugar(789,"FLO"),
                 new Turista_Lugar(890,"VAL"),
                 new Turista_Lugar(890,"BRLCH"),
                 new Turista_Lugar(901,"PA"),
                 new Turista_Lugar(012,"CHLT")};

            Paquete[] paquetes = {
                 new Paquete(1,"Básico"),
                 new Paquete(2,"Económico"),
                 new Paquete(3,"Estandar"),
                 new Paquete(4,"Jubilados"),
                 new Paquete(5,"Familiar"),
                 new Paquete(6,"Todo incluido"),
                 new Paquete(7,"Extra"),
                 new Paquete(8,"Vip") };

        }




        //ejericio1
        static void TuristandTour1()
        {
            Turista[] turistas = {
             new Turista(123,"Elias Andrade","TA",4),
             new Turista(234,"Moira Alen","TA",2),
             new Turista(345,"Lony Labbe","TG",8),
             new Turista(456,"Sidney Sommer","TA",3),
             new Turista(567,"Ari Hass","TG",8),
             new Turista(678,"Rita Asis","TC",5),
             new Turista(789,"Marco Esteves","TA",3),
             new Turista(890,"Julia Lang","TG",6),
             new Turista(901,"Ingrid RamosAsis","TC",5)};

            Tour[] excursiones = {
             new Tour("TA","Turismo Aventura","Magic Tours"),
             new Tour("TG","Turismo Gastronómico","Turismo Kronos"),
             new Tour("TC","Turismo Compras","Eva's Tours Co."),
             new Tour("TP","Turismo Paseos","Alex Tours")};

            var Oden1 = excursiones.Join(turistas, ex => ex.CodTour, tur => tur.CodTour, 
                (ex, tur) => new { excurcion = ex, turista = tur }).GroupBy(x => x.excurcion.Nomtour);
                
                
               


            foreach (var sitio in Oden1)
            {
                Console.WriteLine("Turistas agrupados en: " + sitio.Key);
                foreach (var sitios in sitio)
                    Console.WriteLine(" " + sitios.turista.NomTurista);
                Console.WriteLine();
            }

        }

        //ejericio2
        static void lugarNomturistvisit2()
        {
            Lugar[] lugares = {
             new Lugar("PV","Puerto Varas",4),
             new Lugar("BRLCH","Bariloche",3),
             new Lugar("BRA","Rio de Janeiro",3),
             new Lugar("CHLT","Chalten",1),
             new Lugar("PA","Punta Arenas",5),
             new Lugar("PN","Puerto Natales",8),
             new Lugar("VAL","Valdivia",6),
             new Lugar("BA","Buenos Aires",2),
             new Lugar("SP","San Pablo",1),
             new Lugar("FLO","Florianópolis",2)
             };
            

            Turista[] turistas = {
             new Turista(123,"Elias Andrade","TA",4),
             new Turista(234,"Moira Alen","TA",2),
             new Turista(345,"Lony Labbe","TG",8),
             new Turista(456,"Sidney Sommer","TA",3),
             new Turista(567,"Ari Hass","TG",8),
             new Turista(678,"Rita Asis","TC",5),
             new Turista(789,"Marco Esteves","TA",3),
             new Turista(890,"Julia Lang","TG",6),
             new Turista(901,"Ingrid RamosAsis","TC",5)};

            Console.WriteLine("Agrega el nombre de un lugar");

            string namePlace = Console.ReadLine().ToUpper();

            var visit = lugares.Join(turistas, l => l.Paquete, t => t.CodPaquete, 
                (l, t) => new { place = l, turist = t }).GroupBy
                (x => x.place.NomLugar).Where(aux => aux.Key.ToUpper() == namePlace);
                        
            foreach (var lugar in visit)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Lugar Visita: " + lugar.Key);

                foreach (var l in lugar)

                    Console.WriteLine("- " + l.turist.NomTurista);

            }


        }

        //ejericio3
        static void paqLugVisiPaq3()
        {

            Paquete[] paquetes = {
                 new Paquete(1,"Básico"),
                 new Paquete(2,"Económico"),
                 new Paquete(3,"Estandar"),
                 new Paquete(4,"Jubilados"),
                 new Paquete(5,"Familiar"),
                 new Paquete(6,"Todo incluido"),
                 new Paquete(7,"Extra"),
                 new Paquete(8,"Vip") };

            Lugar[] lugares = {
                 new Lugar("PV","Puerto Varas",4),
                 new Lugar("BRLCH","Bariloche",3),
                 new Lugar("BRA","Rio de Janeiro",3),
                 new Lugar("CHLT","Chalten",1),
                 new Lugar("PA","Punta Arenas",5),
                 new Lugar("PN","Puerto Natales",8),
                 new Lugar("VAL","Valdivia",6),
                 new Lugar("BA","Buenos Aires",2),
                 new Lugar("SP","San Pablo",1),
                 new Lugar("FLO","Florianópolis",2)
                 };

            Console.WriteLine("Ingresa el nombre del paquete");
            string namePackage = Console.ReadLine().ToUpper();

            var paq = paquetes.Join(lugares, pk => pk.CodPaquete, lu => lu.Paquete, 
                (pk, lu) => new { package = pk, lugar = lu }).GroupBy
                (x => x.package.NomPaquete).Where(aux => aux.Key.ToUpper() == namePackage);
                      
            foreach (var lu in paq)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("=> Nombre del paquete: " + lu.Key);
                foreach (var j in lu)

                    Console.WriteLine("- Lugares visitados: " + j.lugar.NomLugar);
                    Console.WriteLine();

            }




        }

        //ejercicio4
        static void turNomResTur4()
        {
            Turista[] turistas = {
                new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),
                new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),
                new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5),
                new Turista(012,"Erick Kolbe","TP",1),};

            Tour[] excursiones = {
                new Tour("TA","Turismo Aventura","Magic Tours"),
                new Tour("TG","Turismo Gastronómico","Turismo Kronos"),
                new Tour("TC","Turismo Compras","Eva's Tours Co."),
                new Tour("TP","Turismo Paseos","Alex Tours")};

            Console.WriteLine("Agrega un nombre de un turista");
            string nResp = Console.ReadLine().ToUpper();

            var tour = excursiones.Join(turistas, e => e.CodTour, t => t.CodTour, 
                (e, t) => new { excursion = e, turist = t }).GroupBy
                (x => x.turist.NomTurista).Where(aux => aux.Key.ToUpper() == nResp);
            foreach (var i in tour)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Nombre del turista: ");
                Console.WriteLine(" - " + i.Key);
                foreach (var j in i)


                    Console.WriteLine("Responsable del tour: " + j.excursion.Responsable);

            }
        }

        //ejercicio5
        static void nomTurResTour5()
        {
            Turista[] turistas = {
                 new Turista(123,"Elias Andrade","TA",4),
                 new Turista(234,"Moira Alen","TA",2),
                 new Turista(345,"Lony Labbe","TG",8),
                 new Turista(456,"Sidney Sommer","TA",3),
                 new Turista(567,"Ari Hass","TG",8),
                 new Turista(678,"Rita Asis","TC",5),
                 new Turista(789,"Marco Esteves","TA",3),
                 new Turista(890,"Julia Lang","TG",6),
                 new Turista(901,"Ingrid RamosAsis","TC",5),
                 new Turista(012,"Erick Kolbe","TP",1),};

            Tour[] excursiones = {
                 new Tour("TA","Turismo Aventura","Magic Tours"),
                 new Tour("TG","Turismo Gastronómico","Turismo Kronos"),
                 new Tour("TC","Turismo Compras","Eva's Tours Co."),
                 new Tour("TP","Turismo Paseos","Alex Tours")};

            var tour = turistas.Join(excursiones, t => t.CodTour, e => e.CodTour, 
                (t, e) => new { turist = t, excursion = e }).GroupBy(x => x.excursion.CodTour);

            foreach (var i in tour)
            {

                foreach (var name in i)

                    Console.WriteLine("Turista: " + name.turist.NomTurista + " |" + "Responsable: " + name.excursion.Responsable);
                Console.WriteLine();

            }
        }

        //ejercicio6
        static void turLugVisitar6()
        {
            Turista_Lugar[] turista_visita = { new Turista_Lugar(123, "BRLCH"),
                new Turista_Lugar(123, "PV"),
                new Turista_Lugar(123, "BRA"),
                new Turista_Lugar(123, "FLO"),
                new Turista_Lugar(234, "SP"),
                new Turista_Lugar(234, "BA"),
                new Turista_Lugar(345, "PN"),
                new Turista_Lugar(345, "VAL"),
                new Turista_Lugar(456, "BRA"),
                new Turista_Lugar(456, "BA"),
                new Turista_Lugar(567, "PN"),
                new Turista_Lugar(678, "PA"),
                new Turista_Lugar(678, "PV"),
                new Turista_Lugar(789, "BRA"),
                new Turista_Lugar(789, "SP"),
                new Turista_Lugar(789, "FLO"),
                new Turista_Lugar(890, "VAL"),
                new Turista_Lugar(890, "BRLCH"),
                new Turista_Lugar(901, "PA"),
                new Turista_Lugar(012, "CHLT") };

            Turista[] turistas = { new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),
                new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),
                new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5)};

            Lugar[] lugares = {
                 new Lugar("PV","Puerto Varas",4),
                 new Lugar("BRLCH","Bariloche",3),
                 new Lugar("BRA","Rio de Janeiro",3),
                 new Lugar("CHLT","Chalten",1),
                 new Lugar("PA","Punta Arenas",5),
                 new Lugar("PN","Puerto Natales",8),
                 new Lugar("VAL","Valdivia",6),
                 new Lugar("BA","Buenos Aires",2),
                 new Lugar("SP","San Pablo",1),
                 new Lugar("FLO","Florianópolis",2)
                 };





            var tour = turistas.Join(turista_visita, tur => tur.CI, visi => visi.Ci, 
                (tur, visi) => new { turist = tur, turista_visita = visi }).Join
                (lugares, q => q.turista_visita.idLugar, cl => cl.CodLugar, (q, cl) => 
                new { q.turist, q.turista_visita, lugares = cl }).GroupBy(y => y.lugares.NomLugar);

            //var igual = tour == tourvisita;
            foreach (var i in tour)
            {
                Console.WriteLine("Nombre lugar: " + i.Key);
                foreach (var j in i)

                    Console.WriteLine("Turista: " + j.turist.NomTurista);


            }
        }

        //ejercicio7
        static void cantTurLugVisi7()
        {
            Turista_Lugar[] turista_visita = { new Turista_Lugar(123, "BRLCH"),
                new Turista_Lugar(123, "PV"),
                new Turista_Lugar(123, "BRA"),
                new Turista_Lugar(123, "FLO"),
                new Turista_Lugar(234, "SP"),
                new Turista_Lugar(234, "BA"),
                new Turista_Lugar(345, "PN"),
                new Turista_Lugar(345, "VAL"),
                new Turista_Lugar(456, "BRA"),
                new Turista_Lugar(456, "BA"),
                new Turista_Lugar(567, "PN"),
                new Turista_Lugar(678, "PA"),
                new Turista_Lugar(678, "PV"),
                new Turista_Lugar(789, "BRA"),
                new Turista_Lugar(789, "SP"),
                new Turista_Lugar(789, "FLO"),
                new Turista_Lugar(890, "VAL"),
                new Turista_Lugar(890, "BRLCH"),
                new Turista_Lugar(901, "PA"),
                new Turista_Lugar(012, "CHLT") };

            Turista[] turistas = { new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),
                new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),
                new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5)};

            Lugar[] lugares = {
                 new Lugar("PV","Puerto Varas",4),
                 new Lugar("BRLCH","Bariloche",3),
                 new Lugar("BRA","Rio de Janeiro",3),
                 new Lugar("CHLT","Chalten",1),
                 new Lugar("PA","Punta Arenas",5),
                 new Lugar("PN","Puerto Natales",8),
                 new Lugar("VAL","Valdivia",6),
                 new Lugar("BA","Buenos Aires",2),
                 new Lugar("SP","San Pablo",1),
                 new Lugar("FLO","Florianópolis",2)
                 };


            var tour = turista_visita.Join(turistas, visi => visi.Ci, tur => tur.CI, 
                (visi, tur) => new { turista_visita = visi, turista = tur }).Join
                (lugares, q => q.turista_visita.idLugar, cl => cl.CodLugar, (q, cl) => 
                new { q.turista, q.turista_visita, lugares = cl }).GroupBy(y => y.lugares.NomLugar);


            
            //var igual = tour == tourvisita;
            foreach (var v in tour)
            {
                
                Console.WriteLine("Nombre lugar: " + v.Key);
                Console.WriteLine("Cantidad de Turistas: " + v.Count());
                
                    


            }
        }

        //ejercicio8
        static void nomTurAgruNomPaq8()
        {
            Paquete[] paquetes = {
                 new Paquete(1,"Básico"),
                 new Paquete(2,"Económico"),
                 new Paquete(3,"Estandar"),
                 new Paquete(4,"Jubilados"),
                 new Paquete(5,"Familiar"),
                 new Paquete(6,"Todo incluido"),
                 new Paquete(7,"Extra"),
                 new Paquete(8,"Vip") };

            Turista[] turistas = { new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),
                new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),
                new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5)};



            var agrupa = paquetes.Join(turistas, pk => pk.CodPaquete, t => t.CodPaquete, (pk, t) => new { package = pk, turist = t }).GroupBy(y => y.package.NomPaquete);

            foreach(var t in agrupa)
            {
                Console.WriteLine("Nombre de turista agrupado " + t.Key);

                foreach (var tur in t)
                    Console.WriteLine(" - " + tur.turist.NomTurista);
            }
        }


    }

}
