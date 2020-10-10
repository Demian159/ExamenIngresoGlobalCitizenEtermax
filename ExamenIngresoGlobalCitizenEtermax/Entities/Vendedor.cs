using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    class Vendedor
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int CodigoVendedor { get; set; }
        public TiendaDeRopa TiendaDelVendedor { get; set; }
        public List<Cotizacion> HistorialCotizaciones { get; set; }

        public Vendedor(String nombre, String apellido, int codigoVendedor,
            TiendaDeRopa tiendaDelVendedor)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CodigoVendedor = codigoVendedor;
            this.TiendaDelVendedor = tiendaDelVendedor;

        }


        public Cotizacion RealizarCotizaciones(Prenda prenda,int cantidadUnidades) {
            Cotizacion cotizacion = new Cotizacion(prenda, cantidadUnidades);
            HistorialCotizaciones.Add(cotizacion);
            return cotizacion;
        }

    }
}
