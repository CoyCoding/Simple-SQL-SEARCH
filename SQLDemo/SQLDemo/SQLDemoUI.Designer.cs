namespace SQLDemo
{
    partial class SQLDemoUI
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
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchLastNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(12, 19);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(363, 498);
            this.CustomerListBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(475, 19);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.LastNameTextBox.TabIndex = 2;
            
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(411, 22);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SearchLastNameBtn
            // 
            this.SearchLastNameBtn.Location = new System.Drawing.Point(475, 45);
            this.SearchLastNameBtn.Name = "SearchLastNameBtn";
            this.SearchLastNameBtn.Size = new System.Drawing.Size(184, 24);
            this.SearchLastNameBtn.TabIndex = 4;
            this.SearchLastNameBtn.Text = "Search";
            this.SearchLastNameBtn.UseVisualStyleBackColor = true;
            this.SearchLastNameBtn.Click += new System.EventHandler(this.SearchLastNameBtn_Click);
            // 
            // SQLDemoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 529);
            this.Controls.Add(this.SearchLastNameBtn);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.CustomerListBox);
            this.Name = "SQLDemoUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchLastNameBtn;
    }
}

