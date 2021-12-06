using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BlindScanner
{
    public partial class Calendario : Form
    {
        public static string valueLblFecha = "";

        public Calendario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menuForm = new menú();
            menuForm.Show();
            this.Hide();
        }

        private void btnListasCal_Click(object sender, EventArgs e)
        {
            string fechaElecta = Convert.ToString(monthCalendar1.SelectionRange.Start.ToShortDateString());
            valueLblFecha = fechaElecta;

            new CreadorDeListas().Show();
            this.Hide();
        }


        private void btnAlarmasCal_Click(object sender, EventArgs e)
        {
        }
    }
}
