namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.Header = new System.Windows.Forms.Label();
            this.LoadExistentTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Header.Location = new System.Drawing.Point(283, 38);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(274, 29);
            this.Header.TabIndex = 19;
            this.Header.Text = "Tournament Dashboard";
            // 
            // LoadExistentTournamentDropDown
            // 
            this.LoadExistentTournamentDropDown.FormattingEnabled = true;
            this.LoadExistentTournamentDropDown.Location = new System.Drawing.Point(279, 169);
            this.LoadExistentTournamentDropDown.Name = "LoadExistentTournamentDropDown";
            this.LoadExistentTournamentDropDown.Size = new System.Drawing.Size(259, 21);
            this.LoadExistentTournamentDropDown.TabIndex = 25;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(261, 121);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(312, 29);
            this.LoadExistingTournamentLabel.TabIndex = 24;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.LoadExistingTournamentLabel.Click += new System.EventHandler(this.LoadExistingTournamentLabel_Click);
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.AccessibleName = "CreatePrizeButton";
            this.LoadTournamentButton.Location = new System.Drawing.Point(330, 227);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(170, 41);
            this.LoadTournamentButton.TabIndex = 38;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.AccessibleName = "CreatePrizeButton";
            this.CreateTournamentButton.Location = new System.Drawing.Point(288, 299);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(250, 75);
            this.CreateTournamentButton.TabIndex = 39;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 420);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistentTournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.Header);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ComboBox LoadExistentTournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}