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
    public partial class Mount : MetroFramework.Forms.MetroForm
    {
        public Mount()
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


                int Speed = Convert.ToInt32(Properties.Settings.Default["MountSpeed"]);
                int Turn = Convert.ToInt32(Properties.Settings.Default["MountTurn"]);
                int Break = Convert.ToInt32(Properties.Settings.Default["MountBreak"]);
                int Accel = Convert.ToInt32(Properties.Settings.Default["MountAccel"]);


                MountSpeedTrack.Value = Speed;
                MountTurnTrack.Value = Turn;
                MountBreakTrack.Value = Break;
                MountAccelTrack.Value = Accel;

            }

            catch
            {

            }
        }

        VAMemory vam = new VAMemory();

        IntPtr baseAddress;
        IntPtr localVehicle;



        IntPtr mountSpeed;
        IntPtr mountTurn;
        IntPtr mountBreak;
        IntPtr mountAccel;

    


        private void MountTimer_Tick(object sender, EventArgs e)
        {
            localVehicle = IntPtr.Add(baseAddress, 0x20C3898);
            baseAddress = (IntPtr)vam.getBaseAddress;

            mountSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8908);
            mountTurn = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8912);
            mountBreak = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8916);
            mountAccel = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8904);

            label5.Text = MountSpeedTrack.Value.ToString();
            label6.Text = MountTurnTrack.Value.ToString();
            label7.Text = MountBreakTrack.Value.ToString();
            label8.Text = MountAccelTrack.Value.ToString();

            vam.WriteInteger(mountSpeed, MountSpeedTrack.Value);
            vam.WriteInteger(mountTurn, MountTurnTrack.Value);
            vam.WriteInteger(mountBreak, MountBreakTrack.Value);
            vam.WriteInteger(mountAccel, MountAccelTrack.Value);
         
        }

        private void Mount_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Properties.Settings.Default["MountSpeed"] = MountSpeedTrack.Value.ToString();
                Properties.Settings.Default["MountTurn"] = MountTurnTrack.Value.ToString();
                Properties.Settings.Default["MountBreak"] = MountBreakTrack.Value.ToString();
                Properties.Settings.Default["MountAccel"] = MountAccelTrack.Value.ToString();

                Properties.Settings.Default.Save();

            }
            catch
            {

            }
        }

        private void Mount_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                Properties.Settings.Default["MountSpeed"] = MountSpeedTrack.Value.ToString();
                Properties.Settings.Default["MountTurn"] = MountTurnTrack.Value.ToString();
                Properties.Settings.Default["MountBreak"] = MountBreakTrack.Value.ToString();
                Properties.Settings.Default["MountAccel"] = MountAccelTrack.Value.ToString();

                Properties.Settings.Default.Save();

            }
            catch
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vam.processName = "BlackDesert64";
            if (vam.CheckProcess())
            {
                localVehicle = IntPtr.Add(baseAddress, 0x20C3898);
                baseAddress = (IntPtr)vam.getBaseAddress;

                mountSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8908);
                mountTurn = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8912);
                mountBreak = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8916);
                mountAccel = IntPtr.Add((IntPtr)vam.ReadUInt64(localVehicle), 8904);

                label5.Text = MountSpeedTrack.Value.ToString();
                label6.Text = MountTurnTrack.Value.ToString();
                label7.Text = MountBreakTrack.Value.ToString();
                label8.Text = MountAccelTrack.Value.ToString();
            }
        }

        private void Mount_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
    }
}

