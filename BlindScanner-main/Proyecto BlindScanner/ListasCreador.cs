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
    public partial class ListasCreador : Form
    {
        public ListasCreador()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numUDCant.Value == 1)
            {
                listbxLista.Items.Add(txtNomProducto.Text);
            }
            else
            {
                listbxLista.Items.Add(txtNomProducto.Text + " (" + numUDCant.Value + ")");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            listbxLista.Items.Remove(listbxLista.SelectedItem);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
