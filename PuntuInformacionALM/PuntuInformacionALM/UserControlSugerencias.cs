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
    public partial class UserControlSugerencias : UserControl
    {
        public UserControlSugerencias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento creado en el caso que se realice un click en el botón de eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAsunto.Text = "";
            textBoxEmail.Text = "";
        }

        /// <summary>
        /// Evento creado en el caso que se realice un click en el botón de enviar mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            

            if((textBoxAsunto.Text != "") && (textBoxEmail.Text != ""))
            {

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                msg.To.Add("pruebapuntoinformacion@gmail.com");
                msg.Subject = textBoxAsunto.Text;
                msg.SubjectEncoding = System.Text.Encoding.UTF8; // cpdificacion para evitar problemas a la hora de enviarlo

                msg.Body = textBoxEmail.Text;
                msg.BodyEncoding = System.Text.Encoding.UTF8;


                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("arturolopez01809@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("arturolopez01809@gmail.com", "rycbar123");

                cliente.Port = 587;

                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";
                try
                {
                    cliente.Send(msg);
                    MessageBox.Show("Correo enviado");
                    textBoxAsunto.Text = "";
                    textBoxEmail.Text = "";
                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR AL ENVIAR CORREO");
                }

            } else
            {
                MessageBox.Show("El Asunto del correo debe especificarse");

                label1.Text = "Asunto (*):";
                label1.ForeColor = Color.FromArgb(192,0,0);
                
            }

            
        }
    }
}
