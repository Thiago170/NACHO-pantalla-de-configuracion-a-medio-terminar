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
    public partial class Listas_activas : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Listas_activas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menuForm = new menú();
            menuForm.Show();
            this.Hide();
        }


        private void Listas_activas_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbProyectoBlindScanner.accdb;";
            con.Open();

            string sql = "SELECT NomLista FROM tblProductos";
            cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbDataReader dr = cmd.ExecuteReader();


            try
            {
                while (dr.Read())
                {
                    /*string[] stateList = new string[1];

                    for (int i = 1; i <= 1; i++)
                    {
                        stateList[i - 1] = dr.GetString(0);
                    }

                    for (int i = 0; i < stateList.Length; i++)
                    {
                        stateList[i].ToString();
                    }*/

                   // dataGridView1.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                dr.Close();
                con.Close();
            }

            if(dataGridView1.Rows.Count== 0)
            {
                lblCantListas.Text = "No hay listas programadas";
                dataGridView1.Visible = false;
            }
            else
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    lblCantListas.Text = dataGridView1.Rows.Count + " lista programada";
                    dataGridView1.Visible = true;
                }
                else 
                {
                    lblCantListas.Text = dataGridView1.Rows.Count + " listas programadas";
                    dataGridView1.Visible = true;
                }
            }
        } 
    }
}

