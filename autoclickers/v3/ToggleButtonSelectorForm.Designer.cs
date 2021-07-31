
namespace AutoClicker3
{
    partial class ToggleButtonSelectorForm
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
            this.TOGGLE_ON_KEY_TEXTBOX = new System.Windows.Forms.TextBox();
            this.TOGGLE_ON_KEY_BUTTON = new System.Windows.Forms.Button();
            this.TOGGLE_ON_KEY_LABEL = new System.Windows.Forms.Label();
            this.TOGGLE_OFF_KEY_LABEL = new System.Windows.Forms.Label();
            this.TOGGLE_OFF_KEY_TEXTBOX = new System.Windows.Forms.TextBox();
            this.TOGGLE_OFF_KEY_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TOGGLE_ON_KEY_TEXTBOX
            // 
            this.TOGGLE_ON_KEY_TEXTBOX.Location = new System.Drawing.Point(13, 40);
            this.TOGGLE_ON_KEY_TEXTBOX.Name = "TOGGLE_ON_KEY_TEXTBOX";
            this.TOGGLE_ON_KEY_TEXTBOX.Size = new System.Drawing.Size(122, 20);
            this.TOGGLE_ON_KEY_TEXTBOX.TabIndex = 0;
            this.TOGGLE_ON_KEY_TEXTBOX.TextChanged += new System.EventHandler(this.TOGGLE_ON_KEY_TEXTBOX_TextChanged);
            // 
            // TOGGLE_ON_KEY_BUTTON
            // 
            this.TOGGLE_ON_KEY_BUTTON.Enabled = false;
            this.TOGGLE_ON_KEY_BUTTON.Location = new System.Drawing.Point(141, 38);
            this.TOGGLE_ON_KEY_BUTTON.Name = "TOGGLE_ON_KEY_BUTTON";
            this.TOGGLE_ON_KEY_BUTTON.Size = new System.Drawing.Size(105, 23);
            this.TOGGLE_ON_KEY_BUTTON.TabIndex = 1;
            this.TOGGLE_ON_KEY_BUTTON.Text = "Set to Toggle On";
            this.TOGGLE_ON_KEY_BUTTON.UseVisualStyleBackColor = true;
            this.TOGGLE_ON_KEY_BUTTON.Click += new System.EventHandler(this.TOGGLE_ON_KEY_BUTTON_Click);
            // 
            // TOGGLE_ON_KEY_LABEL
            // 
            this.TOGGLE_ON_KEY_LABEL.AutoSize = true;
            this.TOGGLE_ON_KEY_LABEL.Location = new System.Drawing.Point(12, 21);
            this.TOGGLE_ON_KEY_LABEL.Name = "TOGGLE_ON_KEY_LABEL";
            this.TOGGLE_ON_KEY_LABEL.Size = new System.Drawing.Size(78, 13);
            this.TOGGLE_ON_KEY_LABEL.TabIndex = 2;
            this.TOGGLE_ON_KEY_LABEL.Text = "Toggle On Key";
            // 
            // TOGGLE_OFF_KEY_LABEL
            // 
            this.TOGGLE_OFF_KEY_LABEL.AutoSize = true;
            this.TOGGLE_OFF_KEY_LABEL.Location = new System.Drawing.Point(12, 106);
            this.TOGGLE_OFF_KEY_LABEL.Name = "TOGGLE_OFF_KEY_LABEL";
            this.TOGGLE_OFF_KEY_LABEL.Size = new System.Drawing.Size(78, 13);
            this.TOGGLE_OFF_KEY_LABEL.TabIndex = 3;
            this.TOGGLE_OFF_KEY_LABEL.Text = "Toggle Off Key";
            // 
            // TOGGLE_OFF_KEY_TEXTBOX
            // 
            this.TOGGLE_OFF_KEY_TEXTBOX.Location = new System.Drawing.Point(15, 127);
            this.TOGGLE_OFF_KEY_TEXTBOX.Name = "TOGGLE_OFF_KEY_TEXTBOX";
            this.TOGGLE_OFF_KEY_TEXTBOX.Size = new System.Drawing.Size(122, 20);
            this.TOGGLE_OFF_KEY_TEXTBOX.TabIndex = 4;
            this.TOGGLE_OFF_KEY_TEXTBOX.TextChanged += new System.EventHandler(this.TOGGLE_OFF_KEY_TEXTBOX_TextChanged);
            // 
            // TOGGLE_OFF_KEY_BUTTON
            // 
            this.TOGGLE_OFF_KEY_BUTTON.Enabled = false;
            this.TOGGLE_OFF_KEY_BUTTON.Location = new System.Drawing.Point(143, 125);
            this.TOGGLE_OFF_KEY_BUTTON.Name = "TOGGLE_OFF_KEY_BUTTON";
            this.TOGGLE_OFF_KEY_BUTTON.Size = new System.Drawing.Size(105, 23);
            this.TOGGLE_OFF_KEY_BUTTON.TabIndex = 5;
            this.TOGGLE_OFF_KEY_BUTTON.Text = "Set to Toggle On";
            this.TOGGLE_OFF_KEY_BUTTON.UseVisualStyleBackColor = true;
            this.TOGGLE_OFF_KEY_BUTTON.Click += new System.EventHandler(this.TOGGLE_OFF_KEY_BUTTON_Click);
            // 
            // ToggleButtonSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 164);
            this.Controls.Add(this.TOGGLE_OFF_KEY_BUTTON);
            this.Controls.Add(this.TOGGLE_OFF_KEY_TEXTBOX);
            this.Controls.Add(this.TOGGLE_OFF_KEY_LABEL);
            this.Controls.Add(this.TOGGLE_ON_KEY_LABEL);
            this.Controls.Add(this.TOGGLE_ON_KEY_BUTTON);
            this.Controls.Add(this.TOGGLE_ON_KEY_TEXTBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ToggleButtonSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select the toggle buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TOGGLE_ON_KEY_TEXTBOX;
        private System.Windows.Forms.Button TOGGLE_ON_KEY_BUTTON;
        private System.Windows.Forms.Label TOGGLE_ON_KEY_LABEL;
        private System.Windows.Forms.Label TOGGLE_OFF_KEY_LABEL;
        private System.Windows.Forms.TextBox TOGGLE_OFF_KEY_TEXTBOX;
        private System.Windows.Forms.Button TOGGLE_OFF_KEY_BUTTON;
    }
}