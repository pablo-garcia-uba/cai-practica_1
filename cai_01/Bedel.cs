using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai_01
{
    internal class Bedel : Empleado
    {

        public String _apodo;

        public String Apodo { get => _apodo; set => _apodo = value; }

        protected override void GetCredencial()
        {

        }

        protected override String ListarEmpleados(bool listarConId)
        {
            return "Lista de empleados";
        }
    }
}
