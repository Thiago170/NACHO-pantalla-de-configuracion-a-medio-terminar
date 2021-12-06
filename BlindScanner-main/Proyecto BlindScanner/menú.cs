using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Recognition;
using System.Media;

namespace Proyecto_BlindScanner
{
    public partial class menú : Form
    {
        public menú()
        {
            InitializeComponent();
        }
        
        
        private void btnAlarmasActivas_Click(object sender, EventArgs e)
        {
            Form form = new Alarmas_activas();
            form.Show();
            this.Close();
        }

        private void btnListasActivas_Click(object sender, EventArgs e)
        {
            Form form = new Listas_activas();
            form.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Form form = new Configuración();
            form.Show();
            this.Close();
        }

        private void btnAcercaApp_Click(object sender, EventArgs e)
        {
            Form form = new AcercaApp();
            form.Show();
            this.Close();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Form form = new Calendario();
            form.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form form = new Productos();
            form.Show();
            this.Close();
        }

        private void lblNomUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menú_Load(object sender, EventArgs e)
        {
            lblNomUsuario.Text = frmLogin.nomUser;
        }

        private void btnAlarmasActivas_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Alarmas activas, button ");

        }

        private void btnListasActivas_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Listas activas, button ");

        }

        private void btnConfiguracion_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Configuracion, Button ");

        }

        private void btnAcercaApp_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Acerca de App, Button ");

        }

        private void btnCalendario_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Calendario, Button ");
        }
    }
}
