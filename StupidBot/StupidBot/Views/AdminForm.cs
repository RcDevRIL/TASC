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
    public partial class AdminForm : Form
    {

        MainMenu mainMenu;

        public AdminForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
