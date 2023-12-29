using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Windows.Input;

namespace Asterix_and_Obelix_XXL2_Remake_Trainer
{
    public partial class Main : Form
    {
        //Asterix
        bool Helmet_Check;
        bool Health_Check;
        bool Shield_Check;
        bool Fly_Check;

        string Fly_Height;

        string Force_X_Cordinate;
        string Force_Y_Cordinate;
        string Force_Z_Cordinate;

        //Obelix
        bool Obelix_X_Freeze_Check;
        bool Obelix_Z_Freeze_Check;

        string Obelix_Current_Position_X;
        string Obelix_Current_Position_Z;

        //Base
        public DialogResult result;
        bool Already_Clicked;

        //Hook
        public bool Found_PID;
        public Mem meme = new Mem();


        //Asterix
        string helmetAddress = "base+00B597FC,80,654,4F4,384,25C,124,4C";

        string healthAddress = "base+00B597FC,30,24,44,38,2FC,40";

        string shieldAddress = "base+00B597FC,0,C,1F8,1C,88,124,44";

        string yAxelAddress = "base+00B57D3C,124,268,60,4,4,108,3F8";

        string xAxelAddress = "base+00B59078,130,268,4,11C,3E0";

        string zAxelAddress = "base+00B5C430,1AC,10,60,14,12C,8,3F4";

        //Obelix
        string Obelix_X_Address = "base+00B6DF24,48,10C,130,74,130,12C,3F4";

        string Obelix_Z_Address = "base+00B6DF24,2C,2D8,74,290,4,108,3E0";


        //No Game Found MessageBox
        string Message01 = "No Game Found to Inject into! Start Game first";
        string Title01 = "Error";


        //About Message
        string Message02 = "Trainer programmed by JayC and Designed by AnimArts";
        string Title02 = "About";

        //Error Cordinates
        string Message03 = "Cordinates cant be NUL";
        string Title03 = "Error";

        //Error Flight cant be active
        string Message04 = "Fly Hack cant be active while doing so!";
        string Title04 = "Error";




        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Asterix
            Helmet_Check = false;
            Health_Check = false;
            Shield_Check = false;
            Fly_Check = false;

            FlyHeightInput.Text = "30";
            Fly_Height = "30";


            //Obelix
            Obelix_Current_Position_X = "";
            Obelix_Current_Position_Z = "";

            Obelix_X_Freeze_Check = false;
            Obelix_Z_Freeze_Check = false;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //Hook
            if (Found_PID == false)
            {

                int PID = meme.GetProcIdFromName("oXXL2Game");
                if (PID > 0)
                {
                    //Hook
                    meme.OpenProcess(PID);
                    MainTimer.Start();

                    //Base
                    Found_PID = true;
                    Already_Clicked = false;
                }
            }

            //Asterix
            if (Helmet_Check == true)
            {
                meme.WriteMemory(helmetAddress, "int", "999999");
            }

            if (Health_Check == true)
            {
                meme.WriteMemory(healthAddress, "int", "20");
            }

            if (Shield_Check == true)
            {
                meme.WriteMemory(shieldAddress, "int", "16");
            }          
                      
            if (Fly_Check == true)
            {
                SubTimer.Start();
            }
            else
            {
                SubTimer.Stop();
            }

            if (Found_PID == true)
            {
                CurrentXCordinates.Text = meme.ReadFloat(xAxelAddress).ToString();
                CurrentYCordinates.Text = meme.ReadFloat(yAxelAddress).ToString();
                CurrentZCordinates.Text = meme.ReadFloat(zAxelAddress).ToString();
            }


            //Obelix
            if (Obelix_X_Freeze_Check == true)
            {
                Obelix_Current_Position_X = meme.ReadFloat(Obelix_X_Address).ToString();
                meme.WriteMemory(Obelix_X_Address, "float", Obelix_Current_Position_X);
            }

            if (Obelix_Z_Freeze_Check == true)
            {
                Obelix_Current_Position_Z = meme.ReadFloat(Obelix_Z_Address).ToString();
                meme.WriteMemory(Obelix_Z_Address, "float", Obelix_Current_Position_Z);
            }


            //Base
            if (result == DialogResult.OK)
            {
                if (Found_PID == false)
                {
                    Already_Clicked = true;
                    HealthCheckbox.Checked = false;
                    HelmetsCheckbox.Checked = false;
                    ShieldCheckbox.Checked = false;
                    FlyCheckbox.Checked = false;
                }
            }

        }

        private void HelmetsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                if (Helmet_Check == false)
                {
                    Helmet_Check = true;
                }
                else
                {
                    Helmet_Check = false;
                }
            }
            else if (Already_Clicked == false)
            {
                IllegalStart();
            }
        }

        private void HealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                if (Health_Check == false)
                {
                    Health_Check = true;
                }
                else
                {
                    Health_Check = false;
                }
            }
            else if (Already_Clicked == false)
            {
                IllegalStart();
            }
        }

        private void ShieldCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                if (Shield_Check == false)
                {
                    Shield_Check = true;
                }
                else
                {
                    Shield_Check = false;
                }
            }
            else if (Already_Clicked == false)
            {
                IllegalStart();
            }
        }

        private void FlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                if (Fly_Check == false)
                {
                    Fly_Check = true;
                }
                else
                {
                    Fly_Check = false;
                }
            }
            else if (Already_Clicked == false)
            {
                IllegalStart();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message02, Title02, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IllegalStart()
        {
            result = MessageBox.Show(Message01, Title01, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SubTimer_Tick(object sender, EventArgs e)
        {
            if (Fly_Check == true)
            {
                meme.WriteMemory(yAxelAddress, "float", Fly_Height);
            }
        }

        private void AcceptHeightButton_Click(object sender, EventArgs e)
        {
            Force_Y_Cordinate = YCordinateInput.Text;

            if (Fly_Check == true)
            {
                MessageBox.Show(Message04, Title04, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Fly_Check == false)
            {
                if (Force_Y_Cordinate == "")
                {
                    MessageBox.Show(Message03, Title03, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    meme.WriteMemory(yAxelAddress, "float", Force_Y_Cordinate);
                }
            }
        }

        private void AcceptXButton_Click(object sender, EventArgs e)
        {
            Force_X_Cordinate = XCordinateBox.Text;

            if (Force_X_Cordinate == "")
            {
                MessageBox.Show(Message03, Title03, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                meme.WriteMemory(xAxelAddress, "float", Force_X_Cordinate);
            }
        }

        private void AcceptZButton_Click(object sender, EventArgs e)
        {
            Force_Z_Cordinate = ZCordinateBox.Text;

            if (Force_Z_Cordinate == "")
            {
                MessageBox.Show(Message03, Title03, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                meme.WriteMemory(zAxelAddress, "float", Force_Z_Cordinate);
            }
        }

        private void AcceptNewPermHight_Click(object sender, EventArgs e)
        {
            Fly_Height = FlyHeightInput.Text;
        }

        private void FreezeObelixXCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Obelix_X_Freeze_Check == false)
            {
                Obelix_X_Freeze_Check = true;
            }
            else
            {
                Obelix_X_Freeze_Check = false;
            }
        }

        private void FreezeObelixZCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Obelix_Z_Freeze_Check == false)
            {
                Obelix_Z_Freeze_Check = true;
            }
            else
            {
                Obelix_Z_Freeze_Check = false;
            }
        }
    }
}
