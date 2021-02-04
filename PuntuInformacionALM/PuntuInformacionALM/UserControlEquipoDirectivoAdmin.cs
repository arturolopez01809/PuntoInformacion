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
    public partial class UserControlEquipoDirectivoAdmin : UserControl
    {
        public UserControlEquipoDirectivoAdmin()
        {
            InitializeComponent();
            panel1.SendToBack();
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;

            panel2.SendToBack();
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;

            panel3.SendToBack();
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;

            panel4.SendToBack();
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.None;

            panel5.SendToBack();
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.None;



            panel1.MouseHover += new System.EventHandler(this.MostrarPanelDirector);
            panel1.MouseLeave += new System.EventHandler(this.OcultarPanelDirector);

            panel2.MouseHover += new System.EventHandler(this.MostrarPanelJefeEstudios);
            panel2.MouseLeave += new System.EventHandler(this.OcultarPanelJefeEstudios);

            panel3.MouseHover += new System.EventHandler(this.MostrarPanelSecretaria);
            panel3.MouseLeave += new System.EventHandler(this.OcultarPanelSecretaria);

            panel4.MouseHover += new System.EventHandler(this.MostrarPanelPAS);
            panel4.MouseLeave += new System.EventHandler(this.OcultarPanelPAS);

            panel5.MouseHover += new System.EventHandler(this.MostrarPanelOrientador);
            panel5.MouseLeave += new System.EventHandler(this.OcultarPanelOrientador);
        }

        private void OcultarPanelDirector(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
        }

        private void MostrarPanelDirector(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void MostrarPanelJefeEstudios(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void OcultarPanelJefeEstudios(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void MostrarPanelSecretaria(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void OcultarPanelSecretaria(object sender, EventArgs e)
        {
            panel3.SendToBack();
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void MostrarPanelPAS(object sender, EventArgs e)
        {
            panel4.BringToFront();
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void OcultarPanelPAS(object sender, EventArgs e)
        {
            panel4.SendToBack();
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void MostrarPanelOrientador(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void OcultarPanelOrientador(object sender, EventArgs e)
        {
            panel5.SendToBack();
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

    }
}
