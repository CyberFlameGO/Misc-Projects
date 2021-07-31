
namespace AutoClicker3
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
            this.CPS_SELECTOR = new System.Windows.Forms.NumericUpDown();
            this.CPS_LABEL = new System.Windows.Forms.Label();
            this.MB_SELECTOR = new System.Windows.Forms.ComboBox();
            this.MB_LABEL = new System.Windows.Forms.Label();
            this.REPEAT_X = new System.Windows.Forms.RadioButton();
            this.REPEAT_UNTIL_STOPPED = new System.Windows.Forms.RadioButton();
            this.REPEAT_SELECTOR = new System.Windows.Forms.NumericUpDown();
            this.REPEAT_X_LABEL = new System.Windows.Forms.Label();
            this.EDIT_TOGGLES_BUTTON = new System.Windows.Forms.Button();
            this.TOGGLE_ON_KEY_LABEL = new System.Windows.Forms.Label();
            this.TOGGLE_OFF_KEY_LABEL = new System.Windows.Forms.Label();
            this.KEY_LISTENER = new System.ComponentModel.BackgroundWorker();
            this.START_BUTTON = new System.Windows.Forms.Button();
            this.STOP_BUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CPS_SELECTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPEAT_SELECTOR)).BeginInit();
            this.SuspendLayout();
            // 
            // CPS_SELECTOR
            // 
            this.CPS_SELECTOR.Location = new System.Drawing.Point(13, 13);
            this.CPS_SELECTOR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPS_SELECTOR.Name = "CPS_SELECTOR";
            this.CPS_SELECTOR.Size = new System.Drawing.Size(150, 20);
            this.CPS_SELECTOR.TabIndex = 0;
            this.CPS_SELECTOR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPS_SELECTOR.ValueChanged += new System.EventHandler(this.CPS_SELECTOR_ValueChanged);
            // 
            // CPS_LABEL
            // 
            this.CPS_LABEL.AutoSize = true;
            this.CPS_LABEL.Location = new System.Drawing.Point(170, 18);
            this.CPS_LABEL.Name = "CPS_LABEL";
            this.CPS_LABEL.Size = new System.Drawing.Size(28, 13);
            this.CPS_LABEL.TabIndex = 1;
            this.CPS_LABEL.Text = "CPS";
            // 
            // MB_SELECTOR
            // 
            this.MB_SELECTOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MB_SELECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MB_SELECTOR.FormattingEnabled = true;
            this.MB_SELECTOR.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.MB_SELECTOR.Location = new System.Drawing.Point(204, 13);
            this.MB_SELECTOR.Name = "MB_SELECTOR";
            this.MB_SELECTOR.Size = new System.Drawing.Size(121, 21);
            this.MB_SELECTOR.TabIndex = 2;
            this.MB_SELECTOR.SelectedIndexChanged += new System.EventHandler(this.MB_SELECTOR_SelectedIndexChanged);
            this.MB_SELECTOR.SelectedItem = "Left";
            // 
            // MB_LABEL
            // 
            this.MB_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MB_LABEL.AutoSize = true;
            this.MB_LABEL.Location = new System.Drawing.Point(331, 17);
            this.MB_LABEL.Name = "MB_LABEL";
            this.MB_LABEL.Size = new System.Drawing.Size(73, 13);
            this.MB_LABEL.TabIndex = 3;
            this.MB_LABEL.Text = "Mouse Button";
            // 
            // REPEAT_X
            // 
            this.REPEAT_X.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.REPEAT_X.AutoSize = true;
            this.REPEAT_X.Location = new System.Drawing.Point(13, 58);
            this.REPEAT_X.Name = "REPEAT_X";
            this.REPEAT_X.Size = new System.Drawing.Size(60, 17);
            this.REPEAT_X.TabIndex = 4;
            this.REPEAT_X.TabStop = true;
            this.REPEAT_X.Text = "Repeat";
            this.REPEAT_X.UseVisualStyleBackColor = true;
            this.REPEAT_X.CheckedChanged += new System.EventHandler(this.REPEAT_X_CheckedChanged);
            // 
            // REPEAT_UNTIL_STOPPED
            // 
            this.REPEAT_UNTIL_STOPPED.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.REPEAT_UNTIL_STOPPED.AutoSize = true;
            this.REPEAT_UNTIL_STOPPED.Checked = true;
            this.REPEAT_UNTIL_STOPPED.Location = new System.Drawing.Point(13, 82);
            this.REPEAT_UNTIL_STOPPED.Name = "REPEAT_UNTIL_STOPPED";
            this.REPEAT_UNTIL_STOPPED.Size = new System.Drawing.Size(123, 17);
            this.REPEAT_UNTIL_STOPPED.TabIndex = 5;
            this.REPEAT_UNTIL_STOPPED.TabStop = true;
            this.REPEAT_UNTIL_STOPPED.Text = "Repeat until stopped";
            this.REPEAT_UNTIL_STOPPED.UseVisualStyleBackColor = true;
            this.REPEAT_UNTIL_STOPPED.CheckedChanged += new System.EventHandler(this.REPEAT_UNTIL_STOPPED_CheckedChanged);
            // 
            // REPEAT_SELECTOR
            // 
            this.REPEAT_SELECTOR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.REPEAT_SELECTOR.Location = new System.Drawing.Point(74, 59);
            this.REPEAT_SELECTOR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.REPEAT_SELECTOR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.REPEAT_SELECTOR.Name = "REPEAT_SELECTOR";
            this.REPEAT_SELECTOR.Size = new System.Drawing.Size(41, 20);
            this.REPEAT_SELECTOR.TabIndex = 6;
            this.REPEAT_SELECTOR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.REPEAT_SELECTOR.ValueChanged += new System.EventHandler(this.REPEAT_SELECTOR_ValueChanged);
            // 
            // REPEAT_X_LABEL
            // 
            this.REPEAT_X_LABEL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.REPEAT_X_LABEL.AutoSize = true;
            this.REPEAT_X_LABEL.Location = new System.Drawing.Point(119, 61);
            this.REPEAT_X_LABEL.Name = "REPEAT_X_LABEL";
            this.REPEAT_X_LABEL.Size = new System.Drawing.Size(31, 13);
            this.REPEAT_X_LABEL.TabIndex = 7;
            this.REPEAT_X_LABEL.Text = "times";
            // 
            // EDIT_TOGGLES_BUTTON
            // 
            this.EDIT_TOGGLES_BUTTON.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EDIT_TOGGLES_BUTTON.Location = new System.Drawing.Point(204, 74);
            this.EDIT_TOGGLES_BUTTON.Name = "EDIT_TOGGLES_BUTTON";
            this.EDIT_TOGGLES_BUTTON.Size = new System.Drawing.Size(193, 25);
            this.EDIT_TOGGLES_BUTTON.TabIndex = 8;
            this.EDIT_TOGGLES_BUTTON.Text = "Edit toggle buttons";
            this.EDIT_TOGGLES_BUTTON.UseVisualStyleBackColor = true;
            this.EDIT_TOGGLES_BUTTON.Click += new System.EventHandler(this.EDIT_TOGGLES_BUTTON_Click);
            // 
            // TOGGLE_ON_KEY_LABEL
            // 
            this.TOGGLE_ON_KEY_LABEL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TOGGLE_ON_KEY_LABEL.AutoSize = true;
            this.TOGGLE_ON_KEY_LABEL.Location = new System.Drawing.Point(204, 55);
            this.TOGGLE_ON_KEY_LABEL.Name = "TOGGLE_ON_KEY_LABEL";
            this.TOGGLE_ON_KEY_LABEL.Size = new System.Drawing.Size(71, 13);
            this.TOGGLE_ON_KEY_LABEL.TabIndex = 9;
            this.TOGGLE_ON_KEY_LABEL.Text = "Toggle On: Q";
            // 
            // TOGGLE_OFF_KEY_LABEL
            // 
            this.TOGGLE_OFF_KEY_LABEL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TOGGLE_OFF_KEY_LABEL.AutoSize = true;
            this.TOGGLE_OFF_KEY_LABEL.Location = new System.Drawing.Point(295, 55);
            this.TOGGLE_OFF_KEY_LABEL.Name = "TOGGLE_OFF_KEY_LABEL";
            this.TOGGLE_OFF_KEY_LABEL.Size = new System.Drawing.Size(70, 13);
            this.TOGGLE_OFF_KEY_LABEL.TabIndex = 10;
            this.TOGGLE_OFF_KEY_LABEL.Text = "Toggle Off: Z";
            // 
            // KEY_LISTENER
            // 
            this.KEY_LISTENER.DoWork += new System.ComponentModel.DoWorkEventHandler(this.KEY_LISTENER_DoWork);
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.START_BUTTON.Location = new System.Drawing.Point(12, 116);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(186, 47);
            this.START_BUTTON.TabIndex = 11;
            this.START_BUTTON.Text = "Start (Q)";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            this.START_BUTTON.Click += new System.EventHandler(this.START_BUTTON_Click);
            // 
            // STOP_BUTTON
            // 
            this.STOP_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.STOP_BUTTON.Enabled = false;
            this.STOP_BUTTON.Location = new System.Drawing.Point(211, 116);
            this.STOP_BUTTON.Name = "STOP_BUTTON";
            this.STOP_BUTTON.Size = new System.Drawing.Size(186, 47);
            this.STOP_BUTTON.TabIndex = 12;
            this.STOP_BUTTON.Text = "Stop (Z)";
            this.STOP_BUTTON.UseVisualStyleBackColor = true;
            this.STOP_BUTTON.Click += new System.EventHandler(this.STOP_BUTTON_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 175);
            this.Controls.Add(this.STOP_BUTTON);
            this.Controls.Add(this.START_BUTTON);
            this.Controls.Add(this.TOGGLE_OFF_KEY_LABEL);
            this.Controls.Add(this.TOGGLE_ON_KEY_LABEL);
            this.Controls.Add(this.EDIT_TOGGLES_BUTTON);
            this.Controls.Add(this.REPEAT_X_LABEL);
            this.Controls.Add(this.REPEAT_SELECTOR);
            this.Controls.Add(this.REPEAT_UNTIL_STOPPED);
            this.Controls.Add(this.REPEAT_X);
            this.Controls.Add(this.MB_LABEL);
            this.Controls.Add(this.MB_SELECTOR);
            this.Controls.Add(this.CPS_LABEL);
            this.Controls.Add(this.CPS_SELECTOR);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "AutoClicker v3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPS_SELECTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPEAT_SELECTOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CPS_SELECTOR;
        private System.Windows.Forms.Label CPS_LABEL;
        private System.Windows.Forms.ComboBox MB_SELECTOR;
        private System.Windows.Forms.Label MB_LABEL;
        private System.Windows.Forms.RadioButton REPEAT_X;
        private System.Windows.Forms.RadioButton REPEAT_UNTIL_STOPPED;
        private System.Windows.Forms.NumericUpDown REPEAT_SELECTOR;
        private System.Windows.Forms.Label REPEAT_X_LABEL;
        private System.Windows.Forms.Button EDIT_TOGGLES_BUTTON;
        private System.Windows.Forms.Label TOGGLE_ON_KEY_LABEL;
        private System.Windows.Forms.Label TOGGLE_OFF_KEY_LABEL;
        private System.ComponentModel.BackgroundWorker KEY_LISTENER;
        private System.Windows.Forms.Button START_BUTTON;
        private System.Windows.Forms.Button STOP_BUTTON;
    }
}

