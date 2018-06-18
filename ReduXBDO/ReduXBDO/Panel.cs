using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ReduXBDO
{



 /*
 *       _____              _ _ _              _____ _                _   _  ___                      _   _____      _ _         _   _   _                  _   ______ _ _  ___  _   _     _   _____  ________   ___ _____  
 *      / ____|            | (_) |        _   / ____| |       /\     | | | |/ (_)             /\     | | |  __ \    | | |       | | | \ | |                | | |  ____| (_)/ _ \| | | |   | | |  __ \|  ____\ \ / / |  __ \ 
 *     | |     _ __ ___  __| |_| |_ ___  (_) | (___ | |__    /  \    | | | ' / _ _____   _   /  \    | | | |__) |__ | | | ___   | | |  \| | ___  ___ _ __  | | | |__  | |_| | | | |_| |_  | | | |__) | |__   \ V /| | |__) |
 *     | |    | '__/ _ \/ _` | | __/ __|      \___ \| '_ \  / /\ \   | | |  < | |_  / | | | / /\ \   | | |  ___/ _ \| | |/ _ \  | | | . ` |/ _ \/ _ \ '__| | | |  __| | | | | | | __| __| | | |  _  /|  __|   > < | |  _  / 
 *     | |____| | |  __/ (_| | | |_\__ \  _   ____) | | | |/ ____ \  | | | . \| |/ /| |_| |/ ____ \  | | | |  | (_) | | | (_) | | | | |\  |  __/  __/ |    | | | |____| | | |_| | |_| |_  | | | | \ \| |____ / . \|_| | \ \ 
 *      \_____|_|  \___|\__,_|_|\__|___/ (_) |_____/|_| |_/_/    \_\ | | |_|\_\_/___|\__,_/_/    \_\ | | |_|   \___/|_|_|\___/  | | |_| \_|\___|\___|_|    | | |______|_|_|\___/ \__|\__| | | |_|  \_\______/_/ \_(_)_|  \_\
 *                                                                   | |                             | |                        | |                        | |                            | |                               
 *                                                                   |_|                             |_|                        |_|                        |_|                            |_|                               
 */




    public partial class Panel : MetroFramework.Forms.MetroForm
    {
        public Mem m = new Mem();

        public Panel()
        {
            InitializeComponent();
            var handle = GetConsoleWindow();
            // Hide
            ShowWindow(handle, SW_HIDE);
        
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("BlackDesert64");
                if (pname.Length == 0)
                {
                    MessageBox.Show("Black Desert is not running please start BDO and try again.");
                }
                else
                {

                    Character CharHack = new Character();
                    CharHack.Show();
                }
            }
            catch
            {
            }
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {


                Process[] pname = Process.GetProcessesByName("BlackDesert64");
                if (pname.Length == 0)
                {
                    MessageBox.Show("Black Desert is not running please start BDO and try again.");
                }
                else
                {
                    Mount MountHack = new Mount();
                    MountHack.Show();
                }
            }
            catch
            {
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

            try

            {

                Process[] pname = Process.GetProcessesByName("BlackDesert64");
                if (pname.Length == 0)
                {
                    MessageBox.Show("Black Desert is not running please start BDO and try again.");
                }
                else
                {
                    LifeSkills LifeSkillHack = new LifeSkills();
                    LifeSkillHack.Show();
                }
            }
            catch
            {
            }
        }

      

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }

  /*
 *              __   _____      __  _____  ______ _      ______           _____ ______          
 *              \ \ / (_) \    / / |  __ \|  ____| |    |  ____|   /\    / ____|  ____|         
 *      ______   \ V / _ \ \  / /  | |__) | |__  | |    | |__     /  \  | (___ | |__     ______ 
 *     |______|   > < | | \ \/ /   |  _  /|  __| | |    |  __|   / /\ \  \___ \|  __|   |______|
 *               / . \| |  \  /    | | \ \| |____| |____| |____ / ____ \ ____) | |____          
 *              /_/ \_\_|   \/     |_|  \_\______|______|______/_/    \_\_____/|______|         
 *                                                                                              
 *                                                                                              
 */

}
