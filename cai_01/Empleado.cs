using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    public abstract class Empleado : Persona
    {
        //Declaro atributos
        public int _legajo;
        public DateTime _fechaingreso;

        //Declaro propiedades
        public int Legago { get => _legajo; set => _legajo = value; }
        public DateTime FechaIngreso { get => _fechaingreso; set => _fechaingreso = value; }

        protected override void GetCredencial()
        {
           
        }

        protected abstract String ListarEmpleados(bool listarConId);
    }
}
