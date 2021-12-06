
namespace Proyecto_BlindScanner
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblIniciaSesión = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPreg = new System.Windows.Forms.Label();
            this.lblCambiar = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciaSesión = new System.Windows.Forms.Button();
            this.checkbxMC = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIniciaSesión
            // 
            this.lblIniciaSesión.AutoSize = true;
            this.lblIniciaSesión.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIniciaSesión.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIniciaSesión.Location = new System.Drawing.Point(67, 39);
            this.lblIniciaSesión.Name = "lblIniciaSesión";
            this.lblIniciaSesión.Size = new System.Drawing.Size(67, 13);
            this.lblIniciaSesión.TabIndex = 0;
            this.lblIniciaSesión.Text = "Inicia Sesión";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomUsuario.Location = new System.Drawing.Point(67, 86);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNomUsuario.TabIndex = 1;
            this.lblNomUsuario.Text = "Nombre de Usuario:\r\n";
            this.lblNomUsuario.MouseHover += new System.EventHandler(this.lblNomUsuario_MouseHover);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(67, 165);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.MouseHover += new System.EventHandler(this.lblContraseña_MouseHover);
            // 
            // lblPreg
            // 
            this.lblPreg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreg.Location = new System.Drawing.Point(69, 375);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(134, 20);
            this.lblPreg.TabIndex = 0;
            this.lblPreg.Text = "No tienes una cuenta?";
            // 
            // lblCambiar
            // 
            this.lblCambiar.AutoSize = true;
            this.lblCambiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCambiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCambiar.Location = new System.Drawing.Point(69, 407);
            this.lblCambiar.Name = "lblCambiar";
            this.lblCambiar.Size = new System.Drawing.Size(55, 13);
            this.lblCambiar.TabIndex = 3;
            this.lblCambiar.Text = "Registrate";
            this.lblCambiar.Click += new System.EventHandler(this.lblCambiar_Click);
            this.lblCambiar.MouseHover += new System.EventHandler(this.lblCambiar_MouseHover);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(70, 102);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 4;
            this.txtNomUsuario.MouseHover += new System.EventHandler(this.txtNomUsuario_MouseHover);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(70, 181);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // btnIniciaSesión
            // 
            this.btnIniciaSesión.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciaSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciaSesión.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciaSesión.Location = new System.Drawing.Point(72, 242);
            this.btnIniciaSesión.Name = "btnIniciaSesión";
            this.btnIniciaSesión.Size = new System.Drawing.Size(98, 67);
            this.btnIniciaSesión.TabIndex = 6;
            this.btnIniciaSesión.Text = "Inicia Sesión";
            this.btnIniciaSesión.UseVisualStyleBackColor = false;
            this.btnIniciaSesión.Click += new System.EventHandler(this.btnIniciaSesión_Click);
            // 
            // checkbxMC
            // 
            this.checkbxMC.AutoSize = true;
            this.checkbxMC.BackColor = System.Drawing.SystemColors.Desktop;
            this.checkbxMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkbxMC.Location = new System.Drawing.Point(197, 211);
            this.checkbxMC.Name = "checkbxMC";
            this.checkbxMC.Size = new System.Drawing.Size(117, 17);
            this.checkbxMC.TabIndex = 7;
            this.checkbxMC.Text = "Mostrar contraseña";
            this.checkbxMC.UseVisualStyleBackColor = false;
            this.checkbxMC.CheckedChanged += new System.EventHandler(this.checkbxMC_CheckedChanged);
            this.checkbxMC.MouseHover += new System.EventHandler(this.checkbxMC_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Proyecto_BlindScanner.Properties.Resources.Logo_Oficial_1;
            this.button1.Location = new System.Drawing.Point(674, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(990, 432);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1717, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbxMC);
            this.Controls.Add(this.btnIniciaSesión);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblCambiar);
            this.Controls.Add(this.lblPreg);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.lblIniciaSesión);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciaSesión;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.Label lblCambiar;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciaSesión;
        private System.Windows.Forms.CheckBox checkbxMC;
        private System.Windows.Forms.Button button1;
    }
}