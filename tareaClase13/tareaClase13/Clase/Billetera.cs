using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaClase13.Clase
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            // Multiplica cada parametro por el valor del billete y devuelve su suma total:
            return BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
        }

        // Tomamos dos parametros los cuales utilisamos para sumar las billeteras en una nueva y borrar los valores de las dos anteriores.
        public Billetera Combinar(Billetera otraBilletera, Billetera estaBilletera)
        {
            // Se suman los valores y se guardan en la nueva variable.
            var newBilletera = new Billetera()
            {
                BilletesDe10 = estaBilletera.BilletesDe10 + otraBilletera.BilletesDe10,
                BilletesDe20 = estaBilletera.BilletesDe20 + otraBilletera.BilletesDe20,
                BilletesDe50 = estaBilletera.BilletesDe50 + otraBilletera.BilletesDe50,
                BilletesDe100 = estaBilletera.BilletesDe100 + otraBilletera.BilletesDe100,
                BilletesDe200 = estaBilletera.BilletesDe200 + otraBilletera.BilletesDe200,
                BilletesDe500 = estaBilletera.BilletesDe500 + otraBilletera.BilletesDe500,
                BilletesDe1000 = estaBilletera.BilletesDe1000 + otraBilletera.BilletesDe1000
            };
            
            // Se borran los valores de las variables anteriores.
            otraBilletera.BilletesDe10 = 0;
            otraBilletera.BilletesDe20 = 0;
            otraBilletera.BilletesDe50 = 0;
            otraBilletera.BilletesDe100 = 0;
            otraBilletera.BilletesDe200 = 0;
            otraBilletera.BilletesDe500 = 0;
            otraBilletera.BilletesDe1000 = 0;


            estaBilletera.BilletesDe10 = 0;
            estaBilletera.BilletesDe20 = 0;
            estaBilletera.BilletesDe50 = 0;
            estaBilletera.BilletesDe100 = 0;
            estaBilletera.BilletesDe200 = 0;
            estaBilletera.BilletesDe500 = 0;
            estaBilletera.BilletesDe1000 = 0;

            // Devuelve la nueva variable.
            return newBilletera;
        }
    }
}
