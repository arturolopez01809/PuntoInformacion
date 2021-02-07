
namespace PuntuInformacionALM
{
    partial class UserControlMosoAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnAceptarModoAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(285, 194);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(504, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // btnAceptarModoAdmin
            // 
            this.btnAceptarModoAdmin.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarModoAdmin.Location = new System.Drawing.Point(385, 443);
            this.btnAceptarModoAdmin.Name = "btnAceptarModoAdmin";
            this.btnAceptarModoAdmin.Size = new System.Drawing.Size(166, 62);
            this.btnAceptarModoAdmin.TabIndex = 2;
            this.btnAceptarModoAdmin.Text = "Aceptar";
            this.btnAceptarModoAdmin.UseVisualStyleBackColor = true;
            this.btnAceptarModoAdmin.Click += new System.EventHandler(this.btnAceptarModoAdmin_Click);
            // 
            // UserControlMosoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAceptarModoAdmin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Name = "UserControlMosoAdmin";
            this.Size = new System.Drawing.Size(881, 617);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnAceptarModoAdmin;
    }
}
