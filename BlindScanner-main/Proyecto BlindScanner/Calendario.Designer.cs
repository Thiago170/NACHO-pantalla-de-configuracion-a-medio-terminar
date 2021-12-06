
namespace Proyecto_BlindScanner
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListasCal = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAlarmasCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 66);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListasCal
            // 
            this.btnListasCal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListasCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListasCal.Image = ((System.Drawing.Image)(resources.GetObject("btnListasCal.Image")));
            this.btnListasCal.Location = new System.Drawing.Point(182, 284);
            this.btnListasCal.Name = "btnListasCal";
            this.btnListasCal.Size = new System.Drawing.Size(133, 112);
            this.btnListasCal.TabIndex = 2;
            this.btnListasCal.UseVisualStyleBackColor = false;
            this.btnListasCal.Click += new System.EventHandler(this.btnListasCal_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.ForeColor = System.Drawing.Color.Transparent;
            this.monthCalendar1.Location = new System.Drawing.Point(348, 234);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 4;
            // 
            // btnAlarmasCal
            // 
            this.btnAlarmasCal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlarmasCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmasCal.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarmasCal.Image")));
            this.btnAlarmasCal.ImageKey = "(ninguno)";
            this.btnAlarmasCal.Location = new System.Drawing.Point(650, 284);
            this.btnAlarmasCal.Name = "btnAlarmasCal";
            this.btnAlarmasCal.Size = new System.Drawing.Size(144, 112);
            this.btnAlarmasCal.TabIndex = 3;
            this.btnAlarmasCal.UseVisualStyleBackColor = false;
            this.btnAlarmasCal.Click += new System.EventHandler(this.btnAlarmasCal_Click);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 676);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnAlarmasCal);
            this.Controls.Add(this.btnListasCal);
            this.Controls.Add(this.btnVolver);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListasCal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAlarmasCal;
    }
}