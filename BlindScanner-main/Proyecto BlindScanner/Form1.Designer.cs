
namespace Proyecto_BlindScanner
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPreg = new System.Windows.Forms.Label();
            this.lblCambiar = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.checkbxMC = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistrarse.Location = new System.Drawing.Point(70, 35);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(57, 13);
            this.lblRegistrarse.TabIndex = 0;
            this.lblRegistrarse.Text = "Regístrate";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomUsuario.Location = new System.Drawing.Point(67, 84);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNomUsuario.TabIndex = 1;
            this.lblNomUsuario.Text = "Nombre de Usuario:";
            this.lblNomUsuario.MouseHover += new System.EventHandler(this.lblNomUsuario_MouseHover);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(67, 177);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.MouseHover += new System.EventHandler(this.lblContraseña_MouseHover);
            // 
            // lblPreg
            // 
            this.lblPreg.AutoSize = true;
            this.lblPreg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreg.Location = new System.Drawing.Point(67, 373);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(114, 13);
            this.lblPreg.TabIndex = 3;
            this.lblPreg.Text = "Ya tienes una cuenta?";
            // 
            // lblCambiar
            // 
            this.lblCambiar.AutoSize = true;
            this.lblCambiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCambiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCambiar.Location = new System.Drawing.Point(70, 407);
            this.lblCambiar.Name = "lblCambiar";
            this.lblCambiar.Size = new System.Drawing.Size(67, 13);
            this.lblCambiar.TabIndex = 4;
            this.lblCambiar.Text = "Inicia Sesión";
            this.lblCambiar.Click += new System.EventHandler(this.lblCambiar_Click);
            this.lblCambiar.MouseHover += new System.EventHandler(this.lblCambiar_MouseHover);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(68, 109);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 5;
            this.txtNomUsuario.MouseHover += new System.EventHandler(this.txtNomUsuario_MouseHover);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(68, 193);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.MouseHover += new System.EventHandler(this.txtContraseña_MouseHover);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarse.Location = new System.Drawing.Point(68, 307);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(100, 51);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            this.btnRegistrarse.MouseHover += new System.EventHandler(this.btnRegistrarse_MouseHover);
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfContraseña.Location = new System.Drawing.Point(67, 230);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(110, 13);
            this.lblConfContraseña.TabIndex = 8;
            this.lblConfContraseña.Text = "Confirmar contraseña:";
            this.lblConfContraseña.MouseHover += new System.EventHandler(this.lblConfContraseña_MouseHover);
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(68, 246);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.PasswordChar = '●';
            this.txtConfContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtConfContraseña.TabIndex = 9;
            this.txtConfContraseña.MouseHover += new System.EventHandler(this.txtConfContraseña_MouseHover);
            // 
            // checkbxMC
            // 
            this.checkbxMC.AutoSize = true;
            this.checkbxMC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkbxMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkbxMC.Location = new System.Drawing.Point(198, 274);
            this.checkbxMC.Name = "checkbxMC";
            this.checkbxMC.Size = new System.Drawing.Size(117, 17);
            this.checkbxMC.TabIndex = 10;
            this.checkbxMC.Text = "Mostrar contraseña";
            this.checkbxMC.UseVisualStyleBackColor = false;
            this.checkbxMC.CheckedChanged += new System.EventHandler(this.checkbxMC_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(618, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(993, 525);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1655, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbxMC);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblCambiar);
            this.Controls.Add(this.lblPreg);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.lblRegistrarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.Label lblCambiar;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.CheckBox checkbxMC;
        private System.Windows.Forms.Button button1;
    }
}

