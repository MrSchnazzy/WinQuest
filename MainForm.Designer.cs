namespace WinQuest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textLabel = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.magicButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicListBox = new System.Windows.Forms.ListBox();
            this.battlePanel = new System.Windows.Forms.Panel();
            this.reposePanel = new System.Windows.Forms.Panel();
            this.proceedButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.restButton = new System.Windows.Forms.Button();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.battlePanel.SuspendLayout();
            this.reposePanel.SuspendLayout();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoEllipsis = true;
            this.textLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(12, 399);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(519, 146);
            this.textLabel.TabIndex = 1;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(3, 3);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(154, 62);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "&Attack";
            this.toolTip.SetToolTip(this.attackButton, "Performs a melee attack");
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // magicButton
            // 
            this.magicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton.Location = new System.Drawing.Point(179, 3);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(154, 62);
            this.magicButton.TabIndex = 1;
            this.magicButton.Text = "&Magic";
            this.toolTip.SetToolTip(this.magicButton, "Opens your list of magic");
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendButton.Location = new System.Drawing.Point(3, 77);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(154, 62);
            this.defendButton.TabIndex = 2;
            this.defendButton.Text = "&Defend";
            this.toolTip.SetToolTip(this.defendButton, "Blocks enemy attack");
            this.defendButton.UseVisualStyleBackColor = true;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(179, 77);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(154, 62);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "&Run";
            this.toolTip.SetToolTip(this.runButton, "Runs from the battle");
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(52, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // magicListBox
            // 
            this.magicListBox.BackColor = System.Drawing.SystemColors.Window;
            this.magicListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicListBox.FormattingEnabled = true;
            this.magicListBox.ItemHeight = 16;
            this.magicListBox.Items.AddRange(new object[] {
            "Heal"});
            this.magicListBox.Location = new System.Drawing.Point(179, 3);
            this.magicListBox.Name = "magicListBox";
            this.magicListBox.Size = new System.Drawing.Size(154, 68);
            this.magicListBox.TabIndex = 4;
            this.magicListBox.Visible = false;
            this.magicListBox.SelectedIndexChanged += new System.EventHandler(this.magicListBox_SelectedIndexChanged);
            // 
            // battlePanel
            // 
            this.battlePanel.Controls.Add(this.defendButton);
            this.battlePanel.Controls.Add(this.runButton);
            this.battlePanel.Controls.Add(this.magicButton);
            this.battlePanel.Controls.Add(this.attackButton);
            this.battlePanel.Controls.Add(this.magicListBox);
            this.battlePanel.Location = new System.Drawing.Point(543, 396);
            this.battlePanel.Name = "battlePanel";
            this.battlePanel.Size = new System.Drawing.Size(350, 151);
            this.battlePanel.TabIndex = 5;
            this.battlePanel.Visible = false;
            // 
            // reposePanel
            // 
            this.reposePanel.Controls.Add(this.proceedButton);
            this.reposePanel.Controls.Add(this.statusButton);
            this.reposePanel.Controls.Add(this.restButton);
            this.reposePanel.Location = new System.Drawing.Point(540, 399);
            this.reposePanel.Name = "reposePanel";
            this.reposePanel.Size = new System.Drawing.Size(350, 151);
            this.reposePanel.TabIndex = 6;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(87, 80);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(154, 62);
            this.proceedButton.TabIndex = 0;
            this.proceedButton.Text = "&Proceed";
            this.toolTip.SetToolTip(this.proceedButton, "Continues the quest");
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // statusButton
            // 
            this.statusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.Location = new System.Drawing.Point(176, 12);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(154, 62);
            this.statusButton.TabIndex = 0;
            this.statusButton.Text = "&Check Status";
            this.toolTip.SetToolTip(this.statusButton, "Opens the Status Menu");
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // restButton
            // 
            this.restButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restButton.Location = new System.Drawing.Point(3, 12);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(154, 62);
            this.restButton.TabIndex = 0;
            this.restButton.Text = "&Rest";
            this.toolTip.SetToolTip(this.restButton, "Rests and heals");
            this.restButton.UseVisualStyleBackColor = true;
            this.restButton.Click += new System.EventHandler(this.restButton_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backgroundPanel.Controls.Add(this.enemyPictureBox);
            this.backgroundPanel.Location = new System.Drawing.Point(12, 27);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(858, 369);
            this.backgroundPanel.TabIndex = 0;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyPictureBox.Location = new System.Drawing.Point(325, 169);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(182, 137);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 0;
            this.enemyPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 561);
            this.Controls.Add(this.battlePanel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.reposePanel);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.battlePanel.ResumeLayout(false);
            this.reposePanel.ResumeLayout(false);
            this.backgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel battlePanel;
        private System.Windows.Forms.Panel reposePanel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button restButton;
        public System.Windows.Forms.ListBox magicListBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}