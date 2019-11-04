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
        SpeechSynthesizer tts;
        Boolean ttsOn = false;
        QuestionResponse questionResponse = new QuestionResponse();

        public ChatForm(MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.mainForm.Show();
            this.Close();
        }

        //Quand l'utilisateur envoi envoi son texte
        private void btnSend_Click(object sender, EventArgs e)
        {
            String textSend = textBoxSend.Text;
            Random rnd = new Random();

            //on crée un TextBox avec un fond bleu pour les reperer plus facilement
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
            
            //On l'ajoute à la liste
            listViewChat.Controls.Add(textUser);

            //On nettoie la zone de texte
            textBoxSend.Clear();
            Log.StupidLogger.Info("Vous avez bien envoyer le message !! youpiiiii");

            string response = questionResponse.GetResponse(textSend);

            //On vérifie si la réponse contient .gif, .wav ou s'il s'agit uniquement d'un texte
            if (response.Contains(".gif"))
            {
                //On crée une zone pour l'image
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
                //On crée une réponse temporaire pour introduire la musique
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
                if (ttsOn) tts.SpeakAsync(textBot.Text);

                //On lance la lecture du fichier wav
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "Resources/" + response;
                player.Play();
            }

            if (!response.Contains(".wav") && !response.Contains(".gif"))
            {
                //On récupère la réponse en fonction de la question de l'utilisateur
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
                if (ttsOn) tts.SpeakAsync(textBot.Text);

            }
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
                MessageBox.Show("Attention faut pas pousser mémé dans les orties...", "Erreur personnalisée");
                Log.StupidLogger.Error("CE BOUTON GENERE UNE EXCEPTION! Message d'erreur: "+ exception.Message);
            }
        }

        private void tts_On(object sender, EventArgs e)
        {
            Log.StupidLogger.Debug(e.ToString());
            Log.StupidLogger.Debug(sender.ToString());
            if(sender.ToString().Contains("CheckState: 1"))
            {
                tts = new SpeechSynthesizer();
                tts.SetOutputToDefaultAudioDevice();
                tts.Volume = 100;
                tts.SpeakAsync("C'est l'heure de jouer");
                ttsOn = true;

            } else
            {
                ttsOn = false;
                tts.Dispose();
            }
        }
    }
}

