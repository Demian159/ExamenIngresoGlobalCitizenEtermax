using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    class Camisa : Prenda
    {
        public String Manga{ get; set; }
        public Boolean CuelloMao{ get; set; }
        public Camisa(String calidad, double precio, int cantidadUnidades, String manga, Boolean cuelloMao) : base(calidad, precio, cantidadUnidades)
        {
            this.Manga = manga;
            this.CuelloMao = cuelloMao;
        }

        public override void CalcularPrecioFinal() 
        {
            base.CalcularPrecioFinal();
            if (this.Manga == "Corta")
            {
                this.Precio -= this.Precio / 0.10;
            }
            else if (this.CuelloMao)
            {
                this.Precio += this.Precio / 0.0;
            }
        }
    }
        
 
}
