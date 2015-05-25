namespace BetaTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AgentList = new System.Windows.Forms.CheckedListBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CompressionNum = new System.Windows.Forms.NumericUpDown();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IntervalNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.useCoreCredentialsCheckbox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompressionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgentList
            // 
            this.AgentList.AccessibleDescription = "";
            this.AgentList.CheckOnClick = true;
            this.AgentList.FormattingEnabled = true;
            this.AgentList.Location = new System.Drawing.Point(12, 105);
            this.AgentList.Name = "AgentList";
            this.AgentList.Size = new System.Drawing.Size(200, 199);
            this.AgentList.TabIndex = 0;
            this.AgentList.SelectedIndexChanged += new System.EventHandler(this.AgentList_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConnectButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectButton.Location = new System.Drawing.Point(300, 35);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(79, 30);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Location = new System.Drawing.Point(308, 213);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(58, 30);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.UserNameBox);
            this.groupBox1.Controls.Add(this.ServerBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to Core \\ Agents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Name";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(202, 41);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '#';
            this.PasswordBox.Size = new System.Drawing.Size(92, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(100, 41);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(96, 20);
            this.UserNameBox.TabIndex = 2;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // ServerBox
            // 
            this.ServerBox.Location = new System.Drawing.Point(6, 41);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(88, 20);
            this.ServerBox.TabIndex = 1;
            this.ServerBox.Text = "Localhost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Compression %";
            // 
            // CompressionNum
            // 
            this.CompressionNum.Location = new System.Drawing.Point(308, 145);
            this.CompressionNum.Name = "CompressionNum";
            this.CompressionNum.Size = new System.Drawing.Size(75, 20);
            this.CompressionNum.TabIndex = 4;
            this.CompressionNum.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.CompressionNum.ValueChanged += new System.EventHandler(this.CompressionNum_ValueChanged);
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(218, 145);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(84, 20);
            this.SizeBox.TabIndex = 4;
            this.SizeBox.Text = "1024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size in MB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IntervalNum
            // 
            this.IntervalNum.Location = new System.Drawing.Point(218, 223);
            this.IntervalNum.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.IntervalNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IntervalNum.Name = "IntervalNum";
            this.IntervalNum.Size = new System.Drawing.Size(65, 20);
            this.IntervalNum.TabIndex = 6;
            this.IntervalNum.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Interaval min";
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(218, 184);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(165, 20);
            this.LocationBox.TabIndex = 5;
            this.LocationBox.Text = "C:\\DDT\\data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Location for new Data";
            // 
            // RestartButton
            // 
            this.RestartButton.Enabled = false;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartButton.Location = new System.Drawing.Point(218, 275);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(182, 30);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // useCoreCredentialsCheckbox
            // 
            this.useCoreCredentialsCheckbox.AutoSize = true;
            this.useCoreCredentialsCheckbox.Checked = true;
            this.useCoreCredentialsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCoreCredentialsCheckbox.Location = new System.Drawing.Point(218, 252);
            this.useCoreCredentialsCheckbox.Name = "useCoreCredentialsCheckbox";
            this.useCoreCredentialsCheckbox.Size = new System.Drawing.Size(125, 17);
            this.useCoreCredentialsCheckbox.TabIndex = 7;
            this.useCoreCredentialsCheckbox.Text = "Use Core Credentials";
            this.useCoreCredentialsCheckbox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(175, 17);
            this.StatusBar.Text = "Please connect to core machine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.useCoreCredentialsCheckbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IntervalNum);
            this.Controls.Add(this.CompressionNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AgentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CoreTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompressionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AgentList;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CompressionNum;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IntervalNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.CheckBox useCoreCredentialsCheckbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
    }
}

