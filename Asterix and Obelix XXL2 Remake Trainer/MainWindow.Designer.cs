namespace Asterix_and_Obelix_XXL2_Remake_Trainer
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HelmetsCheckbox = new System.Windows.Forms.CheckBox();
            this.HealthCheckbox = new System.Windows.Forms.CheckBox();
            this.ShieldCheckbox = new System.Windows.Forms.CheckBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.FlyCheckbox = new System.Windows.Forms.CheckBox();
            this.SubTimer = new System.Windows.Forms.Timer(this.components);
            this.YCordinateInput = new System.Windows.Forms.TextBox();
            this.AcceptHeightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XCordinateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptXButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ZCordinateBox = new System.Windows.Forms.TextBox();
            this.AcceptZButton = new System.Windows.Forms.Button();
            this.CurrentXCordinates = new System.Windows.Forms.Label();
            this.CurrentYCordinates = new System.Windows.Forms.Label();
            this.CurrentZCordinates = new System.Windows.Forms.Label();
            this.FlyHeightInput = new System.Windows.Forms.TextBox();
            this.AcceptNewPermHight = new System.Windows.Forms.Button();
            this.FreezeObelixXCheckbox = new System.Windows.Forms.CheckBox();
            this.FreezeObelixZCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HelmetsCheckbox
            // 
            this.HelmetsCheckbox.AutoSize = true;
            this.HelmetsCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.HelmetsCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelmetsCheckbox.Location = new System.Drawing.Point(260, 78);
            this.HelmetsCheckbox.Name = "HelmetsCheckbox";
            this.HelmetsCheckbox.Size = new System.Drawing.Size(163, 28);
            this.HelmetsCheckbox.TabIndex = 0;
            this.HelmetsCheckbox.Text = "Infinte Helmets";
            this.HelmetsCheckbox.UseVisualStyleBackColor = false;
            this.HelmetsCheckbox.CheckedChanged += new System.EventHandler(this.HelmetsCheckbox_CheckedChanged);
            // 
            // HealthCheckbox
            // 
            this.HealthCheckbox.AutoSize = true;
            this.HealthCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.HealthCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthCheckbox.Location = new System.Drawing.Point(260, 112);
            this.HealthCheckbox.Name = "HealthCheckbox";
            this.HealthCheckbox.Size = new System.Drawing.Size(150, 28);
            this.HealthCheckbox.TabIndex = 1;
            this.HealthCheckbox.Text = "Infinte Health";
            this.HealthCheckbox.UseVisualStyleBackColor = false;
            this.HealthCheckbox.CheckedChanged += new System.EventHandler(this.HealthCheckbox_CheckedChanged);
            // 
            // ShieldCheckbox
            // 
            this.ShieldCheckbox.AutoSize = true;
            this.ShieldCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ShieldCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShieldCheckbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ShieldCheckbox.Location = new System.Drawing.Point(108, 78);
            this.ShieldCheckbox.Name = "ShieldCheckbox";
            this.ShieldCheckbox.Size = new System.Drawing.Size(146, 28);
            this.ShieldCheckbox.TabIndex = 2;
            this.ShieldCheckbox.Text = "Infinte Shield";
            this.ShieldCheckbox.UseVisualStyleBackColor = false;
            this.ShieldCheckbox.CheckedChanged += new System.EventHandler(this.ShieldCheckbox_CheckedChanged);
            // 
            // AboutButton
            // 
            this.AboutButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(13, 146);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(335, 146);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // FlyCheckbox
            // 
            this.FlyCheckbox.AutoSize = true;
            this.FlyCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.FlyCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlyCheckbox.ForeColor = System.Drawing.Color.Red;
            this.FlyCheckbox.Location = new System.Drawing.Point(108, 112);
            this.FlyCheckbox.Name = "FlyCheckbox";
            this.FlyCheckbox.Size = new System.Drawing.Size(56, 28);
            this.FlyCheckbox.TabIndex = 6;
            this.FlyCheckbox.Text = "Fly";
            this.FlyCheckbox.UseVisualStyleBackColor = false;
            this.FlyCheckbox.CheckedChanged += new System.EventHandler(this.FlyCheckbox_CheckedChanged);
            // 
            // SubTimer
            // 
            this.SubTimer.Interval = 1;
            this.SubTimer.Tick += new System.EventHandler(this.SubTimer_Tick);
            // 
            // YCordinateInput
            // 
            this.YCordinateInput.Location = new System.Drawing.Point(450, 104);
            this.YCordinateInput.Name = "YCordinateInput";
            this.YCordinateInput.Size = new System.Drawing.Size(66, 20);
            this.YCordinateInput.TabIndex = 7;
            // 
            // AcceptHeightButton
            // 
            this.AcceptHeightButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptHeightButton.Location = new System.Drawing.Point(576, 101);
            this.AcceptHeightButton.Name = "AcceptHeightButton";
            this.AcceptHeightButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptHeightButton.TabIndex = 8;
            this.AcceptHeightButton.Text = "Accept Y";
            this.AcceptHeightButton.UseVisualStyleBackColor = true;
            this.AcceptHeightButton.Click += new System.EventHandler(this.AcceptHeightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Y";
            // 
            // XCordinateBox
            // 
            this.XCordinateBox.Location = new System.Drawing.Point(450, 76);
            this.XCordinateBox.Name = "XCordinateBox";
            this.XCordinateBox.Size = new System.Drawing.Size(66, 20);
            this.XCordinateBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // AcceptXButton
            // 
            this.AcceptXButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptXButton.Location = new System.Drawing.Point(576, 74);
            this.AcceptXButton.Name = "AcceptXButton";
            this.AcceptXButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptXButton.TabIndex = 12;
            this.AcceptXButton.Text = "Accept X";
            this.AcceptXButton.UseVisualStyleBackColor = true;
            this.AcceptXButton.Click += new System.EventHandler(this.AcceptXButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Z";
            // 
            // ZCordinateBox
            // 
            this.ZCordinateBox.Location = new System.Drawing.Point(450, 135);
            this.ZCordinateBox.Name = "ZCordinateBox";
            this.ZCordinateBox.Size = new System.Drawing.Size(66, 20);
            this.ZCordinateBox.TabIndex = 14;
            // 
            // AcceptZButton
            // 
            this.AcceptZButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptZButton.Location = new System.Drawing.Point(576, 132);
            this.AcceptZButton.Name = "AcceptZButton";
            this.AcceptZButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptZButton.TabIndex = 15;
            this.AcceptZButton.Text = "Accept Z";
            this.AcceptZButton.UseVisualStyleBackColor = true;
            this.AcceptZButton.Click += new System.EventHandler(this.AcceptZButton_Click);
            // 
            // CurrentXCordinates
            // 
            this.CurrentXCordinates.AutoSize = true;
            this.CurrentXCordinates.BackColor = System.Drawing.Color.Transparent;
            this.CurrentXCordinates.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentXCordinates.ForeColor = System.Drawing.Color.Red;
            this.CurrentXCordinates.Location = new System.Drawing.Point(666, 76);
            this.CurrentXCordinates.Name = "CurrentXCordinates";
            this.CurrentXCordinates.Size = new System.Drawing.Size(16, 20);
            this.CurrentXCordinates.TabIndex = 16;
            this.CurrentXCordinates.Text = "-";
            // 
            // CurrentYCordinates
            // 
            this.CurrentYCordinates.AutoSize = true;
            this.CurrentYCordinates.BackColor = System.Drawing.Color.Transparent;
            this.CurrentYCordinates.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentYCordinates.ForeColor = System.Drawing.Color.Red;
            this.CurrentYCordinates.Location = new System.Drawing.Point(666, 108);
            this.CurrentYCordinates.Name = "CurrentYCordinates";
            this.CurrentYCordinates.Size = new System.Drawing.Size(16, 20);
            this.CurrentYCordinates.TabIndex = 17;
            this.CurrentYCordinates.Text = "-";
            // 
            // CurrentZCordinates
            // 
            this.CurrentZCordinates.AutoSize = true;
            this.CurrentZCordinates.BackColor = System.Drawing.Color.Transparent;
            this.CurrentZCordinates.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentZCordinates.ForeColor = System.Drawing.Color.Red;
            this.CurrentZCordinates.Location = new System.Drawing.Point(666, 134);
            this.CurrentZCordinates.Name = "CurrentZCordinates";
            this.CurrentZCordinates.Size = new System.Drawing.Size(16, 20);
            this.CurrentZCordinates.TabIndex = 18;
            this.CurrentZCordinates.Text = "-";
            // 
            // FlyHeightInput
            // 
            this.FlyHeightInput.Location = new System.Drawing.Point(98, 149);
            this.FlyHeightInput.Name = "FlyHeightInput";
            this.FlyHeightInput.Size = new System.Drawing.Size(66, 20);
            this.FlyHeightInput.TabIndex = 19;
            // 
            // AcceptNewPermHight
            // 
            this.AcceptNewPermHight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptNewPermHight.Location = new System.Drawing.Point(170, 147);
            this.AcceptNewPermHight.Name = "AcceptNewPermHight";
            this.AcceptNewPermHight.Size = new System.Drawing.Size(75, 23);
            this.AcceptNewPermHight.TabIndex = 20;
            this.AcceptNewPermHight.Text = "Accept Z";
            this.AcceptNewPermHight.UseVisualStyleBackColor = true;
            this.AcceptNewPermHight.Click += new System.EventHandler(this.AcceptNewPermHight_Click);
            // 
            // FreezeObelixXCheckbox
            // 
            this.FreezeObelixXCheckbox.AutoSize = true;
            this.FreezeObelixXCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.FreezeObelixXCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezeObelixXCheckbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FreezeObelixXCheckbox.Location = new System.Drawing.Point(733, 70);
            this.FreezeObelixXCheckbox.Name = "FreezeObelixXCheckbox";
            this.FreezeObelixXCheckbox.Size = new System.Drawing.Size(159, 28);
            this.FreezeObelixXCheckbox.TabIndex = 21;
            this.FreezeObelixXCheckbox.Text = "Freeze Obelix X";
            this.FreezeObelixXCheckbox.UseVisualStyleBackColor = false;
            this.FreezeObelixXCheckbox.CheckedChanged += new System.EventHandler(this.FreezeObelixXCheckbox_CheckedChanged);
            // 
            // FreezeObelixZCheckbox
            // 
            this.FreezeObelixZCheckbox.AutoSize = true;
            this.FreezeObelixZCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.FreezeObelixZCheckbox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezeObelixZCheckbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FreezeObelixZCheckbox.Location = new System.Drawing.Point(733, 104);
            this.FreezeObelixZCheckbox.Name = "FreezeObelixZCheckbox";
            this.FreezeObelixZCheckbox.Size = new System.Drawing.Size(157, 28);
            this.FreezeObelixZCheckbox.TabIndex = 22;
            this.FreezeObelixZCheckbox.Text = "Freeze Obelix Z";
            this.FreezeObelixZCheckbox.UseVisualStyleBackColor = false;
            this.FreezeObelixZCheckbox.CheckedChanged += new System.EventHandler(this.FreezeObelixZCheckbox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Asterix_and_Obelix_XXL2_Remake_Trainer.Properties.Resources.MainWindowBackgroundTest05;
            this.ClientSize = new System.Drawing.Size(894, 181);
            this.Controls.Add(this.FreezeObelixZCheckbox);
            this.Controls.Add(this.FreezeObelixXCheckbox);
            this.Controls.Add(this.AcceptNewPermHight);
            this.Controls.Add(this.FlyHeightInput);
            this.Controls.Add(this.CurrentZCordinates);
            this.Controls.Add(this.CurrentYCordinates);
            this.Controls.Add(this.CurrentXCordinates);
            this.Controls.Add(this.AcceptZButton);
            this.Controls.Add(this.ZCordinateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AcceptXButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XCordinateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptHeightButton);
            this.Controls.Add(this.YCordinateInput);
            this.Controls.Add(this.FlyCheckbox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ShieldCheckbox);
            this.Controls.Add(this.HealthCheckbox);
            this.Controls.Add(this.HelmetsCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Asterix and Obelix XXL2 Trainer v1.0.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HelmetsCheckbox;
        private System.Windows.Forms.CheckBox HealthCheckbox;
        private System.Windows.Forms.CheckBox ShieldCheckbox;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.CheckBox FlyCheckbox;
        private System.Windows.Forms.Timer SubTimer;
        private System.Windows.Forms.TextBox YCordinateInput;
        private System.Windows.Forms.Button AcceptHeightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XCordinateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AcceptXButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ZCordinateBox;
        private System.Windows.Forms.Button AcceptZButton;
        private System.Windows.Forms.Label CurrentXCordinates;
        private System.Windows.Forms.Label CurrentYCordinates;
        private System.Windows.Forms.Label CurrentZCordinates;
        private System.Windows.Forms.TextBox FlyHeightInput;
        private System.Windows.Forms.Button AcceptNewPermHight;
        private System.Windows.Forms.CheckBox FreezeObelixXCheckbox;
        private System.Windows.Forms.CheckBox FreezeObelixZCheckbox;
    }
}

