using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASE2_SPAMASCOTAS
{
    internal class Propietario
    {
        private string nombre;
        private Mascota mascota;
        private int estratoSocioeconomico;
        private int identificacion;
        private DateTime fechaServicio;
        private string servicio; 

        public Propietario(string nombre, Mascota mascota, int estratoSocioeconomico, int identificacion, DateTime fechaServicio, string servicio)
        {
            this.nombre = nombre;
            this.mascota = mascota;
            this.estratoSocioeconomico = estratoSocioeconomico;
            this.identificacion = identificacion;
            this.fechaServicio = fechaServicio;
            this.servicio = servicio;
        }
        
        public int getIdentificacion() 
        { 
            return identificacion; 
        }

        public void setIdentificacion(int identificacion) 
        { 
            this.identificacion = identificacion; 
        }
        public DateTime getFechaServicio()
        {
            return fechaServicio;
        }

        public void setFechaServicio(DateTime fechaServicio)
        {
            this.fechaServicio = fechaServicio;  
        }
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getServicio()
        {
            return servicio;
        }

        public void setSetvicio(string servicio)
        {
            this.servicio = servicio;
        }

        public Mascota getMascota()
        {
            return mascota;
        }

        public void setMascota(Mascota mascota) 
        { 
            this.mascota = mascota; 
        }

        public int getEstratoSocioeconomico() 
        { 
            return estratoSocioeconomico; 
        }

        public void setEstratoSocioeconomico(int estratoSocioeconomico)
        {
            this.estratoSocioeconomico = estratoSocioeconomico;
        }
    }

}
