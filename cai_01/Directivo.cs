using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    internal class Directivo : Empleado
    {
        protected override void GetNombreCompleto()
        {

        }

        protected override string ListarEmpleados(bool listarConId)
        {
            return "Lista empleados";
        }
    }
}
