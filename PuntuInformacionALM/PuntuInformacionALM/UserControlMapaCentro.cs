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
    public partial class UserControlMapaCentro : UserControl
    {
        public UserControlMapaCentro()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\code\SegundoTrimestre\DI\PuntoInformacion\PuntuInformacionALM\PuntuInformacionALM\images\primera_planta.png");
        }

        private void btnPrimeraPlanta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\code\SegundoTrimestre\DI\PuntoInformacion\PuntuInformacionALM\PuntuInformacionALM\images\primera_planta.png");
        }

        private void btnSegundaPlanta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\code\SegundoTrimestre\DI\PuntoInformacion\PuntuInformacionALM\PuntuInformacionALM\images\segunda_planta.png");
        }

        private void btnTerceraPlanta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\code\SegundoTrimestre\DI\PuntoInformacion\PuntuInformacionALM\PuntuInformacionALM\images\tercera_planta.png");
        }
    }
}
