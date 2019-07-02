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

namespace StupidBot.Views
{
    public partial class ChatForm : Form
    {
        MainMenu mainForm;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            String textSend = textBoxSend.Text;

            RichTextBox text = new RichTextBox
            {
                Width = 300,
                Multiline = true,
                ReadOnly = true,
                Text = textSend
            };
            listViewChat.Controls.Add(text);

            textBoxSend.Clear();
            Log.StupidLogger.Info("Vous avez bien envoyer le message !! youpiiiii");

            string response = questionResponse.GetResponse(textSend);

            RichTextBox text2 = new RichTextBox
            {
                Width = 300,
                Multiline = true,
                ReadOnly = true,
                Text = response
            };
            listViewChat.Controls.Add(text2);

        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

