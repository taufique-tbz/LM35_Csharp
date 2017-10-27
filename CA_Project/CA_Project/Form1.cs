using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Project
{
    public partial class Form1 : MaterialForm 
    {
        public Form1()
        {
            InitializeComponent();
            var skinMgr = MaterialSkinManager.Instance;
            skinMgr.AddFormToManage(this);
            skinMgr.Theme = MaterialSkinManager.Themes.LIGHT;
            skinMgr.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.BLACK);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Connection comport = new Connection();
        Boolean portConnection = false;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (comport.Connect(9600, "I'M ARDUINO", 4, 8, 16))
            {
                labelconnection.Text = "Connection Successful - Connected to  " + comport.port;
                portConnection = true;
                tempreader.Start();
            }
            else
            {
                labelconnection.Text = "Not connected . . . ";
                portConnection = false;
                tempreader.Stop();
            }
        }


        private void tempreader_Tick(object sender, EventArgs e)
        {
            labeltemp.Text = comport.Message(4, 8, 32);
        }
    }
}
