
namespace PuntuInformacionALM
{
    partial class UserControlMapaCentro
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMapaCentro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrimeraPlanta = new System.Windows.Forms.Button();
            this.btnSegundaPlanta = new System.Windows.Forms.Button();
            this.btnTerceraPlanta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnTerceraPlanta);
            this.panel1.Controls.Add(this.btnSegundaPlanta);
            this.panel1.Controls.Add(this.btnPrimeraPlanta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 116);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrimeraPlanta
            // 
            this.btnPrimeraPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrimeraPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPlanta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeraPlanta.Location = new System.Drawing.Point(27, 13);
            this.btnPrimeraPlanta.Name = "btnPrimeraPlanta";
            this.btnPrimeraPlanta.Size = new System.Drawing.Size(221, 91);
            this.btnPrimeraPlanta.TabIndex = 0;
            this.btnPrimeraPlanta.Text = "Primera Planta";
            this.btnPrimeraPlanta.UseVisualStyleBackColor = false;
            this.btnPrimeraPlanta.Click += new System.EventHandler(this.btnPrimeraPlanta_Click);
            // 
            // btnSegundaPlanta
            // 
            this.btnSegundaPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSegundaPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundaPlanta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaPlanta.Location = new System.Drawing.Point(336, 13);
            this.btnSegundaPlanta.Name = "btnSegundaPlanta";
            this.btnSegundaPlanta.Size = new System.Drawing.Size(221, 91);
            this.btnSegundaPlanta.TabIndex = 1;
            this.btnSegundaPlanta.Text = "Segunda Planta";
            this.btnSegundaPlanta.UseVisualStyleBackColor = false;
            this.btnSegundaPlanta.Click += new System.EventHandler(this.btnSegundaPlanta_Click);
            // 
            // btnTerceraPlanta
            // 
            this.btnTerceraPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTerceraPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerceraPlanta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerceraPlanta.Location = new System.Drawing.Point(629, 13);
            this.btnTerceraPlanta.Name = "btnTerceraPlanta";
            this.btnTerceraPlanta.Size = new System.Drawing.Size(221, 91);
            this.btnTerceraPlanta.TabIndex = 2;
            this.btnTerceraPlanta.Text = "Tercera Planta";
            this.btnTerceraPlanta.UseVisualStyleBackColor = false;
            this.btnTerceraPlanta.Click += new System.EventHandler(this.btnTerceraPlanta_Click);
            // 
            // UserControlMapaCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlMapaCentro";
            this.Size = new System.Drawing.Size(881, 617);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerceraPlanta;
        private System.Windows.Forms.Button btnSegundaPlanta;
        private System.Windows.Forms.Button btnPrimeraPlanta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
