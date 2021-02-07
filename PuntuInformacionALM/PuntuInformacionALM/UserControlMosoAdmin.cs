using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuInformacionALM
{
    public partial class UserControlMosoAdmin : UserControl
    {

        bool admin = false;

        public UserControlMosoAdmin()
        {
            InitializeComponent();
        }

        private void btnAceptarModoAdmin_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "123")
            {
                this.admin = true;

                MessageBox.Show("MODO ADMINISTRADOR ACTIVADO CON EXITO");
            } else
            {
                label1.Text = "Contraseña (*): ";
                label1.ForeColor = Color.FromArgb(192, 0, 0);

                textBoxPassword.Text = "";
            }

        }

        public bool ReturnAdmin()
        {
            return this.admin;
        }
    }
}
