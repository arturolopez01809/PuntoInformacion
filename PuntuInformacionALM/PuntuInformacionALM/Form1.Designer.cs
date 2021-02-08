
namespace PuntuInformacionALM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new BotonAdmin.UserControl1();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSugerencias = new System.Windows.Forms.Button();
            this.btnPuntosInteres = new System.Windows.Forms.Button();
            this.btnHorarioAulas = new System.Windows.Forms.Button();
            this.btnMapaCentro = new System.Windows.Forms.Button();
            this.btnEquipoDirectivo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelCambiante = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnSugerencias);
            this.panel1.Controls.Add(this.btnPuntosInteres);
            this.panel1.Controls.Add(this.btnHorarioAulas);
            this.panel1.Controls.Add(this.btnMapaCentro);
            this.panel1.Controls.Add(this.btnEquipoDirectivo);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 617);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(99, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modo Admin OFF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl11.Location = new System.Drawing.Point(15, 556);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(53, 49);
            this.userControl11.TabIndex = 7;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 84);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnSugerencias
            // 
            this.btnSugerencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSugerencias.FlatAppearance.BorderSize = 0;
            this.btnSugerencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSugerencias.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugerencias.ForeColor = System.Drawing.Color.White;
            this.btnSugerencias.Image = ((System.Drawing.Image)(resources.GetObject("btnSugerencias.Image")));
            this.btnSugerencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSugerencias.Location = new System.Drawing.Point(15, 444);
            this.btnSugerencias.Name = "btnSugerencias";
            this.btnSugerencias.Size = new System.Drawing.Size(206, 84);
            this.btnSugerencias.TabIndex = 5;
            this.btnSugerencias.Text = "Sugerencias";
            this.btnSugerencias.UseVisualStyleBackColor = true;
            this.btnSugerencias.Click += new System.EventHandler(this.btnSugerencias_Click);
            // 
            // btnPuntosInteres
            // 
            this.btnPuntosInteres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuntosInteres.FlatAppearance.BorderSize = 0;
            this.btnPuntosInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntosInteres.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntosInteres.ForeColor = System.Drawing.Color.White;
            this.btnPuntosInteres.Image = ((System.Drawing.Image)(resources.GetObject("btnPuntosInteres.Image")));
            this.btnPuntosInteres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuntosInteres.Location = new System.Drawing.Point(15, 354);
            this.btnPuntosInteres.Name = "btnPuntosInteres";
            this.btnPuntosInteres.Size = new System.Drawing.Size(206, 84);
            this.btnPuntosInteres.TabIndex = 4;
            this.btnPuntosInteres.Text = "Puntos Interes";
            this.btnPuntosInteres.UseVisualStyleBackColor = true;
            this.btnPuntosInteres.Click += new System.EventHandler(this.btnPuntosInteres_Click);
            // 
            // btnHorarioAulas
            // 
            this.btnHorarioAulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarioAulas.FlatAppearance.BorderSize = 0;
            this.btnHorarioAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarioAulas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioAulas.ForeColor = System.Drawing.Color.White;
            this.btnHorarioAulas.Image = ((System.Drawing.Image)(resources.GetObject("btnHorarioAulas.Image")));
            this.btnHorarioAulas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarioAulas.Location = new System.Drawing.Point(12, 264);
            this.btnHorarioAulas.Name = "btnHorarioAulas";
            this.btnHorarioAulas.Size = new System.Drawing.Size(206, 84);
            this.btnHorarioAulas.TabIndex = 3;
            this.btnHorarioAulas.Text = "   Calendario Escolar";
            this.btnHorarioAulas.UseVisualStyleBackColor = true;
            this.btnHorarioAulas.Click += new System.EventHandler(this.btnHorarioAulas_Click);
            // 
            // btnMapaCentro
            // 
            this.btnMapaCentro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapaCentro.FlatAppearance.BorderSize = 0;
            this.btnMapaCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapaCentro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapaCentro.ForeColor = System.Drawing.Color.White;
            this.btnMapaCentro.Image = ((System.Drawing.Image)(resources.GetObject("btnMapaCentro.Image")));
            this.btnMapaCentro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMapaCentro.Location = new System.Drawing.Point(15, 183);
            this.btnMapaCentro.Name = "btnMapaCentro";
            this.btnMapaCentro.Size = new System.Drawing.Size(206, 84);
            this.btnMapaCentro.TabIndex = 2;
            this.btnMapaCentro.Text = "Mapa Centro";
            this.btnMapaCentro.UseVisualStyleBackColor = true;
            this.btnMapaCentro.Click += new System.EventHandler(this.btnMapaCentro_Click);
            // 
            // btnEquipoDirectivo
            // 
            this.btnEquipoDirectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipoDirectivo.FlatAppearance.BorderSize = 0;
            this.btnEquipoDirectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipoDirectivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipoDirectivo.ForeColor = System.Drawing.Color.White;
            this.btnEquipoDirectivo.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipoDirectivo.Image")));
            this.btnEquipoDirectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipoDirectivo.Location = new System.Drawing.Point(15, 93);
            this.btnEquipoDirectivo.Name = "btnEquipoDirectivo";
            this.btnEquipoDirectivo.Size = new System.Drawing.Size(206, 84);
            this.btnEquipoDirectivo.TabIndex = 1;
            this.btnEquipoDirectivo.Text = "   Equipo Directivo";
            this.btnEquipoDirectivo.UseVisualStyleBackColor = true;
            this.btnEquipoDirectivo.Click += new System.EventHandler(this.btnEquipoDirectivo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 84);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelCambiante
            // 
            this.PanelCambiante.Location = new System.Drawing.Point(220, 0);
            this.PanelCambiante.Name = "PanelCambiante";
            this.PanelCambiante.Size = new System.Drawing.Size(881, 617);
            this.PanelCambiante.TabIndex = 1;
            this.PanelCambiante.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Activar_Admin);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 617);
            this.Controls.Add(this.PanelCambiante);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEquipoDirectivo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSugerencias;
        private System.Windows.Forms.Button btnPuntosInteres;
        private System.Windows.Forms.Button btnHorarioAulas;
        private System.Windows.Forms.Button btnMapaCentro;
        private System.Windows.Forms.Panel PanelCambiante;
        private BotonAdmin.UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
    }
}

