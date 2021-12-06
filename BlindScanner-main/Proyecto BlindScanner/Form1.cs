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
    public partial class frmRegistro : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbProyectoBlindScanner.accdb;";
            con.Open();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtNomUsuario.Text == "" && txtContraseña.Text == "" && txtConfContraseña.Text == "")
            {
                MessageBox.Show("Campos de usuario y contraseña están incompletos", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtContraseña.Text == txtConfContraseña.Text)
            {
                string register = "INSERT INTO tblUsuarios (NomUsuario, Contraseña) VALUES ('" + txtNomUsuario.Text + "','" + txtContraseña.Text + "')";

                try
                {
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();

                    txtNomUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtConfContraseña.Text = "";

                    MessageBox.Show("Tu cuenta ha sido creada exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Este nombre de usuario ya existe, intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales , Por favor, reescríbalas ", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Text = "";
                txtConfContraseña.Text = "";
                txtContraseña.Focus();
            }
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void checkbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                txtConfContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
                txtConfContraseña.PasswordChar = '•';
            }
        }

        private void lblNomUsuario_MouseHover(object sender, EventArgs e)
        {
            
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Nombre de usuario ");

        }

        private void txtNomUsuario_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Escriba su Usuario ");

        }

        private void lblContraseña_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Contraseña");

        }

        private void txtContraseña_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Escriba su Contraseña ");

        }

        private void txtConfContraseña_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Confirme su contraseña ");

        }

        private void btnRegistrarse_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Botón para registrarse ");

        }

        private void lblConfContraseña_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Confirmar Contraseña ");

        }

        private void lblCambiar_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Si ya tiene cuenta presione aqui ");

        }
    }
}
