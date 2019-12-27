namespace ForumQuestion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.SearchForTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FirstEmptyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstEmptyButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SectionTextBox);
            this.panel1.Controls.Add(this.SearchForTextBox);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Section";
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Location = new System.Drawing.Point(301, 22);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.SectionTextBox.TabIndex = 2;
            // 
            // SearchForTextBox
            // 
            this.SearchForTextBox.Location = new System.Drawing.Point(93, 21);
            this.SearchForTextBox.Name = "SearchForTextBox";
            this.SearchForTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchForTextBox.TabIndex = 1;
            this.SearchForTextBox.Text = "E103";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(12, 19);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "button1";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FirstEmptyButton
            // 
            this.FirstEmptyButton.Location = new System.Drawing.Point(583, 21);
            this.FirstEmptyButton.Name = "FirstEmptyButton";
            this.FirstEmptyButton.Size = new System.Drawing.Size(75, 23);
            this.FirstEmptyButton.TabIndex = 4;
            this.FirstEmptyButton.Text = "First empty";
            this.FirstEmptyButton.UseVisualStyleBackColor = true;
            this.FirstEmptyButton.Click += new System.EventHandler(this.FirstEmptyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchForTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.Button FirstEmptyButton;
    }
}

