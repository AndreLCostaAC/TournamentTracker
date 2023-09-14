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
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.PhoneNumberValue = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMember = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMemberLabel
            // 
            this.AddMemberLabel.AutoSize = true;
            this.AddMemberLabel.Location = new System.Drawing.Point(95, 334);
            this.AddMemberLabel.Margin = new System.Windows.Forms.Padding(4);
            this.AddMemberLabel.Name = "AddMemberLabel";
            this.AddMemberLabel.Size = new System.Drawing.Size(227, 50);
            this.AddMemberLabel.TabIndex = 25;
            this.AddMemberLabel.Text = "Add Member";
            this.AddMemberLabel.UseVisualStyleBackColor = true;
            this.AddMemberLabel.Click += new System.EventHandler(this.AddMemberLabel_Click);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.FormattingEnabled = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(61, 283);
            this.SelectTeamLabel.Margin = new System.Windows.Forms.Padding(4);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(344, 24);
            this.SelectTeamLabel.TabIndex = 23;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RoundLabel.Location = new System.Drawing.Point(55, 229);
            this.RoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(301, 35);
            this.RoundLabel.TabIndex = 22;
            this.RoundLabel.Text = "Select Team Member";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(61, 173);
            this.TournamentNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(344, 22);
            this.TournamentNameValue.TabIndex = 19;
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AccessibleName = "TeamNameLabel";
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(55, 114);
            this.TeamOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(179, 35);
            this.TeamOneScoreLabel.TabIndex = 18;
            this.TeamOneScoreLabel.Text = "Team Name";
            this.TeamOneScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Header.Location = new System.Drawing.Point(55, 31);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(186, 35);
            this.Header.TabIndex = 17;
            this.Header.Text = "Create Team";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberBox.Controls.Add(this.PhoneNumberValue);
            this.AddNewMemberBox.Controls.Add(this.PhoneNumberLabel);
            this.AddNewMemberBox.Controls.Add(this.EmailValue);
            this.AddNewMemberBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Location = new System.Drawing.Point(16, 409);
            this.AddNewMemberBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Padding = new System.Windows.Forms.Padding(4);
            this.AddNewMemberBox.Size = new System.Drawing.Size(464, 341);
            this.AddNewMemberBox.TabIndex = 26;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.AutoSize = true;
            this.CreateMemberButton.Location = new System.Drawing.Point(119, 279);
            this.CreateMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(179, 32);
            this.CreateMemberButton.TabIndex = 35;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // PhoneNumberValue
            // 
            this.PhoneNumberValue.AccessibleName = "PhoneNumberLabel";
            this.PhoneNumberValue.Location = new System.Drawing.Point(269, 219);
            this.PhoneNumberValue.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberValue.Name = "PhoneNumberValue";
            this.PhoneNumberValue.Size = new System.Drawing.Size(156, 22);
            this.PhoneNumberValue.TabIndex = 34;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AccessibleName = "PhoneNumberLabel";
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(24, 209);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(217, 35);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(269, 161);
            this.EmailValue.Margin = new System.Windows.Forms.Padding(4);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(156, 22);
            this.EmailValue.TabIndex = 32;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AccessibleName = "EmailLabel";
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EmailLabel.Location = new System.Drawing.Point(24, 150);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(94, 35);
            this.EmailLabel.TabIndex = 31;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(269, 103);
            this.LastNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(156, 22);
            this.LastNameValue.TabIndex = 30;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LastNameLabel.Location = new System.Drawing.Point(24, 92);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(160, 35);
            this.LastNameLabel.TabIndex = 29;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(269, 46);
            this.FirstNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(156, 22);
            this.FirstNameValue.TabIndex = 28;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AccessibleName = "FirstNameLabel";
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.FirstNameLabel.Location = new System.Drawing.Point(24, 36);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(163, 35);
            this.FirstNameLabel.TabIndex = 27;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.AccessibleName = "TournamentPlayersListBox";
            this.TeamMembersListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 16;
            this.TeamMembersListBox.Location = new System.Drawing.Point(556, 63);
            this.TeamMembersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(529, 452);
            this.TeamMembersListBox.TabIndex = 27;
            // 
            // DeleteSelectedMember
            // 
            this.DeleteSelectedMember.AutoSize = true;
            this.DeleteSelectedMember.Location = new System.Drawing.Point(708, 555);
            this.DeleteSelectedMember.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelectedMember.Name = "DeleteSelectedMember";
            this.DeleteSelectedMember.Size = new System.Drawing.Size(227, 50);
            this.DeleteSelectedMember.TabIndex = 28;
            this.DeleteSelectedMember.Text = "Delete Selected Member";
            this.DeleteSelectedMember.UseVisualStyleBackColor = true;
            this.DeleteSelectedMember.Click += new System.EventHandler(this.DeleteSelectedMember_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.AccessibleName = "Create Team";
            this.CreateTeamButton.AutoSize = true;
            this.CreateTeamButton.Location = new System.Drawing.Point(639, 645);
            this.CreateTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(384, 92);
            this.CreateTeamButton.TabIndex = 29;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 789);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox PhoneNumberValue;
        private System.Windows.Forms.Label PhoneNumberLabel;
        public System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        public System.Windows.Forms.Button DeleteSelectedMember;
        public System.Windows.Forms.Button CreateTeamButton;
    }
}