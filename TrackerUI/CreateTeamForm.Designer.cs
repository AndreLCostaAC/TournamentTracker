namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.AddMemberLabel = new System.Windows.Forms.Button();
            this.SelectTeamLabel = new System.Windows.Forms.ComboBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMember = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMemberLabel
            // 
            this.AddMemberLabel.AutoSize = true;
            this.AddMemberLabel.Location = new System.Drawing.Point(71, 271);
            this.AddMemberLabel.Name = "AddMemberLabel";
            this.AddMemberLabel.Size = new System.Drawing.Size(170, 41);
            this.AddMemberLabel.TabIndex = 25;
            this.AddMemberLabel.Text = "Add Member";
            this.AddMemberLabel.UseVisualStyleBackColor = true;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.FormattingEnabled = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(46, 230);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(259, 21);
            this.SelectTeamLabel.TabIndex = 23;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RoundLabel.Location = new System.Drawing.Point(41, 186);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(246, 29);
            this.RoundLabel.TabIndex = 22;
            this.RoundLabel.Text = "Select Team Member";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(46, 140);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(259, 20);
            this.TournamentNameValue.TabIndex = 19;
            this.TournamentNameValue.TextChanged += new System.EventHandler(this.TournamentNameValue_TextChanged);
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AccessibleName = "TeamNameLabel";
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(41, 93);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(145, 29);
            this.TeamOneScoreLabel.TabIndex = 18;
            this.TeamOneScoreLabel.Text = "Team Name";
            this.TeamOneScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Header.Location = new System.Drawing.Point(41, 25);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(152, 29);
            this.Header.TabIndex = 17;
            this.Header.Text = "Create Team";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberBox.Controls.Add(this.PhoneNumberBox);
            this.AddNewMemberBox.Controls.Add(this.PhoneNumberLabel);
            this.AddNewMemberBox.Controls.Add(this.EmailBox);
            this.AddNewMemberBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameBox);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameBox);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Location = new System.Drawing.Point(12, 332);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(348, 277);
            this.AddNewMemberBox.TabIndex = 26;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(202, 37);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(118, 20);
            this.FirstNameBox.TabIndex = 28;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AccessibleName = "FirstNameLabel";
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.FirstNameLabel.Location = new System.Drawing.Point(18, 29);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(135, 29);
            this.FirstNameLabel.TabIndex = 27;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(202, 84);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(118, 20);
            this.LastNameBox.TabIndex = 30;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LastNameLabel.Location = new System.Drawing.Point(18, 75);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(132, 29);
            this.LastNameLabel.TabIndex = 29;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(202, 131);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(118, 20);
            this.EmailBox.TabIndex = 32;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AccessibleName = "EmailLabel";
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EmailLabel.Location = new System.Drawing.Point(18, 122);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(78, 29);
            this.EmailLabel.TabIndex = 31;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.AccessibleName = "PhoneNumberLabel";
            this.PhoneNumberBox.Location = new System.Drawing.Point(202, 178);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(118, 20);
            this.PhoneNumberBox.TabIndex = 34;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AccessibleName = "PhoneNumberLabel";
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(18, 170);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(178, 29);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.AutoSize = true;
            this.CreateMemberButton.Location = new System.Drawing.Point(89, 227);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(134, 26);
            this.CreateMemberButton.TabIndex = 35;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.AccessibleName = "TournamentPlayersListBox";
            this.TeamMembersListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.Location = new System.Drawing.Point(417, 51);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(398, 368);
            this.TeamMembersListBox.TabIndex = 27;
            this.TeamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMembersListBox_SelectedIndexChanged);
            // 
            // DeleteSelectedMember
            // 
            this.DeleteSelectedMember.AutoSize = true;
            this.DeleteSelectedMember.Location = new System.Drawing.Point(531, 451);
            this.DeleteSelectedMember.Name = "DeleteSelectedMember";
            this.DeleteSelectedMember.Size = new System.Drawing.Size(170, 41);
            this.DeleteSelectedMember.TabIndex = 28;
            this.DeleteSelectedMember.Text = "Delete Selected Member";
            this.DeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.AutoSize = true;
            this.CreateTeamButton.Location = new System.Drawing.Point(479, 524);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(288, 75);
            this.CreateTeamButton.TabIndex = 29;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 641);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMember);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.AddMemberLabel);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.Header);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button AddMemberLabel;
        private System.Windows.Forms.ComboBox SelectTeamLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        public System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        public System.Windows.Forms.Button DeleteSelectedMember;
        public System.Windows.Forms.Button CreateTeamButton;
    }
}