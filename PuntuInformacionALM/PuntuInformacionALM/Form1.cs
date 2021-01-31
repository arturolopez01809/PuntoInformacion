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
        UserControlSugerencias sugerencias;
        UserControlEquipoDirectivo equipo;
        UserControlCalendario calendario;

        public Form1()
        {
            InitializeComponent();

            home = new UserControlHome(this);
            puntos_interes = new UserControlPuntosInteres();
            sugerencias = new UserControlSugerencias();
            equipo = new UserControlEquipoDirectivo();
            calendario = new UserControlCalendario();

            PanelCambiante.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();

            SidePanel.Height = btnHome.Height;

            
        }

        private void btnPuntosInteres_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPuntosInteres.Height;
            SidePanel.Top = btnPuntosInteres.Top;

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
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;

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

        private void btnSugerencias_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSugerencias.Height;
            SidePanel.Top = btnSugerencias.Top;

            if (!PanelCambiante.Contains(sugerencias))
            {
                PanelCambiante.Controls.Add(sugerencias);
                sugerencias.Dock = DockStyle.Fill;
                sugerencias.BringToFront();
            }
            else
            {
                sugerencias.BringToFront();
            }
        }

        private void btnEquipoDirectivo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEquipoDirectivo.Height;
            SidePanel.Top = btnEquipoDirectivo.Top;

            if (!PanelCambiante.Contains(equipo))
            {
                PanelCambiante.Controls.Add(equipo);
                equipo.Dock = DockStyle.Fill;
                equipo.BringToFront();
            }
            else
            {
                equipo.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHorarioAulas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHorarioAulas.Height;
            SidePanel.Top = btnHorarioAulas.Top;

            if (!PanelCambiante.Contains(calendario))
            {
                PanelCambiante.Controls.Add(calendario);
                calendario.Dock = DockStyle.Fill;
                calendario.BringToFront();
            }
            else
            {
                calendario.BringToFront();
            }
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
