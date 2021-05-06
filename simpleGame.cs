using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleGame
{
    public partial class simpleGame : Form
    {
        //code to link the class with the simplegame form
        logicClass logic_obj = new logicClass();

        public simpleGame()
        {
            InitializeComponent();
        }

        //code of the load button
        private void load_btn_Click(object sender, EventArgs e)
        {
            logic_obj.load();

            //code to display image in picture box on button click  
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simpleGame.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_show.Image = bmp_Object;


            //code to display sound with image in picture box on button click  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.loading);

            Sound_Object.Play();

            //code to appear and disapper the buttons
            spin_btn.Enabled = true;
            load_btn.Enabled = false;


        }


        //code of shoot on head button      
        private void spin_btn_Click(object sender, EventArgs e)
        {

            //code to display the message by clicking on spin button
            MessageBox.Show(logic_obj.spin().ToString());

            //code to display image in picture box on button click  
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simpleGame.Resources.spin.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_show.Image = bmp_Object;


            //code to display sound with image in picture box on button click  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.loading);

            Sound_Object.Play();

            //code to appear and disapper the buttons
            spin_btn.Enabled = false;
            shootonhead_btn.Enabled = true;
            shootaway_btn.Enabled = true;

        }
        //code of shoot on head button
        private void shootonhead_btn_Click(object sender, EventArgs e)
        {
            //code to call the logic class and pop_up message by button click
            if (logic_obj.shoot() == 0)
            {
                MessageBox.Show("Restart the game");
            }
            else
            {
                MessageBox.Show("Your Gun is Empty");
            }

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simpleGame.Resources.shoothead.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_show.Image = bmp_Object;


            //code to display sound with image in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.shoot);

            Sound_Object.Play();

        }
        //code of shootaway button
        private void shootaway_btn_Click(object sender, EventArgs e)
        {
            //code to call the logic class and pop_up message by button click
            if (logic_obj.chance < 2)
            {
                if (logic_obj.shoot() == 0)
                {
                    MessageBox.Show("Congrates!!!  You won the Game");
                    shootonhead_btn.Enabled = false;
                    shootaway_btn.Enabled = false;
                }
                else
                {
                    logic_obj.chance++;
                    if (logic_obj.chance == 2)
                    {
                        MessageBox.Show("Restart the game");
                        shootonhead_btn.Enabled = false;
                        shootaway_btn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your Gun is Empty");
                    }
                }
            }


            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simpleGame.Resources.shootaway.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            pic_show.Image = bmp_Object;


            //code to display sound with image in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.shoot);

            Sound_Object.Play();

        }
        // code to restart the application again by cliking on button 
        private void restart_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        // code to exit the application again by cliking on button 
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
