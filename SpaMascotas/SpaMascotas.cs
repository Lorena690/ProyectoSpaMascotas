using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASE2_SPAMASCOTAS
{
    internal class SpaMascotas
    {
        private List<Servicio> servicios;
        private Propietario propietario;
        public SpaMascotas(List<Servicio> servicios)
        {
            this.servicios = servicios;
        }

        public List<Servicio> getServicios() 
        { 
            return servicios; 
        }

        public Propietario getPropietario()
        {
            return propietario;
        }

        public void setPropietario(Propietario propietario)
        {
            this.propietario = propietario; 
        }

        public Boolean validarPassword( String password )
        {
            if (password.Trim().Equals("123"))
                return true;
            else 
                return false;
        }

        public void setServicios(List<Servicio> servicios)
        {
            this.servicios = servicios;
        }

        public SpaMascotas()
        {
            ServicioFactory servicioFactory = ServicioFactory.getInstance();
            this.servicios = new List<Servicio>();
            servicios.Add(servicioFactory.factory("Combo 1"));
            servicios.Add(servicioFactory.factory("Combo 2"));
            servicios.Add(servicioFactory.factory("Combo 3"));
        }
        

        public double consultarCosto(String nombreServicio, int estratoSocioeconomico)
        {
            foreach (Servicio servicio in servicios)
            {
                if (servicio.getNombre() == nombreServicio)
                {
                    return servicio.calcularPrecio(estratoSocioeconomico);
                }
            }
            return 0;
        }

        public string consultarNombre(string nombreServicio)
        {
            foreach (Servicio servicio in servicios)
            {
                if (servicio.getNombre() == nombreServicio)
                {
                    return servicio.mostrarNombre();
                }
            }
            return "";
        }
    }
      
}
