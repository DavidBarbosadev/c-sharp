namespace eSports
{
    partial class eSportsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eSportsform));
            this.lblname = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.lblgame = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lstboxplayersenrolled = new System.Windows.Forms.ListBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpicture = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNmatchplayed = new System.Windows.Forms.Label();
            this.lblvictories = new System.Windows.Forms.Label();
            this.txtmatchesplayed = new System.Windows.Forms.TextBox();
            this.txtvictories = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblwinratio = new System.Windows.Forms.Label();
            this.txtwinratio = new System.Windows.Forms.TextBox();
            this.lblgenderselect = new System.Windows.Forms.Label();
            this.lblgenderchosen = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(59, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(59, 63);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(103, 20);
            this.lblbirth.TabIndex = 1;
            this.lblbirth.Text = "Date of Birth:";
            // 
            // lblgame
            // 
            this.lblgame.AutoSize = true;
            this.lblgame.Location = new System.Drawing.Point(59, 238);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(57, 20);
            this.lblgame.TabIndex = 2;
            this.lblgame.Text = "Game:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(114, 24);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(258, 26);
            this.txtname.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(497, 535);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 37);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lstboxplayersenrolled
            // 
            this.lstboxplayersenrolled.FormattingEnabled = true;
            this.lstboxplayersenrolled.ItemHeight = 20;
            this.lstboxplayersenrolled.Location = new System.Drawing.Point(378, 27);
            this.lstboxplayersenrolled.Name = "lstboxplayersenrolled";
            this.lstboxplayersenrolled.Size = new System.Drawing.Size(523, 264);
            this.lstboxplayersenrolled.TabIndex = 8;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(59, 131);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(67, 20);
            this.lblgender.TabIndex = 9;
            this.lblgender.Text = "Gender:";
            // 
            // lbldisplay
            // 
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldisplay.Location = new System.Drawing.Point(63, 397);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(609, 135);
            this.lbldisplay.TabIndex = 10;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(378, 535);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(113, 37);
            this.btnregister.TabIndex = 12;
            this.btnregister.Text = "&Enrol";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(114, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 0);
            this.label6.TabIndex = 13;
            // 
            // lblpicture
            // 
            this.lblpicture.Image = ((System.Drawing.Image)(resources.GetObject("lblpicture.Image")));
            this.lblpicture.Location = new System.Drawing.Point(678, 307);
            this.lblpicture.Name = "lblpicture";
            this.lblpicture.Size = new System.Drawing.Size(223, 265);
            this.lblpicture.TabIndex = 14;
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.Red;
            this.date.Location = new System.Drawing.Point(165, 60);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(207, 26);
            this.date.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "League of Legends",
            "Counter Strike Global Offencive",
            "Dota II"});
            this.comboBox1.Location = new System.Drawing.Point(125, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // lblNmatchplayed
            // 
            this.lblNmatchplayed.AutoSize = true;
            this.lblNmatchplayed.Location = new System.Drawing.Point(59, 284);
            this.lblNmatchplayed.Name = "lblNmatchplayed";
            this.lblNmatchplayed.Size = new System.Drawing.Size(203, 20);
            this.lblNmatchplayed.TabIndex = 17;
            this.lblNmatchplayed.Text = "Number of Matches Played:";
            // 
            // lblvictories
            // 
            this.lblvictories.AutoSize = true;
            this.lblvictories.Location = new System.Drawing.Point(59, 328);
            this.lblvictories.Name = "lblvictories";
            this.lblvictories.Size = new System.Drawing.Size(152, 20);
            this.lblvictories.TabIndex = 18;
            this.lblvictories.Text = "Number of Victories:";
            // 
            // txtmatchesplayed
            // 
            this.txtmatchesplayed.Location = new System.Drawing.Point(258, 281);
            this.txtmatchesplayed.Name = "txtmatchesplayed";
            this.txtmatchesplayed.Size = new System.Drawing.Size(114, 26);
            this.txtmatchesplayed.TabIndex = 19;
            // 
            // txtvictories
            // 
            this.txtvictories.Location = new System.Drawing.Point(217, 325);
            this.txtvictories.Name = "txtvictories";
            this.txtvictories.Size = new System.Drawing.Size(155, 26);
            this.txtvictories.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 535);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 37);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(165, 108);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 22;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(165, 144);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 23;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // lblwinratio
            // 
            this.lblwinratio.AutoSize = true;
            this.lblwinratio.Location = new System.Drawing.Point(60, 362);
            this.lblwinratio.Name = "lblwinratio";
            this.lblwinratio.Size = new System.Drawing.Size(106, 20);
            this.lblwinratio.TabIndex = 24;
            this.lblwinratio.Text = "Win Ratio(%):";
            // 
            // txtwinratio
            // 
            this.txtwinratio.Location = new System.Drawing.Point(173, 362);
            this.txtwinratio.Name = "txtwinratio";
            this.txtwinratio.ReadOnly = true;
            this.txtwinratio.Size = new System.Drawing.Size(199, 26);
            this.txtwinratio.TabIndex = 25;
            // 
            // lblgenderselect
            // 
            this.lblgenderselect.AutoSize = true;
            this.lblgenderselect.Location = new System.Drawing.Point(59, 171);
            this.lblgenderselect.Name = "lblgenderselect";
            this.lblgenderselect.Size = new System.Drawing.Size(113, 20);
            this.lblgenderselect.TabIndex = 26;
            this.lblgenderselect.Text = "Gender select:";
            // 
            // lblgenderchosen
            // 
            this.lblgenderchosen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgenderchosen.Location = new System.Drawing.Point(178, 171);
            this.lblgenderchosen.Name = "lblgenderchosen";
            this.lblgenderchosen.Size = new System.Drawing.Size(79, 25);
            this.lblgenderchosen.TabIndex = 27;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(234, 535);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(112, 37);
            this.btnremove.TabIndex = 28;
            this.btnremove.Text = "&Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // eSportsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 599);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.lblgenderchosen);
            this.Controls.Add(this.lblgenderselect);
            this.Controls.Add(this.txtwinratio);
            this.Controls.Add(this.lblwinratio);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtvictories);
            this.Controls.Add(this.txtmatchesplayed);
            this.Controls.Add(this.lblvictories);
            this.Controls.Add(this.lblNmatchplayed);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblpicture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lstboxplayersenrolled);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblgame);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.lblname);
            this.Name = "eSportsform";
            this.Text = "Tournament Enrol Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lstboxplayersenrolled;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpicture;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNmatchplayed;
        private System.Windows.Forms.Label lblvictories;
        private System.Windows.Forms.TextBox txtmatchesplayed;
        private System.Windows.Forms.TextBox txtvictories;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblwinratio;
        private System.Windows.Forms.TextBox txtwinratio;
        private System.Windows.Forms.Label lblgenderselect;
        private System.Windows.Forms.Label lblgenderchosen;
        private System.Windows.Forms.Button btnremove;
    }
}

