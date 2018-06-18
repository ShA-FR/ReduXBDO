namespace ReduXBDO
{
    partial class Character
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValueTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuSwitch2 = new Bunifu.Framework.UI.BunifuSwitch();
            this.StrikerShardTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuSwitch3 = new Bunifu.Framework.UI.BunifuSwitch();
            this.label14 = new System.Windows.Forms.Label();
            this.AttackTrack = new FlatUI.FlatTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CastingTrack = new FlatUI.FlatTrackBar();
            this.MovementTrack = new FlatUI.FlatTrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuSwitch4 = new Bunifu.Framework.UI.BunifuSwitch();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "200000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "200000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "200000";
            // 
            // ValueTimer
            // 
            this.ValueTimer.Enabled = true;
            this.ValueTimer.Interval = 10;
            this.ValueTimer.Tick += new System.EventHandler(this.ValueTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label4.Location = new System.Drawing.Point(298, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 7);
            this.label4.TabIndex = 8;
            this.label4.Text = "2.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Stun/Stiffness/Freeze :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Knockdown/Bound :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Grapple :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Knockback/Floating :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Resistance Max :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Unlimited Striker Shards :";
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.Enabled = false;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(137, 17);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 10;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = false;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // bunifuSwitch2
            // 
            this.bunifuSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch2.BorderRadius = 0;
            this.bunifuSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch2.Location = new System.Drawing.Point(137, 42);
            this.bunifuSwitch2.Name = "bunifuSwitch2";
            this.bunifuSwitch2.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch2.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch2.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch2.TabIndex = 11;
            this.bunifuSwitch2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch2.Value = false;
            this.bunifuSwitch2.Click += new System.EventHandler(this.bunifuSwitch2_Click);
            // 
            // StrikerShardTimer
            // 
            this.StrikerShardTimer.Interval = 10;
            this.StrikerShardTimer.Tick += new System.EventHandler(this.StrikerShardTimer_Tick);
            // 
            // bunifuSwitch3
            // 
            this.bunifuSwitch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch3.BorderRadius = 0;
            this.bunifuSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch3.Location = new System.Drawing.Point(137, 66);
            this.bunifuSwitch3.Name = "bunifuSwitch3";
            this.bunifuSwitch3.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch3.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch3.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch3.TabIndex = 12;
            this.bunifuSwitch3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch3.Value = false;
            this.bunifuSwitch3.Click += new System.EventHandler(this.bunifuSwitch3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Max Zoom :";
            // 
            // AttackTrack
            // 
            this.AttackTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AttackTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.AttackTrack.Location = new System.Drawing.Point(108, 23);
            this.AttackTrack.Maximum = 9000000;
            this.AttackTrack.Minimum = 0;
            this.AttackTrack.Name = "AttackTrack";
            this.AttackTrack.ShowValue = false;
            this.AttackTrack.Size = new System.Drawing.Size(207, 23);
            this.AttackTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.AttackTrack.TabIndex = 0;
            this.AttackTrack.Text = "AttackTrack";
            this.AttackTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.AttackTrack.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attack Speed :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Casting Speed :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Movement Speed :";
            // 
            // CastingTrack
            // 
            this.CastingTrack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CastingTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.CastingTrack.Location = new System.Drawing.Point(108, 52);
            this.CastingTrack.Maximum = 9000000;
            this.CastingTrack.Minimum = 0;
            this.CastingTrack.Name = "CastingTrack";
            this.CastingTrack.ShowValue = false;
            this.CastingTrack.Size = new System.Drawing.Size(207, 23);
            this.CastingTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.CastingTrack.TabIndex = 6;
            this.CastingTrack.Text = "CastTrack";
            this.CastingTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.CastingTrack.Value = 0;
            // 
            // MovementTrack
            // 
            this.MovementTrack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovementTrack.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MovementTrack.Location = new System.Drawing.Point(108, 81);
            this.MovementTrack.Maximum = 9000000;
            this.MovementTrack.Minimum = 0;
            this.MovementTrack.Name = "MovementTrack";
            this.MovementTrack.ShowValue = false;
            this.MovementTrack.Size = new System.Drawing.Size(207, 23);
            this.MovementTrack.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.MovementTrack.TabIndex = 7;
            this.MovementTrack.Text = "rack";
            this.MovementTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MovementTrack.Value = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MovementTrack);
            this.groupBox1.Controls.Add(this.CastingTrack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AttackTrack);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed Tweaker";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.bunifuSwitch4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.bunifuSwitch2);
            this.groupBox2.Controls.Add(this.bunifuSwitch3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.bunifuSwitch1);
            this.groupBox2.Location = new System.Drawing.Point(23, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Top Most :";
            // 
            // bunifuSwitch4
            // 
            this.bunifuSwitch4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch4.BorderRadius = 0;
            this.bunifuSwitch4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch4.Location = new System.Drawing.Point(137, 91);
            this.bunifuSwitch4.Name = "bunifuSwitch4";
            this.bunifuSwitch4.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch4.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch4.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch4.TabIndex = 14;
            this.bunifuSwitch4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch4.Value = false;
            this.bunifuSwitch4.Click += new System.EventHandler(this.bunifuSwitch4_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 297);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Character";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "ReduX - Character";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Character_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Character_FormClosed);
            this.Load += new System.EventHandler(this.Character_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer ValueTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch2;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer StrikerShardTimer;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch3;
        private FlatUI.FlatTrackBar AttackTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FlatUI.FlatTrackBar CastingTrack;
        private FlatUI.FlatTrackBar MovementTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch4;
    }
}