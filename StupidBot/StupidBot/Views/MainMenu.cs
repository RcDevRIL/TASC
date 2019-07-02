using StupidBot.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBot
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm(this);
            chatForm.Show();
            this.Hide();
        }

        private void btnContribution_Click(object sender, EventArgs e)
        {
            ContributionForm contributionForm = new ContributionForm(this);
            contributionForm.Show();
            this.Hide();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(this);
            adminForm.Show();
            this.Hide();
        }
    }
}
