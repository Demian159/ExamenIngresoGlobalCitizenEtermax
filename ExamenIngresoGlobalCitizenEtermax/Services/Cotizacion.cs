using ExamenIngresoGlobalCitizenEtermax.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    class Cotizacion
    {
        public static int id;
        public String FechaYHora { get; }
        public Prenda Prenda { get; set; }
        public int CantidadUnidades { get; set; }
        public double ResultadoCotizacion { get; set; }

        public Cotizacion(Prenda prenda, int cantidadUnidades)
        {
            id++;
            this.FechaYHora = ObtenerFechaYHora();
            this.Prenda = prenda;
            this.CantidadUnidades = cantidadUnidades;
            prenda.CalcularPrecio();
            this.ResultadoCotizacion = prenda.Precio * cantidadUnidades;

        }
        public String ObtenerFechaYHora() {
            return DateTime.Now.ToString();
        }


    }
}
