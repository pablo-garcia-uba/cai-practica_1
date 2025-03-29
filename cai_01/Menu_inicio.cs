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
    public partial class Menu_inicio : Form
    {
        
        public Menu_inicio()
        {
            InitializeComponent();            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_login_Click(object sender, EventArgs e)
        {
            Login nuevaVentana = new Login();
            nuevaVentana.Show();
            this.Close();
        }
    }
}
