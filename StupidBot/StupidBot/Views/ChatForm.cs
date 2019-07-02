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
        public ChatForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

