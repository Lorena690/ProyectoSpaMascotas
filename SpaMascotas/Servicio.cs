using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASE2_SPAMASCOTAS
{
    internal abstract class Servicio
    {
        protected string nombre;
       

        public Servicio(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract double calcularPrecio(int estrato);

        public abstract string mostrarNombre();
    }
}
