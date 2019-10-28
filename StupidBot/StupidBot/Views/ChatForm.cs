using StupidBot.Models;
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

namespace StupidBot.Views
{
    public partial class ChatForm : Form
    {
        MainMenu mainForm;
        SpeechSynthesizer tts = new SpeechSynthesizer();
        public ChatForm(MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            tts.SetOutputToDefaultAudioDevice();
            tts.Volume = 100;
            tts.SpeakAsync("C'est l'heure de jouer");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.mainForm.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String textSend = textBoxSend.Text;
            tts.SpeakAsync(textSend);
            listViewChat.Items.Add(textSend);
            textBoxSend.Clear();
            Log.StupidLogger.Info("Vous avez bien envoyer le message !! youpiiiii");
        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

