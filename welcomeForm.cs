using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleGame
{
    public partial class welcomeForm : Form
    {
        //code to link the logic class to the welcome form
        simpleGame simpleGame_obj = new simpleGame();

        public welcomeForm()
        {
            InitializeComponent();
        }

        //code to display the start button to start the application
        private void start_btn_Click(object sender, EventArgs e)
        {
            simpleGame_obj.Show();
        }
    }
}
