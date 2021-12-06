
namespace Proyecto_BlindScanner
{
    partial class Configuración
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
            this.components = new System.ComponentModel.Container();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAudio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trckBrVolumen = new System.Windows.Forms.TrackBar();
            this.trckBrBrillo = new System.Windows.Forms.TrackBar();
            this.cmbBxTonosAlarma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trckBrVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrBrillo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(140, 89);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(34, 13);
            this.lblAudio.TabIndex = 1;
            this.lblAudio.Text = "Audio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visión";
            // 
            // trckBrVolumen
            // 
            this.trckBrVolumen.Location = new System.Drawing.Point(102, 227);
            this.trckBrVolumen.Maximum = 100;
            this.trckBrVolumen.Name = "trckBrVolumen";
            this.trckBrVolumen.Size = new System.Drawing.Size(148, 45);
            this.trckBrVolumen.TabIndex = 3;
            this.trckBrVolumen.Scroll += new System.EventHandler(this.trckBrVolumen_Scroll_1);
            // 
            // trckBrBrillo
            // 
            this.trckBrBrillo.Location = new System.Drawing.Point(486, 227);
            this.trckBrBrillo.Maximum = 100;
            this.trckBrBrillo.Name = "trckBrBrillo";
            this.trckBrBrillo.Size = new System.Drawing.Size(142, 45);
            this.trckBrBrillo.TabIndex = 6;
            // 
            // cmbBxTonosAlarma
            // 
            this.cmbBxTonosAlarma.FormattingEnabled = true;
            this.cmbBxTonosAlarma.Items.AddRange(new object[] {
            "Tono 1",
            "Tono 2",
            "Tono 3"});
            this.cmbBxTonosAlarma.Location = new System.Drawing.Point(102, 145);
            this.cmbBxTonosAlarma.Name = "cmbBxTonosAlarma";
            this.cmbBxTonosAlarma.Size = new System.Drawing.Size(121, 21);
            this.cmbBxTonosAlarma.TabIndex = 7;
            this.cmbBxTonosAlarma.SelectedIndexChanged += new System.EventHandler(this.cmbBxTonosAlarma_SelectedIndexChanged);
            this.cmbBxTonosAlarma.MouseHover += new System.EventHandler(this.cmbBxTonosAlarma_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "AUDIO DESCRIPTIVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBxTonosAlarma);
            this.Controls.Add(this.trckBrBrillo);
            this.Controls.Add(this.trckBrVolumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAudio);
            this.Controls.Add(this.btnVolver);
            this.Name = "Configuración";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuración_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckBrVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrBrillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trckBrVolumen;
        private System.Windows.Forms.TrackBar trckBrBrillo;
        private System.Windows.Forms.ComboBox cmbBxTonosAlarma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}