namespace OpenSqlServerExample
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
            this.SynchronousNoneExistingServerButton = new System.Windows.Forms.Button();
            this.AsynchronousNoneExistingServerButton = new System.Windows.Forms.Button();
            this.ServerConnectionWithKnownServerButton = new System.Windows.Forms.Button();
            this.ServerAvailableButton = new System.Windows.Forms.Button();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SynchronousNoneExistingServerButton
            // 
            this.SynchronousNoneExistingServerButton.Location = new System.Drawing.Point(12, 12);
            this.SynchronousNoneExistingServerButton.Name = "SynchronousNoneExistingServerButton";
            this.SynchronousNoneExistingServerButton.Size = new System.Drawing.Size(241, 23);
            this.SynchronousNoneExistingServerButton.TabIndex = 0;
            this.SynchronousNoneExistingServerButton.Text = "Connect with no existing server sync";
            this.SynchronousNoneExistingServerButton.UseVisualStyleBackColor = true;
            this.SynchronousNoneExistingServerButton.Click += new System.EventHandler(this.SynchronousNoneExistingServerButton_Click);
            // 
            // AsynchronousNoneExistingServerButton
            // 
            this.AsynchronousNoneExistingServerButton.Location = new System.Drawing.Point(259, 12);
            this.AsynchronousNoneExistingServerButton.Name = "AsynchronousNoneExistingServerButton";
            this.AsynchronousNoneExistingServerButton.Size = new System.Drawing.Size(241, 23);
            this.AsynchronousNoneExistingServerButton.TabIndex = 1;
            this.AsynchronousNoneExistingServerButton.Text = "Connect with no existing server async";
            this.AsynchronousNoneExistingServerButton.UseVisualStyleBackColor = true;
            this.AsynchronousNoneExistingServerButton.Click += new System.EventHandler(this.AsynchronousNoneExistingServerButton_Click);
            // 
            // ServerConnectionWithKnownServerButton
            // 
            this.ServerConnectionWithKnownServerButton.Location = new System.Drawing.Point(12, 70);
            this.ServerConnectionWithKnownServerButton.Name = "ServerConnectionWithKnownServerButton";
            this.ServerConnectionWithKnownServerButton.Size = new System.Drawing.Size(241, 23);
            this.ServerConnectionWithKnownServerButton.TabIndex = 2;
            this.ServerConnectionWithKnownServerButton.Text = "Connect with existing server async";
            this.ServerConnectionWithKnownServerButton.UseVisualStyleBackColor = true;
            this.ServerConnectionWithKnownServerButton.Click += new System.EventHandler(this.ServerConnectionWithKnownServerButton_Click);
            // 
            // ServerAvailableButton
            // 
            this.ServerAvailableButton.Enabled = false;
            this.ServerAvailableButton.Location = new System.Drawing.Point(12, 41);
            this.ServerAvailableButton.Name = "ServerAvailableButton";
            this.ServerAvailableButton.Size = new System.Drawing.Size(241, 23);
            this.ServerAvailableButton.TabIndex = 3;
            this.ServerAvailableButton.Text = "Server available";
            this.ServerAvailableButton.UseVisualStyleBackColor = true;
            this.ServerAvailableButton.Click += new System.EventHandler(this.ServerAvailableButton_Click);
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(330, 56);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.ServerNameTextBox.TabIndex = 4;
            this.ServerNameTextBox.Text = "KARENS-PC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenSqlServerExample.Properties.Resources.PointTo1;
            this.pictureBox1.Location = new System.Drawing.Point(254, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 116);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.ServerAvailableButton);
            this.Controls.Add(this.ServerConnectionWithKnownServerButton);
            this.Controls.Add(this.AsynchronousNoneExistingServerButton);
            this.Controls.Add(this.SynchronousNoneExistingServerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecting demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SynchronousNoneExistingServerButton;
        private System.Windows.Forms.Button AsynchronousNoneExistingServerButton;
        private System.Windows.Forms.Button ServerConnectionWithKnownServerButton;
        private System.Windows.Forms.Button ServerAvailableButton;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

