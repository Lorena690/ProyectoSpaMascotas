using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASE2_SPAMASCOTAS
{
    internal class ServicioCompuesto : Servicio
    {
        private List<Servicio> servicios;

        public ServicioCompuesto(string nombre, List<Servicio> servicios) : base(nombre)
        {
            this.servicios = servicios;
        }
        public List<Servicio> getServicios()
        {
            return servicios;
        }

        public void setServicios(List<Servicio> servicios)
        {
            this.servicios = servicios;
        }
        public override double calcularPrecio(int estrato)
        {
            double sumaPrecios = 0;
            foreach (Servicio servicio in servicios)
            {
                sumaPrecios += servicio.calcularPrecio(estrato);
            }
            return sumaPrecios;
        }
        public override string mostrarNombre()
        {
            string nombres = this.nombre+": ";
            foreach (Servicio servicio in servicios)
            {
                nombres += servicio.mostrarNombre()+", ";
            }
            return nombres;
        }
    }
}
