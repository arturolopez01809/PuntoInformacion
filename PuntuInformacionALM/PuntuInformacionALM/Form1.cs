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
    public partial class Form1 : Form
    {
        UserControlHome home;
        UserControlPuntosInteres puntos_interes;

        public Form1()
        {
            InitializeComponent();
            home = new UserControlHome();
            PanelCambiante.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            puntos_interes = new UserControlPuntosInteres();
        }

        private void btnPuntosInteres_Click(object sender, EventArgs e)
        {
            if(!PanelCambiante.Contains(puntos_interes))
            {
                PanelCambiante.Controls.Add(puntos_interes);
                puntos_interes.Dock = DockStyle.Fill;
                puntos_interes.BringToFront();
            } else
            {
                puntos_interes.BringToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!PanelCambiante.Contains(home))
            {
                PanelCambiante.Controls.Add(home);
                home.Dock = DockStyle.Fill;
                home.BringToFront();
            } else
            {
                home.BringToFront();
            }
        }
    }
}
