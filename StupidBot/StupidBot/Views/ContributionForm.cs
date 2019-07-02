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
    public partial class ContributionForm : Form
    {

        MainMenu mainMenu;

        public ContributionForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionResponse questionResponse = new QuestionResponse();
            questionResponse.AddResponse(textBoxQuestion.Text, textBoxReponse.Text);
        }
    }
}
