
namespace MemoryReader
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
            this.PROCESS_SELECT_BUTTON = new System.Windows.Forms.Button();
            this.MEM_STRINGS = new System.Windows.Forms.ListBox();
            this.COPY_BUTTON = new System.Windows.Forms.Button();
            this.CURRENT_PROCESS_LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PROCESS_SELECT_BUTTON
            // 
            this.PROCESS_SELECT_BUTTON.Location = new System.Drawing.Point(12, 12);
            this.PROCESS_SELECT_BUTTON.Name = "PROCESS_SELECT_BUTTON";
            this.PROCESS_SELECT_BUTTON.Size = new System.Drawing.Size(111, 23);
            this.PROCESS_SELECT_BUTTON.TabIndex = 0;
            this.PROCESS_SELECT_BUTTON.Text = "Select A Process";
            this.PROCESS_SELECT_BUTTON.UseVisualStyleBackColor = true;
            this.PROCESS_SELECT_BUTTON.Click += new System.EventHandler(this.PROCESS_SELECT_BUTTON_Click);
            // 
            // MEM_STRINGS
            // 
            this.MEM_STRINGS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MEM_STRINGS.FormattingEnabled = true;
            this.MEM_STRINGS.Location = new System.Drawing.Point(13, 41);
            this.MEM_STRINGS.Name = "MEM_STRINGS";
            this.MEM_STRINGS.Size = new System.Drawing.Size(652, 251);
            this.MEM_STRINGS.TabIndex = 1;
            this.MEM_STRINGS.SelectedIndexChanged += new System.EventHandler(this.MEM_STRINGS_SelectedIndexChanged);
            // 
            // COPY_BUTTON
            // 
            this.COPY_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.COPY_BUTTON.Enabled = false;
            this.COPY_BUTTON.Location = new System.Drawing.Point(590, 298);
            this.COPY_BUTTON.Name = "COPY_BUTTON";
            this.COPY_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.COPY_BUTTON.TabIndex = 2;
            this.COPY_BUTTON.Text = "Copy";
            this.COPY_BUTTON.UseVisualStyleBackColor = true;
            this.COPY_BUTTON.Click += new System.EventHandler(this.COPY_BUTTON_Click);
            // 
            // CURRENT_PROCESS_LABEL
            // 
            this.CURRENT_PROCESS_LABEL.AutoSize = true;
            this.CURRENT_PROCESS_LABEL.Location = new System.Drawing.Point(10, 303);
            this.CURRENT_PROCESS_LABEL.Name = "CURRENT_PROCESS_LABEL";
            this.CURRENT_PROCESS_LABEL.Size = new System.Drawing.Size(94, 13);
            this.CURRENT_PROCESS_LABEL.TabIndex = 3;
            this.CURRENT_PROCESS_LABEL.Text = "Current Process: --";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 328);
            this.Controls.Add(this.CURRENT_PROCESS_LABEL);
            this.Controls.Add(this.COPY_BUTTON);
            this.Controls.Add(this.MEM_STRINGS);
            this.Controls.Add(this.PROCESS_SELECT_BUTTON);
            this.Name = "MainForm";
            this.Text = "Memory Reader Utility";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PROCESS_SELECT_BUTTON;
        private System.Windows.Forms.ListBox MEM_STRINGS;
        private System.Windows.Forms.Button COPY_BUTTON;
        private System.Windows.Forms.Label CURRENT_PROCESS_LABEL;
    }
}

