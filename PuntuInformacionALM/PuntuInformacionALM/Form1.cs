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
        UserControlEquipoDirectivoAdmin equipo_admin;
        UserControlMapaCentro mapa;

        

        public bool admin = false;

        FormAdmin form_admin;

        public Form1()
        {
            InitializeComponent();

            home = new UserControlHome(this);
            puntos_interes = new UserControlPuntosInteres();
            sugerencias = new UserControlSugerencias();
            equipo = new UserControlEquipoDirectivo();
            calendario = new UserControlCalendario();
            equipo_admin = new UserControlEquipoDirectivoAdmin();
            mapa = new UserControlMapaCentro();

            PanelCambiante.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();

            SidePanel.Height = btnHome.Height;

            userControl11.BringToFront();

            
        }

        /// <summary>
        /// Evento creado para cambiar el control de usuario de la aplicación en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPuntosInteres_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnPuntosInteres.Height;
            SidePanel.Top = btnPuntosInteres.Top;

            
                if (!PanelCambiante.Contains(puntos_interes))
                {
                    PanelCambiante.Controls.Add(puntos_interes);
                    puntos_interes.Dock = DockStyle.Fill;
                    puntos_interes.BringToFront();
                }
                else
                {
                    puntos_interes.BringToFront();
                }
            

            
        }

        /// <summary>
        /// Evento creado para cambiar el control de usuario de la aplicación en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento creado para cambiar el control de usuario de la aplicación en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento creado para cambiar el control de usuario de la aplicación en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquipoDirectivo_Click(object sender, EventArgs e)
        {
            

            if (!admin)
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
            else
            {
                SidePanel.Height = btnEquipoDirectivo.Height;
                SidePanel.Top = btnEquipoDirectivo.Top;

                if (!PanelCambiante.Contains(equipo_admin))
                {
                    PanelCambiante.Controls.Add(equipo_admin);
                    equipo_admin.Dock = DockStyle.Fill;
                    equipo_admin.BringToFront();
                }
                else
                {
                    equipo_admin.BringToFront();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento creado para cambiar el control de usuario de la aplicación en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento creado para la aparición de un nuevo formulario en el caso de que se seleccione este botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            form_admin = new FormAdmin(this);
            form_admin.Show();
        }


        private void Activar_Admin(object sender, MouseEventArgs e)
        {
            form_admin = new FormAdmin(this);
            form_admin.Show();
        }

        private void Activar_Admin(object sender, EventArgs e)
        {
            form_admin = new FormAdmin(this);
            form_admin.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_admin = new FormAdmin(this);
            form_admin.Show();
        }

        private void btnMapaCentro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHorarioAulas.Height;
            SidePanel.Top = btnHorarioAulas.Top;

            if (!PanelCambiante.Contains(mapa))
            {
                PanelCambiante.Controls.Add(mapa);
                mapa.Dock = DockStyle.Fill;
                mapa.BringToFront();
            }
            else
            {
                mapa.BringToFront();
            }
        }
    }
}
