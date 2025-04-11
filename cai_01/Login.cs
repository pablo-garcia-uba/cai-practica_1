using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cai_01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())

             return; 
            Menu_inicio nuevaVentana = new Menu_inicio();
            nuevaVentana.Show();
            this.Hide();
        }

        private bool ValidarFormulario()
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsuario.Focus();
                flag = false;
            }

            else if (textBoxUsuario.Text.Length < 6)
            {
                MessageBox.Show("El nombre de usuario debe tener 6 o más caracteres.");
                textBoxUsuario.Focus();
                flag = false;
            }            
            
            else if (textBoxPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener 6 o más caracteres.");
                textBoxPass.Focus();
                flag =false;
            }
            else
            {
                flag = true;
            }


            return flag; // Todo bien
        } 
    } 
}

// 1) Validaciones

// 1.1) Validaciones de integridad de datos

// 1.) Validaciones de negocio

// 1.1) Longitud de usuario (mayor igual a 6)

// 1.2) Longitud de password (mayor igual a 6)

// 1.3) Primero Login? -> Cambio password

// 1.4) Expira password?

// 2) Redirigir
