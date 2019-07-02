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

namespace StupidBot.Views
{
    public partial class ChatForm : Form
    {
        MainMenu mainForm;
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
            listViewChat.Items.Add(textSend);
            textBoxSend.Clear();
        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] H = new bool[5] { true, false, true, false, true };
            try
            {
                H[6] = true; throw new StupidException();
            } catch (StupidException ex)
            {
                ex.displayError(ex);
            }
            
        }
    }
}

