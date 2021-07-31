
namespace CFile
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
            this.ADDRESS_BAR = new System.Windows.Forms.TextBox();
            this.ADDRESS_LABEL = new System.Windows.Forms.Label();
            this.BROWSE_BUTTON = new System.Windows.Forms.Button();
            this.FILE_BROWSER = new System.Windows.Forms.WebBrowser();
            this.BACK_BUTTON = new System.Windows.Forms.Button();
            this.FORWARD_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADDRESS_BAR
            // 
            this.ADDRESS_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADDRESS_BAR.Location = new System.Drawing.Point(50, 12);
            this.ADDRESS_BAR.Name = "ADDRESS_BAR";
            this.ADDRESS_BAR.ReadOnly = true;
            this.ADDRESS_BAR.Size = new System.Drawing.Size(381, 20);
            this.ADDRESS_BAR.TabIndex = 2;
            // 
            // ADDRESS_LABEL
            // 
            this.ADDRESS_LABEL.AutoSize = true;
            this.ADDRESS_LABEL.Location = new System.Drawing.Point(12, 15);
            this.ADDRESS_LABEL.Name = "ADDRESS_LABEL";
            this.ADDRESS_LABEL.Size = new System.Drawing.Size(32, 13);
            this.ADDRESS_LABEL.TabIndex = 3;
            this.ADDRESS_LABEL.Text = "Path:";
            // 
            // BROWSE_BUTTON
            // 
            this.BROWSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BROWSE_BUTTON.Location = new System.Drawing.Point(448, 12);
            this.BROWSE_BUTTON.Name = "BROWSE_BUTTON";
            this.BROWSE_BUTTON.Size = new System.Drawing.Size(75, 22);
            this.BROWSE_BUTTON.TabIndex = 4;
            this.BROWSE_BUTTON.Text = "Browse";
            this.BROWSE_BUTTON.UseVisualStyleBackColor = true;
            this.BROWSE_BUTTON.Click += new System.EventHandler(this.BROWSE_BUTTON_Click);
            // 
            // FILE_BROWSER
            // 
            this.FILE_BROWSER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FILE_BROWSER.Location = new System.Drawing.Point(15, 44);
            this.FILE_BROWSER.MinimumSize = new System.Drawing.Size(20, 20);
            this.FILE_BROWSER.Name = "FILE_BROWSER";
            this.FILE_BROWSER.Size = new System.Drawing.Size(507, 162);
            this.FILE_BROWSER.TabIndex = 5;
            this.FILE_BROWSER.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.FILE_BROWSER_DocumentCompleted);
            // 
            // BACK_BUTTON
            // 
            this.BACK_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BACK_BUTTON.Location = new System.Drawing.Point(15, 212);
            this.BACK_BUTTON.Name = "BACK_BUTTON";
            this.BACK_BUTTON.Size = new System.Drawing.Size(29, 23);
            this.BACK_BUTTON.TabIndex = 6;
            this.BACK_BUTTON.Text = "<";
            this.BACK_BUTTON.UseVisualStyleBackColor = true;
            this.BACK_BUTTON.Click += new System.EventHandler(this.BACK_BUTTON_Click);
            // 
            // FORWARD_BUTTON
            // 
            this.FORWARD_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FORWARD_BUTTON.Location = new System.Drawing.Point(493, 212);
            this.FORWARD_BUTTON.Name = "FORWARD_BUTTON";
            this.FORWARD_BUTTON.Size = new System.Drawing.Size(29, 23);
            this.FORWARD_BUTTON.TabIndex = 7;
            this.FORWARD_BUTTON.Text = ">";
            this.FORWARD_BUTTON.UseVisualStyleBackColor = true;
            this.FORWARD_BUTTON.Click += new System.EventHandler(this.FORWARD_BUTTON_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 243);
            this.Controls.Add(this.FORWARD_BUTTON);
            this.Controls.Add(this.BACK_BUTTON);
            this.Controls.Add(this.FILE_BROWSER);
            this.Controls.Add(this.BROWSE_BUTTON);
            this.Controls.Add(this.ADDRESS_LABEL);
            this.Controls.Add(this.ADDRESS_BAR);
            this.Name = "MainForm";
            this.Text = "C-File v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ADDRESS_BAR;
        private System.Windows.Forms.Label ADDRESS_LABEL;
        private System.Windows.Forms.Button BROWSE_BUTTON;
        private System.Windows.Forms.WebBrowser FILE_BROWSER;
        private System.Windows.Forms.Button BACK_BUTTON;
        private System.Windows.Forms.Button FORWARD_BUTTON;
    }
}

