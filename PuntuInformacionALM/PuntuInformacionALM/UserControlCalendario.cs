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
    public partial class UserControlCalendario : UserControl
    {
        public UserControlCalendario()
        {
            InitializeComponent();

            axAcroPDF1.src = "C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/PuntuInformacionALM/images/calendario_escolar_granada_20-21.pdf";
        }


        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
