using System;
using System.Collections.Generic; // ****************** AUMENTAR PARA COMPILAR INSTRUCCIONES LINQ
using System.Linq; // ****************** AUMENTAR PARA COMPILAR INSTRUCCIONES LINQ


namespace MeridaHinojosaJohanPablo_Linq_practica5_ProgIII
{
    class Program
    {


        Turista[] turistas = { new Turista(123, "Elias Andrade", "TA", 4), new Turista(234, "Moira Alen", "TA", 2), new Turista(345, "Lony Labbe", "TG", 8), new Turista(456, "Sidney Sommer", "TA", 3), new Turista(567, "Ari Hass", "TG", 8), new Turista(678, "Rita Asis", "TC", 5), new Turista(789, "Marco Esteves", "TA", 3), new Turista(890, "Julia Lang", "TG", 6), new Turista(901, "Ingrid RamosAsis", "TC", 5), new Turista(012, "Erick Kolbe", "TP", 1) };
        Tour[] excursiones = { new Tour("TA", "Turismo Aventura", "Magic Tours"), new Tour("TG", "Turismo Gastronómico", "Turismo Kronos"), new Tour("TC", "Turismo Compras", "Eva's Tours Co."), new Tour("TP", "Turismo Paseos", "Alex Tours") };
        Lugar[] lugares = { new Lugar("PV", "Puerto Varas", 4), new Lugar("BRLCH", "Bariloche", 3), new Lugar("BRA", "Rio de Janeiro", 3), new Lugar("CHLT", "Chalten", 1), new Lugar("PA", "Punta Arenas", 5), new Lugar("PN", "Puerto Natales", 8), new Lugar("VAL", "Valdivia", 6), new Lugar("BA", "Buenos Aires", 2), new Lugar("SP", "San Pablo", 1), new Lugar("FLO", "Florianópolis", 2) };
        Turista_Lugar[] turista_visita = { new Turista_Lugar(123, "BRLCH"), new Turista_Lugar(123, "PV"), new Turista_Lugar(123, "BRA"), new Turista_Lugar(123, "FLO"), new Turista_Lugar(234, "SP"), new Turista_Lugar(234, "BA"), new Turista_Lugar(345, "PN"), new Turista_Lugar(345, "VAL"), new Turista_Lugar(456, "BRA"), new Turista_Lugar(456, "BA"), new Turista_Lugar(567, "PN"), new Turista_Lugar(678, "PA"), new Turista_Lugar(678, "PV"), new Turista_Lugar(789, "BRA"), new Turista_Lugar(789, "SP"), new Turista_Lugar(789, "FLO"), new Turista_Lugar(890, "VAL"), new Turista_Lugar(890, "BRLCH"), new Turista_Lugar(901, "PA"), new Turista_Lugar(012, "CHLT") };
        Paquete[] paquetes = { new Paquete(1, "Básico"), new Paquete(2, "Económico"), new Paquete(3, "Estandar"), new Paquete(4, "Jubilados"), new Paquete(5, "Familiar"), new Paquete(6, "Todo incluido"), new Paquete(7, "Extra"), new Paquete(8, "Vip") };
        static void Main(string[] args)
        {
            //_linq3pasos();
            //_where_con_expresion1();
            //_where_con_expresion2();
            //_orderby_ascendente();
            //_orderby_descendente();
            //_select1();
            //_select2();
            //_select3();
            //_group();
            //_into();
            //_let();
            //_join();
            //_uno();
            //_dos();
            //_tres();
            //_cuatro();
            //_cinco();
            //_seis();
            _siete();
            //_dies();
            Console.ReadKey();
        }



        static void _into()
        {
            // Agrupa los sitios web por nombre superior de dominio y selecciona solo los grupos con mas de 2 miembros.
            string[] sitiosWeb = {"abNombreA.com","abNombreB.net","abNombreC.net","abNombreD.com",
                                     "abNombreE.org","abNombreF.org","abNombreG.tv","abNombreH.net",
                                     "abNombreI.tv"};
            var DirWeb = from dir in sitiosWeb
                         where dir.LastIndexOf(".") != -1
                         group dir by dir.Substring(dir.LastIndexOf("."))
                         into ws
                         where ws.Count() > 2
                         select ws;
            Console.WriteLine("Dominios superiores con mas de 2 miembros.\n");
            foreach (var sitios in DirWeb)
            {
                Console.WriteLine("Sitios agrupados por " + sitios.Key);
                foreach (var sitio in sitios)
                    Console.WriteLine(" " + sitio);
                Console.WriteLine();
            }
        }

        static void _let()
        {
            // Usa let y cláusula from anidada.
            //Obtiene los caracteres en las cadenas y los regresa en orden alfabético.
            string[] cadenas = { "alpha", "beta", "gamma" };
            var caracteres = from cad in cadenas
                             let ArregloChars = cad.ToCharArray()
                             from ch in ArregloChars
                             orderby ch
                             select ch;
            Console.WriteLine("Los caracteres individuales en orden alfabético son:\n");
            foreach (char c in caracteres) Console.Write(c + " ");
        }


        static void _join23()
        {

            Turista[] turistas = {
                new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5),
                new Turista(012,"Erick Kolbe","TP",1),};

            Tour[] excursiones = {
                new Tour("TA", "Turismo Aventura", "Magic Tours"),
                new Tour("TG", "Turismo Gastronómico", "Turismo Kronos"),
                new Tour("TC", "Turismo Compras", "Eva's Tours Co."),
                new Tour("TP", "Turismo Paseos", "Alex Tours") };

        }



        static void _group()
        {
            // Agrupa los sitios web por nombre superior de dominio.
            string[] sitiosWeb = {"abNombreA.com","abNombreB.net","abNombreC.net","abNombreD.com",
                                     "abNombreE.org","abNombreF.org","abNombreG.tv","abNombreH.net",
                                     "abNombreI.tv", "hola", "hola.com.edu", "Tu.com.edu"};
            var DirWeb = from dir in sitiosWeb
                         where dir.LastIndexOf(".") != -1
                         group dir by dir.Substring(dir.LastIndexOf("."));
            foreach (var sitios in DirWeb)
            {
                Console.WriteLine("Sitios agrupados por " + sitios.Key);
                foreach (var sitio in sitios)
                    Console.WriteLine(" " + sitio);
                Console.WriteLine();
            }
        }
        static void _uno()
        {
            Turista[] turistas = {
                new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5),
                new Turista(012,"Erick Kolbe","TP",1),};

            Tour[] excursiones = {
                new Tour("TA", "Turismo Aventura", "Magic Tours"),
                new Tour("TG", "Turismo Gastronómico", "Turismo Kronos"),
                new Tour("TC", "Turismo Compras", "Eva's Tours Co."),
                new Tour("TP", "Turismo Paseos", "Alex Tours") };
            //implementar  cod


            var Oden1 = from turista in turistas
                        group turista.nomTurist by turista.CodTour;


            foreach (var sitio in Oden1)
            {
                Console.WriteLine("Turistas agrupados en: " + sitio.Key);
                foreach (var sitios in sitio)
                    Console.WriteLine(" " + sitios);
                Console.WriteLine();
            }
        }
        static void _dos()
        {
            Turista_Lugar[] turista_visita = {
                new Turista_Lugar(123, "BRLCH"),
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

            Turista[] turistas = {
                new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5),
                new Turista(012,"Erick Kolbe","TP",1),};

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


            var visit = from v in turistas
                        join x in turista_visita
                        on v.CI equals x.CI
                        join l in lugares
                        on x.IdLugar equals l.CodLugar
                        group v by l.NomLugar

                    into aux
                        select aux;
            foreach (var i in visit)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Lugar Visita: " + i.Key);

                foreach (var j in i)

                    Console.WriteLine("- " + j.nomTurist);

            }

        }

        static void _tres()
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
            Paquete[] paquetes = {
             new Paquete(1,"Básico"),
             new Paquete(2,"Económico"),
             new Paquete(3,"Estandar"),
             new Paquete(4,"Jubilados"),
             new Paquete(5,"Familiar"),
             new Paquete(6,"Todo incluido"),
             new Paquete(7,"Extra"),
             new Paquete(8,"Vip") };

            var paq = from p in lugares
                      join x in paquetes
                      on p.Paquete equals x.CodPaquete
                      group p by x.NomPaquete
                                  into paqu
                      select paqu;
            foreach (var i in paq)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("=> Nombre del paquete: " + i.Key);
                foreach (var j in i)

                    Console.WriteLine("- Lugares visitados: " + j.NomLugar);

            }

        }
        static void _cuatro()
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
            var tour = from t in excursiones
                       join x in turistas
                       on t.CodTour equals x.CodTour
                       group t by x.nomTurist
                       into xd
                       select xd;
            foreach (var i in tour)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Nombre del turista: ");
                Console.WriteLine(" -" + i.Key);
                foreach (var j in i)


                    Console.WriteLine("Responsable del tour:" + j.Responsable);

            }

        }
        static void _cinco()
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
            var tour = from t in excursiones
                       join x in turistas
                       on t.CodTour equals x.CodTour
                       group t by x.nomTurist
                       into a
                       select a;
            foreach (var i in tour)
            {

                foreach (var j in i)

                    Console.WriteLine("Turista: " + i.Key + "   |" + "Responsable: " + j.Responsable);

            }

        }

        static void _seis()
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

            Lugar[] lugares = { new Lugar("PV", "Puerto Varas", 4), new Lugar("BRLCH", "Bariloche", 3), new Lugar("BRA", "Rio de Janeiro", 3), new Lugar("CHLT", "Chalten", 1), new Lugar("PA", "Punta Arenas", 5), new Lugar("PN", "Puerto Natales", 8), new Lugar("VAL", "Valdivia", 6), new Lugar("BA", "Buenos Aires", 2), new Lugar("SP", "San Pablo", 1), new Lugar("FLO", "Florianópolis", 2) };





            var tour = from t in turistas
                       join x in turista_visita
                       on t.CI equals x.CI

                       join y in lugares
                       on x.IdLugar equals y.CodLugar
                       group t.nomTurist by y.NomLugar;


            var nameubi = from n in turista_visita
                          select n.IdLugar;


            //var igual = tour == tourvisita;
            foreach (var i in tour)
            {
                Console.WriteLine("Nombre lugar: " + i.Key);
                foreach (var j in i)

                    Console.WriteLine("Turista: " + j);

                /*foreach(var a in nameubi)
                {
                    Console.WriteLine("nombre de lugar" + i + "" );
                }*/
                /*foreach (var sitios in tour)
                {
                    Console.WriteLine("Sitios agrupados por " + sitios.Key);
                    foreach (var a in tourvisita)
                        Console.WriteLine(" " + tourvisita);
                    Console.WriteLine();
                }*/


            }
        }

        static void _siete()
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

            Lugar[] lugares = { new Lugar("PV", "Puerto Varas", 4), new Lugar("BRLCH", "Bariloche", 3), new Lugar("BRA", "Rio de Janeiro", 3), new Lugar("CHLT", "Chalten", 1), new Lugar("PA", "Punta Arenas", 5), new Lugar("PN", "Puerto Natales", 8), new Lugar("VAL", "Valdivia", 6), new Lugar("BA", "Buenos Aires", 2), new Lugar("SP", "San Pablo", 1), new Lugar("FLO", "Florianópolis", 2) };





            var tour = from t in turistas
                       join x in turista_visita
                       on t.CI equals x.CI

                       join y in lugares
                       on x.IdLugar equals y.CodLugar
                       group x by y.NomLugar
                       ;


            int cont = 0;
            //var igual = tour == tourvisita;
            foreach (var i in tour)
            {
                cont = 0;
                Console.WriteLine("Nombre lugar: " + i);
                foreach (var j in i)
                    cont++;

                Console.WriteLine(cont);


            }
        }
    }
}
