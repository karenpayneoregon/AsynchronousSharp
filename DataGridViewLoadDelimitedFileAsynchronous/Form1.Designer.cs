namespace DataGridViewLoadDelimitedFileAsynchronous
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveCurrentButton = new System.Windows.Forms.Button();
            this.CustomersComoBox = new System.Windows.Forms.ComboBox();
            this.ContinueWith1Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelExample1Button = new System.Windows.Forms.Button();
            this.Example1WithCancelButton = new System.Windows.Forms.Button();
            this.ExpandColumnsCheckBox = new System.Windows.Forms.CheckBox();
            this.ConventionalReadButton = new System.Windows.Forms.Button();
            this.Example5Button = new System.Windows.Forms.Button();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Example4Button = new System.Windows.Forms.Button();
            this.Example3Button = new System.Windows.Forms.Button();
            this.Example2Button = new System.Windows.Forms.Button();
            this.Example1Button = new System.Windows.Forms.Button();
            this.Example5aButton = new System.Windows.Forms.Button();
            this.PleaseWaitPanel = new System.Windows.Forms.Panel();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PleaseWaitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(848, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveCurrentButton);
            this.panel1.Controls.Add(this.CustomersComoBox);
            this.panel1.Controls.Add(this.ContinueWith1Button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ExpandColumnsCheckBox);
            this.panel1.Controls.Add(this.ConventionalReadButton);
            this.panel1.Controls.Add(this.Example5Button);
            this.panel1.Controls.Add(this.ElapsedTimeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Example4Button);
            this.panel1.Controls.Add(this.Example3Button);
            this.panel1.Controls.Add(this.Example2Button);
            this.panel1.Controls.Add(this.Example1Button);
            this.panel1.Controls.Add(this.Example5aButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 178);
            this.panel1.TabIndex = 2;
            // 
            // RemoveCurrentButton
            // 
            this.RemoveCurrentButton.Enabled = false;
            this.RemoveCurrentButton.Location = new System.Drawing.Point(310, 105);
            this.RemoveCurrentButton.Name = "RemoveCurrentButton";
            this.RemoveCurrentButton.Size = new System.Drawing.Size(132, 23);
            this.RemoveCurrentButton.TabIndex = 20;
            this.RemoveCurrentButton.Text = "Remove current";
            this.RemoveCurrentButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentButton.Click += new System.EventHandler(this.RemoveCurrentButton_Click);
            // 
            // CustomersComoBox
            // 
            this.CustomersComoBox.FormattingEnabled = true;
            this.CustomersComoBox.Location = new System.Drawing.Point(480, 42);
            this.CustomersComoBox.Name = "CustomersComoBox";
            this.CustomersComoBox.Size = new System.Drawing.Size(132, 21);
            this.CustomersComoBox.TabIndex = 18;
            // 
            // ContinueWith1Button
            // 
            this.ContinueWith1Button.Location = new System.Drawing.Point(480, 13);
            this.ContinueWith1Button.Name = "ContinueWith1Button";
            this.ContinueWith1Button.Size = new System.Drawing.Size(132, 23);
            this.ContinueWith1Button.TabIndex = 17;
            this.ContinueWith1Button.Text = "Example ContineWith 1";
            this.ContinueWith1Button.UseVisualStyleBackColor = true;
            this.ContinueWith1Button.Click += new System.EventHandler(this.ContinueWith1Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelExample1Button);
            this.groupBox1.Controls.Add(this.Example1WithCancelButton);
            this.groupBox1.Location = new System.Drawing.Point(290, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // CancelExample1Button
            // 
            this.CancelExample1Button.Location = new System.Drawing.Point(20, 48);
            this.CancelExample1Button.Name = "CancelExample1Button";
            this.CancelExample1Button.Size = new System.Drawing.Size(132, 23);
            this.CancelExample1Button.TabIndex = 15;
            this.CancelExample1Button.Text = "Cancel";
            this.CancelExample1Button.UseVisualStyleBackColor = true;
            this.CancelExample1Button.Click += new System.EventHandler(this.CancelExample1Button_Click);
            // 
            // Example1WithCancelButton
            // 
            this.Example1WithCancelButton.Location = new System.Drawing.Point(20, 19);
            this.Example1WithCancelButton.Name = "Example1WithCancelButton";
            this.Example1WithCancelButton.Size = new System.Drawing.Size(132, 23);
            this.Example1WithCancelButton.TabIndex = 14;
            this.Example1WithCancelButton.Text = "Example 1 with cancel";
            this.Example1WithCancelButton.UseVisualStyleBackColor = true;
            this.Example1WithCancelButton.Click += new System.EventHandler(this.Example1WithCancelButton_Click);
            // 
            // ExpandColumnsCheckBox
            // 
            this.ExpandColumnsCheckBox.AutoSize = true;
            this.ExpandColumnsCheckBox.Location = new System.Drawing.Point(150, 109);
            this.ExpandColumnsCheckBox.Name = "ExpandColumnsCheckBox";
            this.ExpandColumnsCheckBox.Size = new System.Drawing.Size(104, 17);
            this.ExpandColumnsCheckBox.TabIndex = 13;
            this.ExpandColumnsCheckBox.Text = "Expand columns";
            this.ExpandColumnsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConventionalReadButton
            // 
            this.ConventionalReadButton.Location = new System.Drawing.Point(12, 105);
            this.ConventionalReadButton.Name = "ConventionalReadButton";
            this.ConventionalReadButton.Size = new System.Drawing.Size(132, 23);
            this.ConventionalReadButton.TabIndex = 12;
            this.ConventionalReadButton.Text = "Conventional";
            this.ConventionalReadButton.UseVisualStyleBackColor = true;
            this.ConventionalReadButton.Click += new System.EventHandler(this.ConventionalReadButton_Click);
            // 
            // Example5Button
            // 
            this.Example5Button.Location = new System.Drawing.Point(150, 47);
            this.Example5Button.Name = "Example5Button";
            this.Example5Button.Size = new System.Drawing.Size(132, 23);
            this.Example5Button.TabIndex = 11;
            this.Example5Button.Text = "Example 5";
            this.Example5Button.UseVisualStyleBackColor = true;
            this.Example5Button.Click += new System.EventHandler(this.Example5Button_Click);
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(785, 18);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.ElapsedTimeLabel.TabIndex = 10;
            this.ElapsedTimeLabel.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elasped time";
            // 
            // Example4Button
            // 
            this.Example4Button.Location = new System.Drawing.Point(150, 13);
            this.Example4Button.Name = "Example4Button";
            this.Example4Button.Size = new System.Drawing.Size(132, 23);
            this.Example4Button.TabIndex = 8;
            this.Example4Button.Text = "Example 4";
            this.Example4Button.UseVisualStyleBackColor = true;
            this.Example4Button.Click += new System.EventHandler(this.Example4Button_Click);
            // 
            // Example3Button
            // 
            this.Example3Button.Location = new System.Drawing.Point(12, 76);
            this.Example3Button.Name = "Example3Button";
            this.Example3Button.Size = new System.Drawing.Size(132, 23);
            this.Example3Button.TabIndex = 7;
            this.Example3Button.Text = "Example 3";
            this.Example3Button.UseVisualStyleBackColor = true;
            this.Example3Button.Click += new System.EventHandler(this.Example3Button_Click);
            // 
            // Example2Button
            // 
            this.Example2Button.Location = new System.Drawing.Point(12, 47);
            this.Example2Button.Name = "Example2Button";
            this.Example2Button.Size = new System.Drawing.Size(132, 23);
            this.Example2Button.TabIndex = 6;
            this.Example2Button.Text = "Example 2";
            this.Example2Button.UseVisualStyleBackColor = true;
            this.Example2Button.Click += new System.EventHandler(this.Example2Button_Click);
            // 
            // Example1Button
            // 
            this.Example1Button.Location = new System.Drawing.Point(12, 13);
            this.Example1Button.Name = "Example1Button";
            this.Example1Button.Size = new System.Drawing.Size(132, 23);
            this.Example1Button.TabIndex = 5;
            this.Example1Button.Text = "Example 1";
            this.Example1Button.UseVisualStyleBackColor = true;
            this.Example1Button.Click += new System.EventHandler(this.Example1Button_Click);
            // 
            // Example5aButton
            // 
            this.Example5aButton.Location = new System.Drawing.Point(150, 76);
            this.Example5aButton.Name = "Example5aButton";
            this.Example5aButton.Size = new System.Drawing.Size(132, 23);
            this.Example5aButton.TabIndex = 3;
            this.Example5aButton.Text = "Example 5A";
            this.Example5aButton.UseVisualStyleBackColor = true;
            this.Example5aButton.Click += new System.EventHandler(this.Example5AButton_Click);
            // 
            // PleaseWaitPanel
            // 
            this.PleaseWaitPanel.Controls.Add(this.PleaseWaitLabel);
            this.PleaseWaitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PleaseWaitPanel.Location = new System.Drawing.Point(0, 25);
            this.PleaseWaitPanel.Name = "PleaseWaitPanel";
            this.PleaseWaitPanel.Size = new System.Drawing.Size(848, 262);
            this.PleaseWaitPanel.TabIndex = 3;
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.AutoSize = true;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(338, 26);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(125, 13);
            this.PleaseWaitLabel.TabIndex = 0;
            this.PleaseWaitLabel.Text = "Loading data please wait";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PleaseWaitPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load comma delimited file asynchronous";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.PleaseWaitPanel.ResumeLayout(false);
            this.PleaseWaitPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Example5aButton;
        private System.Windows.Forms.Button Example1Button;
        private System.Windows.Forms.Button Example2Button;
        private System.Windows.Forms.Button Example3Button;
        private System.Windows.Forms.Panel PleaseWaitPanel;
        private System.Windows.Forms.Label PleaseWaitLabel;
        private System.Windows.Forms.Button Example4Button;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Example5Button;
        private System.Windows.Forms.Button ConventionalReadButton;
        private System.Windows.Forms.CheckBox ExpandColumnsCheckBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button Example1WithCancelButton;
        private System.Windows.Forms.Button CancelExample1Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ContinueWith1Button;
        private System.Windows.Forms.ComboBox CustomersComoBox;
        private System.Windows.Forms.Button RemoveCurrentButton;
    }
}

