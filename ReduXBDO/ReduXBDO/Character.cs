using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace ReduXBDO
{
    public partial class Character : MetroFramework.Forms.MetroForm
    {

        public Character()



        {




            try
            {


                TextBox.CheckForIllegalCrossThreadCalls = false;

                int attack = Convert.ToInt32(Properties.Settings.Default["Attack"]);
                int casting = Convert.ToInt32(Properties.Settings.Default["Casting"]);
                int movement = Convert.ToInt32(Properties.Settings.Default["Movement"]);

                Process[] pname = Process.GetProcessesByName("BlackDesert64");
                if (pname.Length == 0)
                {
                    MessageBox.Show("Black Desert is not running please start BDO and try again try again.");
                }
                else
                    MessageBox.Show("Ready!");

                InitializeComponent();



                var handle = GetConsoleWindow();

                // Hide
                ShowWindow(handle, SW_HIDE);

                AttackTrack.Value = attack;
                CastingTrack.Value = casting;
                MovementTrack.Value = movement;

                System.Diagnostics.Process[] myprocesses = System.Diagnostics.Process.GetProcessesByName("BlackDesert64");
                if (myprocesses.Length != 0)
                {
                    Process[] processes = Process.GetProcessesByName("BlackDesert64"); 
                    ProcessID = processes[0].Id;
                    ProcessHandle = OpenProcess(0x001F0FFF/*PROCESS_ALL_ACCESS*/, false, ProcessID);
                    byte[] nopThis = { 0x90, 0x90, 0x90, 0x90 };// 4 bytes
                    byte[] nopThis2 = { 0x90, 0x90 };// 2 bytes

                    // unless you're 200IQ you won't understand what's the usage of that.
                    WriteProcessMemory(ProcessHandle, (IntPtr)0x140830A25, nopThis, 4/*amount of bytes written(4)*/, 0);


                   // const int SW_SHOW = 5;
                    //Console.Title = "ReduX - DEBUG ";
                    //ShowWindow(handle, SW_SHOW);
                    //Console.WriteLine("Success");



                }

            }
            catch
            {

            }




        }

        private static int ProcessID = -1;
        private static IntPtr ProcessHandle = IntPtr.Zero;

        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, [Out] int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, [Out] int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

       

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        VAMemory vam = new VAMemory();

        IntPtr baseAddress;
        IntPtr localPlayer;


        IntPtr attackSpeed;
        IntPtr castingtSpeed;
        IntPtr movementSpeed;

        IntPtr MaxZoom;

        IntPtr StrikerShards;

        IntPtr StunStiffnessFreeze;
        IntPtr KnockdownBound;
        IntPtr Grapple;
        IntPtr KnockbackFloating;




        private void Character_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {

                Properties.Settings.Default["Attack"] = AttackTrack.Value.ToString();
                Properties.Settings.Default["Casting"] = CastingTrack.Value.ToString();
                Properties.Settings.Default["Movement"] = MovementTrack.Value.ToString();
                    Properties.Settings.Default.Save();

            }
            catch
            {

            }


        }

        private void Character_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Properties.Settings.Default["Attack"] = AttackTrack.Value.ToString();
                Properties.Settings.Default["Casting"] = CastingTrack.Value.ToString();
                Properties.Settings.Default["Movement"] = MovementTrack.Value.ToString();
                Properties.Settings.Default.Save();
            }
            catch
            {

            }

        }

        private void ValueTimer_Tick(object sender, EventArgs e)
        {
            try
            {




                label5.Text = AttackTrack.Value.ToString();
                label6.Text = CastingTrack.Value.ToString();
                label7.Text = MovementTrack.Value.ToString();

                vam.WriteInteger(attackSpeed, AttackTrack.Value);
                vam.WriteInteger(castingtSpeed, CastingTrack.Value);
                vam.WriteInteger(movementSpeed, MovementTrack.Value);

              
            }
            catch
            {

            }








        }





        private void Character_Load(object sender, EventArgs e)
        {
            try
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            catch
            {

            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {




                vam.processName = "BlackDesert64";
                if (vam.CheckProcess())
                {

                    baseAddress = (IntPtr)vam.getBaseAddress;

                    localPlayer = IntPtr.Add(baseAddress, 0x20C33A8);

                    attackSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 3076);
                    castingtSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 3080);
                    movementSpeed = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 3072);

                    StrikerShards = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 952);

                    StunStiffnessFreeze = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4180);
                    KnockdownBound = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4176);
                    Grapple = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4188);
                    KnockbackFloating = IntPtr.Add((IntPtr)vam.ReadUInt64(localPlayer), 4184);

                    MaxZoom = (IntPtr)0x141F3D4F0;




                    vam.WriteInteger(attackSpeed, AttackTrack.Value);
                    vam.WriteInteger(castingtSpeed, CastingTrack.Value);
                    vam.WriteInteger(movementSpeed, MovementTrack.Value);
                }
            }
            catch
            {

            }
        }

        private void StrikerShardTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                vam.WriteInteger(StrikerShards, 30);
            }
            catch
            {

            }

        }

        private void bunifuSwitch2_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch2.Value == true)
            {
                StrikerShardTimer.Start();
            }
            else if (bunifuSwitch2.Value == false)
            {
                StrikerShardTimer.Stop();
            }
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                vam.WriteInteger(StunStiffnessFreeze, 1500000);
                vam.WriteInteger(KnockdownBound, 1500000);
                vam.WriteInteger(Grapple, 1500000);
                vam.WriteInteger(KnockbackFloating, 1500000);



            }
            else if (bunifuSwitch1.Value == false)
            {
                vam.WriteInteger(StunStiffnessFreeze, 0);
                vam.WriteInteger(KnockdownBound, 0);
                vam.WriteInteger(Grapple, 0);
                vam.WriteInteger(KnockbackFloating, 0);
            }
        }

        private void bunifuSwitch4_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch4.Value == true)
            {
                TopMost = true;



            }
            else if (bunifuSwitch4.Value == false)
            {
                TopMost = false;

            }
        }

        private void bunifuSwitch3_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch3.Value == true)
            {
                vam.WriteFloat(MaxZoom, 5000);


            }
            else if (bunifuSwitch3.Value == false)
            {

                vam.WriteFloat(MaxZoom, 900);


            }
        }

     
    }
}