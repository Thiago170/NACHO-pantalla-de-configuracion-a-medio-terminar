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
    public partial class frmLogin : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public static string nomUser = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbProyectoBlindScanner.accdb;";
            con.Open();
        }

        private void btnIniciaSesión_Click(object sender, EventArgs e)
        {
            string login = "SELECT * FROM tblUsuarios WHERE NomUsuario = '" + txtNomUsuario.Text + "' and Contraseña = '" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(login, con);
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {
                if (dr.Read() == true)
                {
                    nomUser = txtNomUsuario.Text;
                    menú menuForm = new menú();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Campo de usuario o contraseña inválido, Intente nuevamente", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtNomUsuario.Focus();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Este nombre de usuario no existe");
            }
            finally
            {
                con.Close();
            }
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            new frmRegistro().Show();
            this.Hide();
        }

        private void checkbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
            }
        }

        private void lblNomUsuario_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Nombre de usuario , label ");
        }

        private void txtNomUsuario_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Nombre de usuario, textbox ");

        }

        private void lblContraseña_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Contraseña,label");

        }

        private void checkbxMC_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(" Mostrar Contraseña, checkbox");

        }

        private void lblCambiar_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("si no tienes cuenta presiona aqui para registrarte");

        }
    }
}
