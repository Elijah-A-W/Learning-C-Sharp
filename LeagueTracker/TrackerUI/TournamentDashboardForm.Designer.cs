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
            tournamentDashboardLabel = new Label();
            label1 = new Label();
            loadingExistingTournamentsDropDown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.FlatStyle = FlatStyle.Popup;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentDashboardLabel.Location = new Point(167, 34);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(236, 30);
            tournamentDashboardLabel.TabIndex = 0;
            tournamentDashboardLabel.Text = "Tournament Dashboard:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(154, 97);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 1;
            label1.Text = "Load Exisiting Tournament ";
            // 
            // loadingExistingTournamentsDropDown
            // 
            loadingExistingTournamentsDropDown.FormattingEnabled = true;
            loadingExistingTournamentsDropDown.IntegralHeight = false;
            loadingExistingTournamentsDropDown.Location = new Point(160, 130);
            loadingExistingTournamentsDropDown.Name = "loadingExistingTournamentsDropDown";
            loadingExistingTournamentsDropDown.Size = new Size(250, 23);
            loadingExistingTournamentsDropDown.TabIndex = 2;
            loadingExistingTournamentsDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatStyle = FlatStyle.Popup;
            loadTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(167, 192);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(237, 55);
            loadTournamentButton.TabIndex = 3;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatStyle = FlatStyle.Popup;
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(167, 280);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(237, 55);
            createTournamentButton.TabIndex = 4;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 381);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadingExistingTournamentsDropDown);
            Controls.Add(label1);
            Controls.Add(tournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label label1;
        private ComboBox loadingExistingTournamentsDropDown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}