namespace CodeSnippets
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
            this.ProcessAsync1Button = new System.Windows.Forms.Button();
            this.CancelExample1Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessStatus1Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnableCrossThreadButton = new System.Windows.Forms.CheckBox();
            this.ProcessStatus2Label = new System.Windows.Forms.Label();
            this.CancelExample2Button = new System.Windows.Forms.Button();
            this.ProcessAsync2Button = new System.Windows.Forms.Button();
            this.IterateFolderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExcelGroupBox = new System.Windows.Forms.GroupBox();
            this.ExcelAsynchronousButton = new System.Windows.Forms.Button();
            this.ExcelSynchronousButton = new System.Windows.Forms.Button();
            this.GetCurrentDateTimeButton = new System.Windows.Forms.Button();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ExcelGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessAsync1Button
            // 
            this.ProcessAsync1Button.Location = new System.Drawing.Point(28, 19);
            this.ProcessAsync1Button.Name = "ProcessAsync1Button";
            this.ProcessAsync1Button.Size = new System.Drawing.Size(98, 23);
            this.ProcessAsync1Button.TabIndex = 0;
            this.ProcessAsync1Button.Text = "Run";
            this.ProcessAsync1Button.UseVisualStyleBackColor = true;
            this.ProcessAsync1Button.Click += new System.EventHandler(this.ProcessAsync1Button_Click);
            // 
            // CancelExample1Button
            // 
            this.CancelExample1Button.Location = new System.Drawing.Point(132, 19);
            this.CancelExample1Button.Name = "CancelExample1Button";
            this.CancelExample1Button.Size = new System.Drawing.Size(98, 23);
            this.CancelExample1Button.TabIndex = 1;
            this.CancelExample1Button.Text = "Cancel";
            this.CancelExample1Button.UseVisualStyleBackColor = true;
            this.CancelExample1Button.Click += new System.EventHandler(this.CancelExample1Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessStatus1Label);
            this.groupBox1.Controls.Add(this.CancelExample1Button);
            this.groupBox1.Controls.Add(this.ProcessAsync1Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Async 1";
            // 
            // ProcessStatus1Label
            // 
            this.ProcessStatus1Label.AutoSize = true;
            this.ProcessStatus1Label.Location = new System.Drawing.Point(236, 25);
            this.ProcessStatus1Label.Name = "ProcessStatus1Label";
            this.ProcessStatus1Label.Size = new System.Drawing.Size(25, 13);
            this.ProcessStatus1Label.TabIndex = 2;
            this.ProcessStatus1Label.Text = "000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EnableCrossThreadButton);
            this.groupBox2.Controls.Add(this.ProcessStatus2Label);
            this.groupBox2.Controls.Add(this.CancelExample2Button);
            this.groupBox2.Controls.Add(this.ProcessAsync2Button);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Async 2";
            // 
            // EnableCrossThreadButton
            // 
            this.EnableCrossThreadButton.AutoSize = true;
            this.EnableCrossThreadButton.Location = new System.Drawing.Point(28, 48);
            this.EnableCrossThreadButton.Name = "EnableCrossThreadButton";
            this.EnableCrossThreadButton.Size = new System.Drawing.Size(217, 17);
            this.EnableCrossThreadButton.TabIndex = 4;
            this.EnableCrossThreadButton.Text = "Enable (Cross-thread operation not valid)";
            this.EnableCrossThreadButton.UseVisualStyleBackColor = true;
            // 
            // ProcessStatus2Label
            // 
            this.ProcessStatus2Label.AutoSize = true;
            this.ProcessStatus2Label.Location = new System.Drawing.Point(236, 24);
            this.ProcessStatus2Label.Name = "ProcessStatus2Label";
            this.ProcessStatus2Label.Size = new System.Drawing.Size(25, 13);
            this.ProcessStatus2Label.TabIndex = 3;
            this.ProcessStatus2Label.Text = "000";
            // 
            // CancelExample2Button
            // 
            this.CancelExample2Button.Location = new System.Drawing.Point(132, 19);
            this.CancelExample2Button.Name = "CancelExample2Button";
            this.CancelExample2Button.Size = new System.Drawing.Size(98, 23);
            this.CancelExample2Button.TabIndex = 1;
            this.CancelExample2Button.Text = "Cancel";
            this.CancelExample2Button.UseVisualStyleBackColor = true;
            this.CancelExample2Button.Click += new System.EventHandler(this.CancelExample2Button_Click);
            // 
            // ProcessAsync2Button
            // 
            this.ProcessAsync2Button.Location = new System.Drawing.Point(28, 19);
            this.ProcessAsync2Button.Name = "ProcessAsync2Button";
            this.ProcessAsync2Button.Size = new System.Drawing.Size(98, 23);
            this.ProcessAsync2Button.TabIndex = 0;
            this.ProcessAsync2Button.Text = "Run";
            this.ProcessAsync2Button.UseVisualStyleBackColor = true;
            this.ProcessAsync2Button.Click += new System.EventHandler(this.ProcessAsync2Button_Click);
            // 
            // IterateFolderButton
            // 
            this.IterateFolderButton.Location = new System.Drawing.Point(13, 310);
            this.IterateFolderButton.Name = "IterateFolderButton";
            this.IterateFolderButton.Size = new System.Drawing.Size(98, 23);
            this.IterateFolderButton.TabIndex = 4;
            this.IterateFolderButton.Text = "Iterate folder";
            this.IterateFolderButton.UseVisualStyleBackColor = true;
            this.IterateFolderButton.Click += new System.EventHandler(this.IterateFolderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Task.WaitAll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WaitAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(202, 127);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(13, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 189);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WaitAll";
            // 
            // ExcelGroupBox
            // 
            this.ExcelGroupBox.Controls.Add(this.ExcelAsynchronousButton);
            this.ExcelGroupBox.Controls.Add(this.ExcelSynchronousButton);
            this.ExcelGroupBox.Location = new System.Drawing.Point(295, 115);
            this.ExcelGroupBox.Name = "ExcelGroupBox";
            this.ExcelGroupBox.Size = new System.Drawing.Size(280, 72);
            this.ExcelGroupBox.TabIndex = 8;
            this.ExcelGroupBox.TabStop = false;
            this.ExcelGroupBox.Text = "Excel automation";
            // 
            // ExcelAsynchronousButton
            // 
            this.ExcelAsynchronousButton.Location = new System.Drawing.Point(136, 28);
            this.ExcelAsynchronousButton.Name = "ExcelAsynchronousButton";
            this.ExcelAsynchronousButton.Size = new System.Drawing.Size(98, 23);
            this.ExcelAsynchronousButton.TabIndex = 2;
            this.ExcelAsynchronousButton.Text = "Asynchronous";
            this.ExcelAsynchronousButton.UseVisualStyleBackColor = true;
            this.ExcelAsynchronousButton.Click += new System.EventHandler(this.ExcelAsynchronousButton_Click);
            // 
            // ExcelSynchronousButton
            // 
            this.ExcelSynchronousButton.Location = new System.Drawing.Point(32, 28);
            this.ExcelSynchronousButton.Name = "ExcelSynchronousButton";
            this.ExcelSynchronousButton.Size = new System.Drawing.Size(98, 23);
            this.ExcelSynchronousButton.TabIndex = 1;
            this.ExcelSynchronousButton.Text = "Synchronous";
            this.ExcelSynchronousButton.UseVisualStyleBackColor = true;
            this.ExcelSynchronousButton.Click += new System.EventHandler(this.ExcelSynchronousButton_Click);
            // 
            // GetCurrentDateTimeButton
            // 
            this.GetCurrentDateTimeButton.Location = new System.Drawing.Point(29, 23);
            this.GetCurrentDateTimeButton.Name = "GetCurrentDateTimeButton";
            this.GetCurrentDateTimeButton.Size = new System.Drawing.Size(98, 23);
            this.GetCurrentDateTimeButton.TabIndex = 9;
            this.GetCurrentDateTimeButton.Text = "Get";
            this.GetCurrentDateTimeButton.UseVisualStyleBackColor = true;
            this.GetCurrentDateTimeButton.Click += new System.EventHandler(this.GetCurrentDateTimeButton_Click);
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(170, 28);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.ElapsedTimeLabel.TabIndex = 10;
            this.ElapsedTimeLabel.Text = "00-00-00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ElapsedTimeLabel);
            this.groupBox4.Controls.Add(this.GetCurrentDateTimeButton);
            this.groupBox4.Location = new System.Drawing.Point(298, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 68);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Internet get current date time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 340);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ExcelGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.IterateFolderButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ExcelGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProcessAsync1Button;
        private System.Windows.Forms.Button CancelExample1Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelExample2Button;
        private System.Windows.Forms.Button ProcessAsync2Button;
        private System.Windows.Forms.Label ProcessStatus1Label;
        private System.Windows.Forms.Label ProcessStatus2Label;
        private System.Windows.Forms.Button IterateFolderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox ExcelGroupBox;
        private System.Windows.Forms.Button ExcelSynchronousButton;
        private System.Windows.Forms.Button ExcelAsynchronousButton;
        private System.Windows.Forms.CheckBox EnableCrossThreadButton;
        private System.Windows.Forms.Button GetCurrentDateTimeButton;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

