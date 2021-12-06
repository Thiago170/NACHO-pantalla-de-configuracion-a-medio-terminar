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
    public partial class Configuración : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        bool canread = false;
        public static int VolSS;
        public Configuración()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menuForm = new menú();
            menuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canread = !canread;
        }
        SoundPlayer simpleSound;

        private void play1()
        {
            simpleSound = new SoundPlayer(Application.StartupPath + @"\Sonido\Sonido1.wav");
            simpleSound.Play();

        }
        private void play2()
        {
            simpleSound = new SoundPlayer(Application.StartupPath + @"\Sonido\Sonido2.wav");
            simpleSound.Play();
        }
        private void play3()
        {
            simpleSound = new SoundPlayer(Application.StartupPath + @"\Sonido\Sonido3.wav");
            simpleSound.Play();
        }
        private void trckBrVolumen_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trckBrVolumen, trckBrVolumen.Value.ToString());
            VolSS = trckBrVolumen.Value;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
           // ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            //toolTip1.AutoPopDelay = 5000;
            //toolTip1.InitialDelay = 1000;
            //toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            //toolTip1.ShowAlways = true;
        }

        private void cmbBxTonosAlarma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTonosAlarma.SelectedIndex == cmbBxTonosAlarma.Items.IndexOf("Tono 1"))
            {
                play1();
            }

            else if (cmbBxTonosAlarma.SelectedIndex == cmbBxTonosAlarma.Items.IndexOf("Tono 2"))
            {
                play2();
            }
            else
            {
                play3();
            }
        }

        private void cmbBxTonosAlarma_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Seleccione un tono, combobox ");
        }

        private void trckBrVolumen_Scroll_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trckBrVolumen, trckBrVolumen.Value.ToString());
            VolSS = trckBrVolumen.Value;
        }

        private void Configuración_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }
    }
}
