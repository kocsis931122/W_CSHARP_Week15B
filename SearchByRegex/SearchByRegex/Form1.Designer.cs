namespace SearchByRegex
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.MatchedlBox = new System.Windows.Forms.ListBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(95, 38);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.Location = new System.Drawing.Point(498, 38);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(49, 13);
            this.lblMatched.TabIndex = 1;
            this.lblMatched.Text = "Matched";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(95, 232);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 2;
            this.lblPattern.Text = "Pattern";
            // 
            // MatchedlBox
            // 
            this.MatchedlBox.FormattingEnabled = true;
            this.MatchedlBox.Location = new System.Drawing.Point(501, 64);
            this.MatchedlBox.Name = "MatchedlBox";
            this.MatchedlBox.Size = new System.Drawing.Size(231, 147);
            this.MatchedlBox.TabIndex = 4;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(149, 232);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(299, 20);
            this.txtPattern.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(501, 232);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // txtTextbox
            // 
            this.txtTextbox.Location = new System.Drawing.Point(98, 64);
            this.txtTextbox.Multiline = true;
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.Size = new System.Drawing.Size(350, 147);
            this.txtTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 290);
            this.Controls.Add(this.txtTextbox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.MatchedlBox);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblMatched);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMatched;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.ListBox MatchedlBox;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtTextbox;
    }
}

