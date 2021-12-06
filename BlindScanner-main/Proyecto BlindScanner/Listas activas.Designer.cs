
namespace Proyecto_BlindScanner
{
    partial class Listas_activas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantListas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colListas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtns = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblCantListas
            // 
            this.lblCantListas.AutoSize = true;
            this.lblCantListas.Location = new System.Drawing.Point(372, 97);
            this.lblCantListas.Name = "lblCantListas";
            this.lblCantListas.Size = new System.Drawing.Size(94, 13);
            this.lblCantListas.TabIndex = 5;
            this.lblCantListas.Text = "listas programadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colListas,
            this.colBtns});
            this.dataGridView1.Location = new System.Drawing.Point(295, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 202);
            this.dataGridView1.TabIndex = 6;
            // 
            // colListas
            // 
            this.colListas.HeaderText = "Listas";
            this.colListas.Name = "colListas";
            // 
            // colBtns
            // 
            this.colBtns.HeaderText = "Btns";
            this.colBtns.Name = "colBtns";
            this.colBtns.Text = "Ver";
            // 
            // Listas_activas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCantListas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "Listas_activas";
            this.Text = "Listas_activas";
            this.Load += new System.EventHandler(this.Listas_activas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantListas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListas;
        private System.Windows.Forms.DataGridViewButtonColumn colBtns;
    }
}