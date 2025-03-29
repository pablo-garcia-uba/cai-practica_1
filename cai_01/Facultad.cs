using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    public class Facultad
    {
        // Declarar atributos
        // visibilidad + tipo de dato + nombre;
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        //Declarar propiedades
        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public List<Empleado> Empleados { get => _empleados; set => _empleados = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

    }
}
