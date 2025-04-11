using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    internal class Docente : Empleado
    {

        protected override void GetCredencial()
        {
           
        }

        protected override string ListarEmpleados(bool listarConId)
        {
            return "Lista de empleados";
        }
    }
}
