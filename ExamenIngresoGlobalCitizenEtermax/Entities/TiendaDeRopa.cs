using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoGlobalCitizenEtermax.Entities
{
    struct TiendaDeRopa
    {
        public String Nombre{ get; set; }
        public String Direccion{ get; set; }
        public List<Prenda> ListadoPrendas{ get; set; }

        public TiendaDeRopa(String nombre, String direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.ListadoPrendas = new List<Prenda>();
        }

        public void GenerarListadoDePrendas() {
            List<Prenda> listaPrendas = new List<Prenda>();
            Camisa camisaCorta = new Camisa("Standard", 3000, 200, "Corta", false);
            Camisa camisaCortaMao = new Camisa("Standard", 3000, 300, "Corta", true);
            Camisa camisaLarga = new Camisa("Standard", 3000, 200, "Larga", false);
            Camisa camisaLargaMao = new Camisa("Premium", 3000, 200, "Larga", false);
            Pantalon pantalon = new Pantalon("Standard", 7000, 500, "Normal");
            Pantalon pantalonChupin = new Pantalon("Premium", 7000, 1500, "Chupin");
            listaPrendas.Add(camisaCorta);
            listaPrendas.Add(camisaCortaMao);
            listaPrendas.Add(camisaLarga);
            listaPrendas.Add(camisaLargaMao);
            listaPrendas.Add(pantalon);
            listaPrendas.Add(pantalonChupin);
            this.ListadoPrendas = listaPrendas;

        }





    }
}
