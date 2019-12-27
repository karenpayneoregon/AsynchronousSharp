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
            this.ProcessStatus2Label = new System.Windows.Forms.Label();
            this.CancelExample2Button = new System.Windows.Forms.Button();
            this.ProcessAsync2Button = new System.Windows.Forms.Button();
            this.IterateFolderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(273, 66);
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
            this.groupBox2.Controls.Add(this.ProcessStatus2Label);
            this.groupBox2.Controls.Add(this.CancelExample2Button);
            this.groupBox2.Controls.Add(this.ProcessAsync2Button);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Async 2";
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
            this.IterateFolderButton.Location = new System.Drawing.Point(431, 101);
            this.IterateFolderButton.Name = "IterateFolderButton";
            this.IterateFolderButton.Size = new System.Drawing.Size(98, 23);
            this.IterateFolderButton.TabIndex = 4;
            this.IterateFolderButton.Text = "Iterate folder";
            this.IterateFolderButton.UseVisualStyleBackColor = true;
            this.IterateFolderButton.Click += new System.EventHandler(this.IterateFolderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Task.WaitAll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(202, 68);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

