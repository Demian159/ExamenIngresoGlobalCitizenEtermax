using ExamenIngresoGlobalCitizenEtermax.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaDeRopa tienda1 = new TiendaDeRopa("Casa Tia", "Beltran 368");
            tienda1.GenerarListadoDePrendas();
            Vendedor vendedor1 = new Vendedor("Tito", "Gonzales", 0123, tienda1);
            Console.WriteLine(vendedor1.RealizarCotizaciones(tienda1.ListadoPrendas[1], 5));
            Console.ReadKey();
        }
    }
}
