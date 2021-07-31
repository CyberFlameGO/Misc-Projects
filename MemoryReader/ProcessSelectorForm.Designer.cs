
namespace MemoryReader
{
    partial class ProcessSelectorForm
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
            this.ENTER_BUTTON = new System.Windows.Forms.Button();
            this.ENTER_PROCESS_NAME = new System.Windows.Forms.TextBox();
            this.ENTER_PROCESS_LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ENTER_BUTTON
            // 
            this.ENTER_BUTTON.Enabled = false;
            this.ENTER_BUTTON.Location = new System.Drawing.Point(197, 8);
            this.ENTER_BUTTON.Name = "ENTER_BUTTON";
            this.ENTER_BUTTON.Size = new System.Drawing.Size(81, 47);
            this.ENTER_BUTTON.TabIndex = 0;
            this.ENTER_BUTTON.Text = "Enter";
            this.ENTER_BUTTON.UseVisualStyleBackColor = true;
            this.ENTER_BUTTON.Click += new System.EventHandler(this.ENTER_BUTTON_Click);
            // 
            // ENTER_PROCESS_NAME
            // 
            this.ENTER_PROCESS_NAME.Location = new System.Drawing.Point(12, 35);
            this.ENTER_PROCESS_NAME.Name = "ENTER_PROCESS_NAME";
            this.ENTER_PROCESS_NAME.Size = new System.Drawing.Size(171, 20);
            this.ENTER_PROCESS_NAME.TabIndex = 1;
            this.ENTER_PROCESS_NAME.TextChanged += new System.EventHandler(this.ENTER_PROCESS_NAME_TextChanged);
            // 
            // ENTER_PROCESS_LABEL
            // 
            this.ENTER_PROCESS_LABEL.AutoSize = true;
            this.ENTER_PROCESS_LABEL.Location = new System.Drawing.Point(12, 12);
            this.ENTER_PROCESS_LABEL.Name = "ENTER_PROCESS_LABEL";
            this.ENTER_PROCESS_LABEL.Size = new System.Drawing.Size(120, 13);
            this.ENTER_PROCESS_LABEL.TabIndex = 2;
            this.ENTER_PROCESS_LABEL.Text = "Type in a process name";
            // 
            // ProcessSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 68);
            this.Controls.Add(this.ENTER_PROCESS_LABEL);
            this.Controls.Add(this.ENTER_PROCESS_NAME);
            this.Controls.Add(this.ENTER_BUTTON);
            this.Name = "ProcessSelectorForm";
            this.Text = "Select A Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ENTER_BUTTON;
        private System.Windows.Forms.TextBox ENTER_PROCESS_NAME;
        private System.Windows.Forms.Label ENTER_PROCESS_LABEL;
    }
}