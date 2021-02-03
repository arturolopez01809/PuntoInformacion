using System;
using System.Data;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace PuntuInformacionALM
{
    public partial class UserControlPuntosInteres : UserControl
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 37.18432;
        double Lnginicial = -3.59344;

        public UserControlPuntosInteres()
        {
            InitializeComponent();
            UserControlPuntosInteres_Load();
        }

        public void UserControlPuntosInteres_Load()
        {

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));


            dt.Rows.Add("Colegio Cristo Rey", LatInicial, Lnginicial);
            dt.Rows.Add("Parking San Cristóbal Albaicín", 37.18398, -3.59591);
            dt.Rows.Add("Mirador de San Cristóbal", 37.18314, -3.59602);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
