using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASE2_SPAMASCOTAS
{
    internal class ServicioSimple : Servicio
    {
        private double precio;

        public ServicioSimple(string nombre, double precio) : base(nombre)
        {
            this.precio = precio;
        }

        public double getPrecio() 
        { 
            return precio; 
        }

        public void setPrecio(double precio) 
        { 
            this.precio = precio; 
        }

        public override double calcularPrecio(int estrato )
        {
            if(estrato == 1 || estrato == 2)
            {
                return precio * 0.85;
            }
            else if(estrato == 3 || estrato == 4)
            {
                return precio * 0.90;
            }
            else if (estrato >= 5)
            {
                return precio * 0.95;
            }
            else
            {
                return precio;
            }
        }

        public override string mostrarNombre()
        {
            return nombre;
        }
    }
}
