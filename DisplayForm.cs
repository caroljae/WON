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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }
        //Method to display world information in list box
        public void displayWorld()
        {
            //Declare list of strings
            List<string> worldInfo;

            //Get list of nation paragraphs from World object
            worldInfo = World.theWorld.GetInfo();

            //Display the paragraphs in the list box
            foreach (string natInfo in worldInfo)
            {
                displayListBox.Items.Add(natInfo);
            }
        }

     

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayForm_Load_1(object sender, EventArgs e)
        {
            // Display the world information when the form opens
            displayWorld();
        }
    }
}
