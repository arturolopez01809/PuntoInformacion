using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuInformacionALM
{
    public partial class UserControlPuntosInteresAdmin : UserControl
    {
        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        /*GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 37.18432;
        double Lnginicial = -3.59344;

        bool poder_escribir = true;

        


        public UserControlPuntosInteresAdmin()
        {
            InitializeComponent();

            StreamReader leer = new StreamReader(@"C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/puntos_interes.txt");
            string linea;

            try
            {
                linea = leer.ReadLine();

                if(linea == null)
                {
                    poder_escribir = false;
                } else
                {
                    poder_escribir = true;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

            leer.Close();

            UserControlPuntosInteres_Load();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        public void UserControlPuntosInteres_Load()
        {

            if(poder_escribir == true)
            {
                StreamWriter escribir = new StreamWriter(@"C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/puntos_interes.txt");

                dt = new DataTable();
                dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
                dt.Columns.Add(new DataColumn("Lat", typeof(double)));
                dt.Columns.Add(new DataColumn("Long", typeof(double)));

                try
                {
                    escribir.WriteLine("Colegio Cristo Rey " + "37.18432 " + "-3.59344 ");
                    escribir.WriteLine("Parking San Cristóbal Albaicín " + "37.18398 " + "-3.59591 ");
                    escribir.WriteLine("Mirador de San Cristóbal " + "37.18314 " + "-3.59602 ");
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }

                escribir.Close();
            } 

            

            string linea;
            string[] trozos;
            char caracter = ' ';

            StreamReader leer = new StreamReader(@"C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/puntos_interes.txt");

            try
            {
                linea = leer.ReadLine();

                while(linea != null)
                {

                    

                    //textBox2.Text = linea;

                    trozos = linea.Split(caracter);

                    dt.Rows.Add(trozos[0].ToString(), trozos[1].ToString(), trozos[2].ToString());

                    linea = leer.ReadLine();


                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            leer.Close();

            dataGridView1.DataSource = dt;



            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(LatInicial, Lnginicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 19;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(LatInicial, Lnginicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, Lnginicial);

            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void SeleccionarLocalizacion(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;

            textBoxNombre.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(textBox2.Text.ToString()), Convert.ToDouble(textBox3.Text.ToString()));

            gMapControl1.Position = marker.Position;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter escribir = new StreamWriter(@"C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/puntos_interes.txt", true);

            //label2.Text = textBox2.Text.ToString();

            escribir = File.AppendText("C:/code/SegundoTrimestre/DI/PuntoInformacion/PuntuInformacionALM/puntos_interes.txt");;

            try
            {
                escribir.WriteLine(textBoxNombre.Text.ToString() + " " + textBox2.Text.ToString() + " " + textBox3.Text.ToString());
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

            escribir.Close();

            dt.Rows.Add(textBoxNombre.Text.ToString(), Convert.ToDouble(textBox2.Text.ToString()), Convert.ToDouble(textBox3.Text.ToString()));

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(Convert.ToDouble(textBox2.Text.ToString()), Convert.ToDouble(textBox3.Text.ToString()));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 19;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(LatInicial, Lnginicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, Lnginicial);

            gMapControl1.Overlays.Add(markerOverlay);


            textBoxNombre.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dt.Rows.RemoveAt(filaSeleccionada);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }*/
    }
}
