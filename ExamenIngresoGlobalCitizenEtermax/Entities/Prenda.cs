using ExamenIngresoGlobalCitizenEtermax.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    class Prenda : ICalculable
    {
        public String Calidad{ get; set; }
        public double Precio { get; set; }
        public int CantidadUnidades{ get; set; }

        public Prenda(String calidad, double precio, int cantidadUnidades)
        {
            this.Calidad = calidad;
            this.Precio = precio;
            CalcularPrecioFinal();
            this.CantidadUnidades = cantidadUnidades;
        }

        public virtual void CalcularPrecioFinal()
        {
            if (this.Calidad == "Premium")
            {
                this.Precio += this.Precio / 0.30;
            }


        }
    }
}
