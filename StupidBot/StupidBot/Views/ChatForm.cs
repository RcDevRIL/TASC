using StupidBot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace StupidBot.Views
{
    public partial class ChatForm : Form
    {
        MainMenu mainForm;
        SpeechSynthesizer tts = new SpeechSynthesizer();
        QuestionResponse questionResponse = new QuestionResponse();

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
            Random rnd = new Random();

            RichTextBox textUser = new RichTextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = textSend,
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                SelectionAlignment = HorizontalAlignment.Right,

            };
            Size size = TextRenderer.MeasureText(textUser.Text, textUser.Font);
            textUser.Width = size.Width + 10;
            textUser.Height = size.Height + 10;
            //textUser.Location = new Point(listViewChat.Width, 0);
            //textUser.Anchor = AnchorStyles.None;

            listViewChat.Controls.Add(textUser);

            textBoxSend.Clear();
            Log.StupidLogger.Info("Vous avez bien envoyer le message !! youpiiiii");

            string response = questionResponse.GetResponse(textSend);


            int time = rnd.Next(5000, 8000);
            if (response.Contains(".gif"))
            {
                PictureBox pb1 = new PictureBox
                {
                    Image = Image.FromFile("Resources/" + response),
                    MaximumSize = new Size(700, 700),
                    SizeMode = PictureBoxSizeMode.AutoSize
                };
                listViewChat.Controls.Add(pb1);
                listViewChat.ScrollControlIntoView(pb1);
            }

            if (response.Contains(".wav"))
            {
                RichTextBox textBot = new RichTextBox
                {
                    Width = 300,
                    Multiline = true,
                    ReadOnly = true,
                    Text = "C'est parti !",
                    BackColor = Color.WhiteSmoke,
                    ForeColor = Color.Black
                };

                size = TextRenderer.MeasureText(textBot.Text, textBot.Font);
                textBot.Width = size.Width + 10;
                textBot.Height = size.Height + 10;
                listViewChat.Controls.Add(textBot);
                listViewChat.ScrollControlIntoView(textBot);
                tts.SpeakAsync(textBot.Text);

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "Resources/" + response;
                player.Play();
            }

            if (!response.Contains(".wav") && !response.Contains(".gif"))
            {
                RichTextBox textBot = new RichTextBox
                {
                    Width = 300,
                    Multiline = true,
                    ReadOnly = true,
                    Text = response,
                    BackColor = Color.WhiteSmoke,
                    ForeColor = Color.Black
                };

                size = TextRenderer.MeasureText(textBot.Text, textBot.Font);
                textBot.Width = size.Width + 10;
                textBot.Height = size.Height + 10;
                listViewChat.Controls.Add(textBot);
                listViewChat.ScrollControlIntoView(textBot);
                tts.SpeakAsync(textBot.Text);

            }


        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = 2;
                var b = 5;
                if (a + b == a - b) Log.StupidLogger.Debug("a = " + a + " et b = " + b);
                else throw new StupidException();
            } catch(Exception exception)
            {
                Log.StupidLogger.Error("CE BOUTON GENERE UNE EXCEPTION! Message d'erreur: "+ exception.Message);
            }
        }
    }
}

