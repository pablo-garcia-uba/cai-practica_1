using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    public abstract class Persona 
    {
        // Declarar atributos
        // visibilidad + tipo de dato + nombre;
        public String _nombre;
        public String _apellido;
        public DateTime _fechaNac;

        //Declarar propiedades
        public String Nombre { get => _nombre; set => _nombre = value; }
        public String Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //Delcarar metodos
        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }

        protected void GetSaludoInformal() 
        {

        }


    }
}
