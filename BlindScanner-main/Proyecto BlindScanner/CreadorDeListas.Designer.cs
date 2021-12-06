
namespace Proyecto_BlindScanner
{
    partial class CreadorDeListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreadorDeListas));
            this.numUDCantProductos = new System.Windows.Forms.NumericUpDown();
            this.txtNomLista = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.listBxProductos = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDCantProductos
            // 
            this.numUDCantProductos.Location = new System.Drawing.Point(111, 470);
            this.numUDCantProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numUDCantProductos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCantProductos.Name = "numUDCantProductos";
            this.numUDCantProductos.Size = new System.Drawing.Size(200, 27);
            this.numUDCantProductos.TabIndex = 0;
            this.numUDCantProductos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNomLista
            // 
            this.txtNomLista.Location = new System.Drawing.Point(461, 284);
            this.txtNomLista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomLista.Name = "txtNomLista";
            this.txtNomLista.Size = new System.Drawing.Size(261, 27);
            this.txtNomLista.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(926, 156);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(205, 155);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Location = new System.Drawing.Point(111, 377);
            this.txtNomProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(164, 27);
            this.txtNomProducto.TabIndex = 5;
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirProducto.Location = new System.Drawing.Point(111, 549);
            this.btnAñadirProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(258, 136);
            this.btnAñadirProducto.TabIndex = 6;
            this.btnAñadirProducto.Text = "Añadir Producto";
            this.btnAñadirProducto.UseVisualStyleBackColor = false;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitarProducto.Location = new System.Drawing.Point(906, 587);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(205, 120);
            this.btnQuitarProducto.TabIndex = 7;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // listBxProductos
            // 
            this.listBxProductos.FormattingEnabled = true;
            this.listBxProductos.ItemHeight = 19;
            this.listBxProductos.Location = new System.Drawing.Point(461, 377);
            this.listBxProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBxProductos.Name = "listBxProductos";
            this.listBxProductos.Size = new System.Drawing.Size(397, 308);
            this.listBxProductos.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(894, 436);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(507, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Creacion de listas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(461, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de la lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Producto:";
            // 
            // CreadorDeListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1297, 780);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBxProductos);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnAñadirProducto);
            this.Controls.Add(this.txtNomProducto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNomLista);
            this.Controls.Add(this.numUDCantProductos);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreadorDeListas";
            this.Text = "Crear nueva lista";
            this.Load += new System.EventHandler(this.CreadorDeListas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDCantProductos;
        private System.Windows.Forms.TextBox txtNomLista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNomProducto;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.ListBox listBxProductos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}