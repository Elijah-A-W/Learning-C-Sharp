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
            createTeamLabel = new Label();
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            selectTeamMemberLabel = new Label();
            teamMemberDropDown = new ComboBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            createMemberButton = new Button();
            addNewMemberGroupBox = new GroupBox();
            teamMemberListBox = new ListBox();
            createTeamButton = new Button();
            deleteSelectedTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.BackColor = Color.White;
            createTeamLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(31, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(133, 30);
            createTeamLabel.TabIndex = 0;
            createTeamLabel.Text = "Create Team:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.BackColor = Color.White;
            teamNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(31, 68);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(124, 30);
            teamNameLabel.TabIndex = 1;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(30, 105);
            teamNameValue.Multiline = true;
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(220, 32);
            teamNameValue.TabIndex = 2;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.BackColor = Color.White;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(31, 153);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(207, 30);
            selectTeamMemberLabel.TabIndex = 3;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamMemberDropDown
            // 
            teamMemberDropDown.FormattingEnabled = true;
            teamMemberDropDown.Location = new Point(31, 186);
            teamMemberDropDown.Name = "teamMemberDropDown";
            teamMemberDropDown.Size = new Size(208, 23);
            teamMemberDropDown.TabIndex = 4;
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(160, 20);
            firstNameValue.Multiline = true;
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(163, 32);
            firstNameValue.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.White;
            firstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(30, 20);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 30);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(161, 141);
            cellphoneValue.Multiline = true;
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(162, 32);
            cellphoneValue.TabIndex = 8;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.BackColor = Color.White;
            cellphoneLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(30, 143);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(106, 30);
            cellphoneLabel.TabIndex = 7;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(160, 103);
            emailValue.Multiline = true;
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(163, 32);
            emailValue.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.White;
            emailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(30, 105);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(161, 59);
            lastNameValue.Multiline = true;
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(162, 32);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.White;
            lastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(31, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 30);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // createMemberButton
            // 
            createMemberButton.BackColor = Color.White;
            createMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(79, 189);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(171, 37);
            createMemberButton.TabIndex = 13;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = false;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Location = new Point(30, 229);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(332, 238);
            addNewMemberGroupBox.TabIndex = 14;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 15;
            teamMemberListBox.Location = new Point(380, 86);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(300, 304);
            teamMemberListBox.TabIndex = 15;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = Color.White;
            createTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(474, 396);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(95, 71);
            createTeamButton.TabIndex = 14;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedTeamButton
            // 
            deleteSelectedTeamButton.BackColor = Color.White;
            deleteSelectedTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedTeamButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedTeamButton.Location = new Point(686, 200);
            deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            deleteSelectedTeamButton.Size = new Size(114, 81);
            deleteSelectedTeamButton.TabIndex = 16;
            deleteSelectedTeamButton.Text = "Delete Selected";
            deleteSelectedTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(deleteSelectedTeamButton);
            Controls.Add(createTeamButton);
            Controls.Add(teamMemberListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(teamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Label selectTeamMemberLabel;
        private ComboBox teamMemberDropDown;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private GroupBox addNewMemberGroupBox;
        private ListBox teamMemberListBox;
        private Button createTeamButton;
        private Button deleteSelectedTeamButton;
    }
}