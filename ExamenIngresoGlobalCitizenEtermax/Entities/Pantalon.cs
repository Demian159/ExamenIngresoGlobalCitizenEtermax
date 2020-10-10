using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    class Pantalon : Prenda
    {
        public String Tipo { get; set; }

        public Pantalon(String calidad, double precio, int cantidadUnidades, String tipo) : base(calidad, precio, cantidadUnidades)
        {
            this.Tipo = tipo;
        }

        public void CalcularPrecioFinal()
        {
            base.CalcularPrecioFinal();
            if (this.Tipo == "Chupin")
            {
                this.Precio -= this.Precio / 0.12;
            }
        }
    }
}
