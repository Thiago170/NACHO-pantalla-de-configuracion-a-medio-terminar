using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Recognition;
using System.Media;

namespace Proyecto_BlindScanner
{
    public partial class CreadorDeListas : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public static string nomLista = "";

        public CreadorDeListas()
        {
            InitializeComponent();
        }

        private void CreadorDeListas_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbProyectoBlindScanner.accdb;";
            con.Open();
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {           
            listBxProductos.Items.Add(txtNomProducto.Text + " (" + numUDCantProductos.Value + ")");
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (listBxProductos.SelectedIndex == -1)
            {
               MessageBox.Show("Seleccione un producto para quitar de la lista");
            }
            else 
            {
                listBxProductos.Items.Remove(listBxProductos.SelectedItem);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            if (txtNomLista.Text == "")
            {
                MessageBox.Show("Escriba un nombre para su lista");
            }
            else
            {
                string[] arr = new string[listBxProductos.Items.Count];

                for (int i = 0; i < listBxProductos.Items.Count; i++)
                {
                    arr[i] = Convert.ToString(listBxProductos.Items[i]);
                }

                string arrJoin = string.Join(",", arr);
                string sql = "INSERT INTO tblProductos (ListaProductos, NomLista) VALUES ('" + arrJoin + "', '" + txtNomLista.Text + "');";
                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                nomLista = txtNomLista.Text;
                new Listas_activas().Show();
                this.Hide();
            }
        }
    }
}
