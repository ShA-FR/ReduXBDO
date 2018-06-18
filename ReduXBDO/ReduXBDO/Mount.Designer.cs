namespace ReduXBDO
{
    partial class Mount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mount));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MountSpeedTrack = new FlatUI.FlatTrackBar();
            this.MountTurnTrack = new FlatUI.FlatTrackBar();
            this.MountBreakTrack = new FlatUI.FlatTrackBar();
            this.MountAccelTrack = new FlatUI.FlatTrackBar();
            this.MountTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MountAccelTrack);
            this.groupBox1.Controls.Add(this.MountBreakTrack);
            this.groupBox1.Controls.Add(this.MountTurnTrack);
            this.groupBox1.Controls.Add(this.MountSpeedTrack);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horse / Boat Tweaker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mount Speed :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mount Turn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mount Break :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mount Accel :";
            // 
            // MountSpeedTrack
            // 
            this.MountSpeedTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MountSpeedTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountSpeedTrack.Location = new System.Drawing.Point(87, 24);
            this.MountSpeedTrack.Maximum = 9000000;
            this.MountSpeedTrack.Minimum = 0;
            this.MountSpeedTrack.Name = "MountSpeedTrack";
            this.MountSpeedTrack.ShowValue = false;
            this.MountSpeedTrack.Size = new System.Drawing.Size(240, 23);
            this.MountSpeedTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.MountSpeedTrack.TabIndex = 4;
            this.MountSpeedTrack.Text = "AttackTrack";
            this.MountSpeedTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountSpeedTrack.Value = 0;
            // 
            // MountTurnTrack
            // 
            this.MountTurnTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MountTurnTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountTurnTrack.Location = new System.Drawing.Point(87, 52);
            this.MountTurnTrack.Maximum = 9000000;
            this.MountTurnTrack.Minimum = 0;
            this.MountTurnTrack.Name = "MountTurnTrack";
            this.MountTurnTrack.ShowValue = false;
            this.MountTurnTrack.Size = new System.Drawing.Size(240, 23);
            this.MountTurnTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.MountTurnTrack.TabIndex = 5;
            this.MountTurnTrack.Text = "AttackTrack";
            this.MountTurnTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountTurnTrack.Value = 0;
            // 
            // MountBreakTrack
            // 
            this.MountBreakTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MountBreakTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountBreakTrack.Location = new System.Drawing.Point(87, 77);
            this.MountBreakTrack.Maximum = 9000000;
            this.MountBreakTrack.Minimum = 0;
            this.MountBreakTrack.Name = "MountBreakTrack";
            this.MountBreakTrack.ShowValue = false;
            this.MountBreakTrack.Size = new System.Drawing.Size(240, 23);
            this.MountBreakTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.MountBreakTrack.TabIndex = 6;
            this.MountBreakTrack.Text = "AttackTrack";
            this.MountBreakTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountBreakTrack.Value = 0;
            // 
            // MountAccelTrack
            // 
            this.MountAccelTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MountAccelTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountAccelTrack.Location = new System.Drawing.Point(87, 103);
            this.MountAccelTrack.Maximum = 9000000;
            this.MountAccelTrack.Minimum = 0;
            this.MountAccelTrack.Name = "MountAccelTrack";
            this.MountAccelTrack.ShowValue = false;
            this.MountAccelTrack.Size = new System.Drawing.Size(240, 23);
            this.MountAccelTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.MountAccelTrack.TabIndex = 7;
            this.MountAccelTrack.Text = "AttackTrack";
            this.MountAccelTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MountAccelTrack.Value = 0;
            // 
            // MountTimer
            // 
            this.MountTimer.Enabled = true;
            this.MountTimer.Interval = 10;
            this.MountTimer.Tick += new System.EventHandler(this.MountTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "200000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "200000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "200000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "200000";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(87, 17);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 8;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = false;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Top Most :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bunifuSwitch1);
            this.groupBox2.Location = new System.Drawing.Point(11, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // Mount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mount";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "ReduX - Mount";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mount_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mount_FormClosed);
            this.Load += new System.EventHandler(this.Mount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FlatUI.FlatTrackBar MountAccelTrack;
        private FlatUI.FlatTrackBar MountBreakTrack;
        private FlatUI.FlatTrackBar MountTurnTrack;
        private FlatUI.FlatTrackBar MountSpeedTrack;
        private System.Windows.Forms.Timer MountTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
    }
}