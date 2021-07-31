using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace AutoClicker3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys V_KEY);

        public void SET_TOGGLE_ON_LABEL(string TEXT) { TOGGLE_ON_KEY_LABEL.Text = TEXT; }
        public void SET_TOGGLE_OFF_LABEL(string TEXT) { TOGGLE_OFF_KEY_LABEL.Text = TEXT; }

        public void SET_START_BUTTON_ENABLED(bool ENABLED) { START_BUTTON.Enabled = ENABLED; }
        public void SET_STOP_BUTTON_ENABLED(bool ENABLED) { STOP_BUTTON.Enabled = ENABLED; }

        public void SET_START_BUTTON_TEXT(string TEXT) { START_BUTTON.Text = TEXT; }
        public void SET_STOP_BUTTON_TEXT(string TEXT) { STOP_BUTTON.Text = TEXT; }

        private void CPS_SELECTOR_ValueChanged(object sender, EventArgs e)
        {
            int VALUE = (int) CPS_SELECTOR.Value;
            Clicker.SET_CPS(VALUE);
        }

        private void MB_SELECTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string VALUE = MB_SELECTOR.SelectedItem.ToString();
            Clicker.SET_MOUSE_BUTTON(VALUE);
        }

        private void REPEAT_X_CheckedChanged(object sender, EventArgs e)
        {
            if (!REPEAT_X.Checked)
                return;

            int VALUE = (int) REPEAT_SELECTOR.Value;

            Clicker.SET_REPEAT(VALUE);
        }

        private void REPEAT_UNTIL_STOPPED_CheckedChanged(object sender, EventArgs e)
        {
            if (!REPEAT_UNTIL_STOPPED.Checked)
                return;

            Clicker.SET_REPEAT(0);
        }

        private void REPEAT_SELECTOR_ValueChanged(object sender, EventArgs e)
        {
            if (!REPEAT_X.Checked)
                return;

            int VALUE = (int) REPEAT_SELECTOR.Value;

            Clicker.SET_REPEAT(VALUE);
        }

        private void EDIT_TOGGLES_BUTTON_Click(object sender, EventArgs e)
        {
            ToggleButtonSelectorForm TOGGLE_BUTTON_SELECTOR_FORM = new ToggleButtonSelectorForm(this);
            TOGGLE_BUTTON_SELECTOR_FORM.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Clicker CLICKER = new Clicker(this);
            Thread AUTOCLICKER = new Thread(new ThreadStart(CLICKER.AUTOCLICK));

            AUTOCLICKER.Start();
            KEY_LISTENER.RunWorkerAsync();
        }

        private void KEY_LISTENER_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (GetAsyncKeyState(Clicker.GET_NATIVE_TOGGLE_ON_KEY()) < 0)
                {
                    Clicker.SET_TOGGLE(true);
                    SET_START_BUTTON_ENABLED(false);
                    SET_STOP_BUTTON_ENABLED(true);
                }

                if (GetAsyncKeyState(Clicker.GET_NATIVE_TOGGLE_OFF_KEY()) < 0)
                {
                    Clicker.SET_TOGGLE(false);
                    SET_START_BUTTON_ENABLED(true);
                    SET_STOP_BUTTON_ENABLED(false);
                }

                Thread.Sleep(10);
            }
        }

        private void START_BUTTON_Click(object sender, EventArgs e)
        {
            Clicker.SET_TOGGLE(true);

            START_BUTTON.Enabled = false;
            STOP_BUTTON.Enabled = true;
        }

        private void STOP_BUTTON_Click(object sender, EventArgs e)
        {
            Clicker.SET_TOGGLE(false);

            START_BUTTON.Enabled = true;
            STOP_BUTTON.Enabled = false;
        }
    }
}
