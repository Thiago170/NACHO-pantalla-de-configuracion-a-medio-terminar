namespace Proyecto_BlindScanner
{
    partial class ListasCreador
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
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.listbxLista = new System.Windows.Forms.ListBox();
            this.numUDCant = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNomLista = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.NomLista = new System.Windows.Forms.Label();
            this.lblNomProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCant)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Location = new System.Drawing.Point(64, 63);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNomProducto.TabIndex = 0;
            // 
            // listbxLista
            // 
            this.listbxLista.FormattingEnabled = true;
            this.listbxLista.Location = new System.Drawing.Point(304, 199);
            this.listbxLista.Name = "listbxLista";
            this.listbxLista.Size = new System.Drawing.Size(120, 95);
            this.listbxLista.TabIndex = 1;
            // 
            // numUDCant
            // 
            this.numUDCant.Location = new System.Drawing.Point(64, 129);
            this.numUDCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCant.Name = "numUDCant";
            this.numUDCant.Size = new System.Drawing.Size(120, 20);
            this.numUDCant.TabIndex = 2;
            this.numUDCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(64, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Añadir producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNomLista
            // 
            this.txtNomLista.Location = new System.Drawing.Point(318, 63);
            this.txtNomLista.Name = "txtNomLista";
            this.txtNomLista.Size = new System.Drawing.Size(100, 20);
            this.txtNomLista.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(595, 44);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(117, 39);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear lista";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(595, 199);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(83, 68);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar producto";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // NomLista
            // 
            this.NomLista.AutoSize = true;
            this.NomLista.Location = new System.Drawing.Point(315, 33);
            this.NomLista.Name = "NomLista";
            this.NomLista.Size = new System.Drawing.Size(94, 13);
            this.NomLista.TabIndex = 7;
            this.NomLista.Text = "Nombre de la lista:";
            // 
            // lblNomProd
            // 
            this.lblNomProd.AutoSize = true;
            this.lblNomProd.Location = new System.Drawing.Point(64, 44);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(109, 13);
            this.lblNomProd.TabIndex = 8;
            this.lblNomProd.Text = "Nombre del producto:";
            // 
            // ListasCreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.NomLista);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNomLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numUDCant);
            this.Controls.Add(this.listbxLista);
            this.Controls.Add(this.txtNomProducto);
            this.Name = "ListasCreador";
            this.Text = "ListasCreador";
            ((System.ComponentModel.ISupportInitialize)(this.numUDCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomProducto;
        private System.Windows.Forms.ListBox listbxLista;
        private System.Windows.Forms.NumericUpDown numUDCant;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNomLista;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label NomLista;
        private System.Windows.Forms.Label lblNomProd;
    }
}