using StupidBot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBot.Views
{
    public partial class AdminForm : Form
    {

        MainMenu mainMenu;
        QuestionResponse _QandAMockDatabase;
        List<QuestionResponse> _test;
        int _listIndex;

        public AdminForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            _listIndex = -1 ;
            _QandAMockDatabase = new QuestionResponse();
            displayQandA(_QandAMockDatabase);
            this.Update();
        }

        private void displayQandA(QuestionResponse qAndA)
        {
            _test = qAndA.FindAllQuestionsResponses();
            foreach(QuestionResponse qA in _test)
            {
                this.listBoxCorrespondance.Items.Add(qA.Question + " = " + qA.Reponse);
                Log.StupidLogger.Debug(qA.Question + " = " + qA.Reponse);
            }
            this.listBoxCorrespondance.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void listBoxCorrespondance_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._listIndex = this.listBoxCorrespondance.SelectedIndex;
        }

        private void btnDeleteThis_Click(object sender, EventArgs e)
        {
            if (_listIndex > -1)
            {
                string qAndAToDelete = this.listBoxCorrespondance.Items[_listIndex].ToString();
                string qToDelete = qAndAToDelete.Split('=')[0].Trim();
                Log.StupidLogger.Debug("qToDelete = " + qToDelete);
                string aToDelete = qAndAToDelete.Split('=')[1].Trim();
                Log.StupidLogger.Debug("aToDelete = " + aToDelete);
                _QandAMockDatabase.DeleteResponse(qToDelete,aToDelete);
                clearList();
                displayQandA(_QandAMockDatabase);
            }
            else
            {
                Log.StupidLogger.Debug("Invalid index, plz select an item to delete...");
            }

        }

        private void clearList()
        {
            this.listBoxCorrespondance.Items.Clear();
            this.listBoxCorrespondance.Update();
        }

        private void AddQandA_Click(object sender, EventArgs e)
        {
            Form add = new Form();
            
            add.ShowDialog();
        }
    }
}
