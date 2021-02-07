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
    public partial class FormularioEdicion : Form
    {

        PictureBox pic;
        Label t;

        public FormularioEdicion(PictureBox p, Label nombre)
        {
            InitializeComponent();

            pic = p;
            t = nombre;

            pictureBox1.Image = p.Image;

            txtNombre.Text = nombre.Text;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccionar = new OpenFileDialog();

            seleccionar.Filter = "Imagenes|*.jpg; *.png";
            seleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if(seleccionar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(seleccionar.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic.Image = pictureBox1.Image;
            t.Text = txtNombre.Text;

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
