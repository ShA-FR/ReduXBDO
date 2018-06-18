using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReduXBDO
{
    public partial class LifeSkills : MetroFramework.Forms.MetroForm
    {
        public LifeSkills()
        {
            try
            {

                TextBox.CheckForIllegalCrossThreadCalls = false;


                Process[] pname = Process.GetProcessesByName("BlackDesert64");
                if (pname.Length == 0)
                {
                    MessageBox.Show("Black Desert is not running please start BDO and try again try again.");
                }
                else
                    MessageBox.Show("Ready!");



                InitializeComponent();


                int Gathering = Convert.ToInt32(Properties.Settings.Default["Gathering"]);
                int Critical = Convert.ToInt32(Properties.Settings.Default["Critical"]);
                int Fishing = Convert.ToInt32(Properties.Settings.Default["Fishing"]);
                int Luck = Convert.ToInt32(Properties.Settings.Default["Luck"]);


                GatherTrack.Value = Gathering;
                CriticalTrack.Value = Critical;
                FishingTrack.Value = Fishing;
                LuckTrack.Value = Luck;



            }

            catch
            {

            }
        }

        VAMemory vam = new VAMemory();


        IntPtr baseAddress;
        IntPtr localPlayer;

    

        IntPtr CriticalBar;
        IntPtr FishingBar;
        IntPtr LuckBar;

        IntPtr curGather;
     


        IntPtr CookingSpeed;
        IntPtr AlchemySpeed;



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(CookingSpeed, 100000);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(CookingSpeed, 150000);

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(CookingSpeed, 200000);

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(CookingSpeed, 250000);

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(CookingSpeed, 300000);

        }

        private void LifeSkillsTimer_Tick(object sender, EventArgs e)
        {
            vam.processName = "BlackDesert64";

            if (vam.CheckProcess())
            {



                baseAddress = (IntPtr)vam.getBaseAddress;
                localPlayer = IntPtr.Add(baseAddress, 0x20C33A8);
               

                curGather = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 18320);
               
                CriticalBar = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 18296);
                FishingBar = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 18312);
                LuckBar = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 18304);

                CookingSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4276);
                AlchemySpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4272);

                label5.Text = GatherTrack.Value.ToString();
                label6.Text = CriticalTrack.Value.ToString();
                label7.Text = FishingTrack.Value.ToString();
                label8.Text = LuckTrack.Value.ToString();



                vam.WriteInteger(curGather, GatherTrack.Value);
                vam.WriteInteger(CriticalBar, CriticalTrack.Value);
                vam.WriteInteger(FishingBar, FishingTrack.Value);
                vam.WriteInteger(LuckBar, LuckTrack.Value);




            }
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(AlchemySpeed, 100000);

        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(AlchemySpeed, 150000);

        }


        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(AlchemySpeed, 200000);

        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(AlchemySpeed, 250000);

        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            vam.WriteInteger(AlchemySpeed, 300000);

        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                TopMost = true;



            }
            else if (bunifuSwitch1.Value == false)
            {
                TopMost = false;

            }
        }

        private void LifeSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Properties.Settings.Default["Gathering"] = GatherTrack.Value.ToString();
                Properties.Settings.Default["Critical"] = CriticalTrack.Value.ToString();
                Properties.Settings.Default["Fishing"] = FishingTrack.Value.ToString();
                Properties.Settings.Default["Luck"] = LuckTrack.Value.ToString();

                Properties.Settings.Default.Save();

            }
            catch
            {

            }
        }
    }

}
