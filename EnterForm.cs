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
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //close the form without doing anything
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Local data
            string name;
            string cont;
            int pop;

            //Validate data
            if ( int.TryParse(populationTextBox.Text, out pop) && pop >= 0)
            {
                //Input string data
                name = nameTextBox.Text;
                cont = continentTextBox.Text;

                //Create and populate a Nation object 
                Nation nat = new Nation(name, cont, pop);
                //Add nation object to static world object
                World.theWorld.AddNation(nat);

                //We are done, so close the Enter Form
                this.Close(); 
            }
            else
            {
                //Display error message but leave the form showing
                MessageBox.Show("Population should be a whole number.");
            }
        }
    }
}
