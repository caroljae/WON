using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Nations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enterNationButton_Click(object sender, EventArgs e)
        {
            //Create the Enter form
            EnterForm enterForm = new World_of_Nations.EnterForm();

            //Show the Enter form as a modal dialog box
            //It must return before the program can contine
            enterForm.ShowDialog(); //modal
        }

        private void displayWorldButton_Click(object sender, EventArgs e)
        {
            //Create the Display form
            DisplayForm displayForm = new World_of_Nations.DisplayForm();

            //Show the Display form as a modeless dialog box
            //It will remain open while the program continues
            displayForm.Show();
        }
    }
}
