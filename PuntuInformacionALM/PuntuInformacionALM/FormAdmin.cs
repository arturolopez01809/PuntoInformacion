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
    public partial class FormAdmin : Form
    {

        Form1 f = new Form1();

        int contador = 0;

        public FormAdmin(Form1 form)
        {
            InitializeComponent();

            this.f = form;

            
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que permitirá el acceso al modo administración de la aplicación en el caso de que la contraseña sea la correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (contador < 3)
            {
                if ((txtPasswordAdmin.Text == "123"))
                {

                    f.admin = true;

                    this.Close();
                }
                else
                {
                    contador++;
                }
            }
            else
            {
                MessageBox.Show("ERROR. INTENTOS ACABADOS. VUELVA A INTENTARLO MÁS TARDE");

                this.Close();
            }
        }
    }
}
