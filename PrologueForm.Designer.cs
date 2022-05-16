namespace WinQuest
{
    partial class PrologueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrologueForm));
            this.healthPanel = new System.Windows.Forms.Panel();
            this.mentalRadioButton = new System.Windows.Forms.RadioButton();
            this.physicalRadioButton = new System.Windows.Forms.RadioButton();
            this.healthLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prologuebutton = new System.Windows.Forms.Button();
            this.problemPanel = new System.Windows.Forms.Panel();
            this.planOutRadioButton = new System.Windows.Forms.RadioButton();
            this.headOnRadioButton = new System.Windows.Forms.RadioButton();
            this.problemLabel = new System.Windows.Forms.Label();
            this.ghostPanel = new System.Windows.Forms.Panel();
            this.noGhostRadioButton = new System.Windows.Forms.RadioButton();
            this.yesGhostRadioButton = new System.Windows.Forms.RadioButton();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.adventureLabel = new System.Windows.Forms.Label();
            this.healthPanel.SuspendLayout();
            this.problemPanel.SuspendLayout();
            this.ghostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // healthPanel
            // 
            this.healthPanel.Controls.Add(this.mentalRadioButton);
            this.healthPanel.Controls.Add(this.physicalRadioButton);
            this.healthPanel.Controls.Add(this.healthLabel);
            this.healthPanel.Location = new System.Drawing.Point(15, 70);
            this.healthPanel.Name = "healthPanel";
            this.healthPanel.Size = new System.Drawing.Size(241, 155);
            this.healthPanel.TabIndex = 0;
            this.healthPanel.Visible = false;
            // 
            // mentalRadioButton
            // 
            this.mentalRadioButton.AutoSize = true;
            this.mentalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentalRadioButton.ForeColor = System.Drawing.Color.White;
            this.mentalRadioButton.Location = new System.Drawing.Point(48, 114);
            this.mentalRadioButton.Name = "mentalRadioButton";
            this.mentalRadioButton.Size = new System.Drawing.Size(120, 20);
            this.mentalRadioButton.TabIndex = 4;
            this.mentalRadioButton.Text = "Mental Health";
            this.mentalRadioButton.UseVisualStyleBackColor = true;
            // 
            // physicalRadioButton
            // 
            this.physicalRadioButton.AutoSize = true;
            this.physicalRadioButton.Checked = true;
            this.physicalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalRadioButton.ForeColor = System.Drawing.Color.White;
            this.physicalRadioButton.Location = new System.Drawing.Point(48, 73);
            this.physicalRadioButton.Name = "physicalRadioButton";
            this.physicalRadioButton.Size = new System.Drawing.Size(133, 20);
            this.physicalRadioButton.TabIndex = 3;
            this.physicalRadioButton.TabStop = true;
            this.physicalRadioButton.Text = "Physical Health";
            this.physicalRadioButton.UseVisualStyleBackColor = true;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Black;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(12, 16);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(191, 32);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Which is more important?\r\nPhysical or Mental Health?";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(22, -20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(225, 102);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "What is your name?";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prologuebutton
            // 
            this.prologuebutton.BackColor = System.Drawing.Color.Transparent;
            this.prologuebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prologuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prologuebutton.ForeColor = System.Drawing.Color.White;
            this.prologuebutton.Location = new System.Drawing.Point(63, 253);
            this.prologuebutton.Name = "prologuebutton";
            this.prologuebutton.Size = new System.Drawing.Size(120, 26);
            this.prologuebutton.TabIndex = 1;
            this.prologuebutton.Text = "Remember?";
            this.toolTip1.SetToolTip(this.prologuebutton, "What does this do??");
            this.prologuebutton.UseVisualStyleBackColor = false;
            this.prologuebutton.Click += new System.EventHandler(this.prologuebutton_Click);
            // 
            // problemPanel
            // 
            this.problemPanel.Controls.Add(this.planOutRadioButton);
            this.problemPanel.Controls.Add(this.headOnRadioButton);
            this.problemPanel.Controls.Add(this.problemLabel);
            this.problemPanel.Location = new System.Drawing.Point(12, 76);
            this.problemPanel.Name = "problemPanel";
            this.problemPanel.Size = new System.Drawing.Size(235, 149);
            this.problemPanel.TabIndex = 5;
            this.problemPanel.Visible = false;
            // 
            // planOutRadioButton
            // 
            this.planOutRadioButton.AutoSize = true;
            this.planOutRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planOutRadioButton.ForeColor = System.Drawing.Color.White;
            this.planOutRadioButton.Location = new System.Drawing.Point(3, 85);
            this.planOutRadioButton.Name = "planOutRadioButton";
            this.planOutRadioButton.Size = new System.Drawing.Size(211, 20);
            this.planOutRadioButton.TabIndex = 3;
            this.planOutRadioButton.Text = "Stop to think out a plan first";
            this.planOutRadioButton.UseVisualStyleBackColor = true;
            // 
            // headOnRadioButton
            // 
            this.headOnRadioButton.AutoSize = true;
            this.headOnRadioButton.Checked = true;
            this.headOnRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headOnRadioButton.ForeColor = System.Drawing.Color.White;
            this.headOnRadioButton.Location = new System.Drawing.Point(3, 57);
            this.headOnRadioButton.Name = "headOnRadioButton";
            this.headOnRadioButton.Size = new System.Drawing.Size(229, 20);
            this.headOnRadioButton.TabIndex = 3;
            this.headOnRadioButton.TabStop = true;
            this.headOnRadioButton.Text = "Head on without much thought";
            this.headOnRadioButton.UseVisualStyleBackColor = true;
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.BackColor = System.Drawing.Color.Black;
            this.problemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLabel.ForeColor = System.Drawing.Color.White;
            this.problemLabel.Location = new System.Drawing.Point(7, 19);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(207, 16);
            this.problemLabel.TabIndex = 2;
            this.problemLabel.Text = "How do you solve problems?";
            // 
            // ghostPanel
            // 
            this.ghostPanel.Controls.Add(this.noGhostRadioButton);
            this.ghostPanel.Controls.Add(this.yesGhostRadioButton);
            this.ghostPanel.Controls.Add(this.ghostLabel);
            this.ghostPanel.Location = new System.Drawing.Point(12, 85);
            this.ghostPanel.Name = "ghostPanel";
            this.ghostPanel.Size = new System.Drawing.Size(235, 143);
            this.ghostPanel.TabIndex = 4;
            this.ghostPanel.Visible = false;
            // 
            // noGhostRadioButton
            // 
            this.noGhostRadioButton.AutoSize = true;
            this.noGhostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noGhostRadioButton.ForeColor = System.Drawing.Color.White;
            this.noGhostRadioButton.Location = new System.Drawing.Point(41, 76);
            this.noGhostRadioButton.Name = "noGhostRadioButton";
            this.noGhostRadioButton.Size = new System.Drawing.Size(45, 20);
            this.noGhostRadioButton.TabIndex = 3;
            this.noGhostRadioButton.Text = "No";
            this.noGhostRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesGhostRadioButton
            // 
            this.yesGhostRadioButton.AutoSize = true;
            this.yesGhostRadioButton.Checked = true;
            this.yesGhostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesGhostRadioButton.ForeColor = System.Drawing.Color.White;
            this.yesGhostRadioButton.Location = new System.Drawing.Point(41, 43);
            this.yesGhostRadioButton.Name = "yesGhostRadioButton";
            this.yesGhostRadioButton.Size = new System.Drawing.Size(52, 20);
            this.yesGhostRadioButton.TabIndex = 3;
            this.yesGhostRadioButton.TabStop = true;
            this.yesGhostRadioButton.Text = "Yes";
            this.yesGhostRadioButton.UseVisualStyleBackColor = true;
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.BackColor = System.Drawing.Color.Black;
            this.ghostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostLabel.ForeColor = System.Drawing.Color.White;
            this.ghostLabel.Location = new System.Drawing.Point(20, 15);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(186, 16);
            this.ghostLabel.TabIndex = 2;
            this.ghostLabel.Text = "Do you believe in ghosts?";
            // 
            // adventureLabel
            // 
            this.adventureLabel.BackColor = System.Drawing.Color.Black;
            this.adventureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureLabel.ForeColor = System.Drawing.Color.White;
            this.adventureLabel.Location = new System.Drawing.Point(22, 81);
            this.adventureLabel.Name = "adventureLabel";
            this.adventureLabel.Size = new System.Drawing.Size(225, 102);
            this.adventureLabel.TabIndex = 2;
            this.adventureLabel.Text = "What is your name?";
            this.adventureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adventureLabel.Visible = false;
            // 
            // PrologueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(268, 307);
            this.Controls.Add(this.problemPanel);
            this.Controls.Add(this.healthPanel);
            this.Controls.Add(this.prologuebutton);
            this.Controls.Add(this.ghostPanel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.adventureLabel);
            this.Controls.Add(this.nameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrologueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.healthPanel.ResumeLayout(false);
            this.healthPanel.PerformLayout();
            this.problemPanel.ResumeLayout(false);
            this.problemPanel.PerformLayout();
            this.ghostPanel.ResumeLayout(false);
            this.ghostPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel healthPanel;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton mentalRadioButton;
        private System.Windows.Forms.RadioButton physicalRadioButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Button prologuebutton;
        private System.Windows.Forms.Panel problemPanel;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.RadioButton planOutRadioButton;
        private System.Windows.Forms.RadioButton headOnRadioButton;
        private System.Windows.Forms.Panel ghostPanel;
        private System.Windows.Forms.RadioButton noGhostRadioButton;
        private System.Windows.Forms.RadioButton yesGhostRadioButton;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label adventureLabel;
    }
}

