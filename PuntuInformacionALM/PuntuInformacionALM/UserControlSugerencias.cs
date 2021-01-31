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

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAsunto.Text = "";
            textBoxEmail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("mensaje enviado");
            }

            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
