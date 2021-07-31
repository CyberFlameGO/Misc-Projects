using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker3
{
    public partial class ToggleButtonSelectorForm : Form
    {
        public ToggleButtonSelectorForm()
        {
            InitializeComponent();
        }

        private MainForm MAIN_FORM = null;
        public ToggleButtonSelectorForm(Form FORM)
        {
            MAIN_FORM = FORM as MainForm;
            InitializeComponent();
        }

        private void TOGGLE_ON_KEY_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (TOGGLE_ON_KEY_TEXTBOX.Text.Length != 1 || TOGGLE_ON_KEY_TEXTBOX.Text.ToString().ToUpper() == Clicker.GET_TOGGLE_OFF_KEY())
            {
                TOGGLE_ON_KEY_BUTTON.Enabled = false;
                return;
            }

            TOGGLE_ON_KEY_BUTTON.Enabled = true;
        }

        private void TOGGLE_OFF_KEY_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (TOGGLE_OFF_KEY_TEXTBOX.Text.Length != 1 || TOGGLE_OFF_KEY_TEXTBOX.Text.ToString().ToUpper() == Clicker.GET_TOGGLE_ON_KEY())
            {
                TOGGLE_OFF_KEY_BUTTON.Enabled = false;
                return;
            }

            TOGGLE_OFF_KEY_BUTTON.Enabled = true;
        }

        private void TOGGLE_ON_KEY_BUTTON_Click(object sender, EventArgs e)
        {
            Clicker CLICKER = new Clicker(this.MAIN_FORM);
            CLICKER.SET_TOGGLE_ON_KEY(TOGGLE_ON_KEY_TEXTBOX.Text.ToUpper());
            this.MAIN_FORM.SET_TOGGLE_ON_LABEL("Toggle On: " + Clicker.GET_TOGGLE_ON_KEY());
        }

        private void TOGGLE_OFF_KEY_BUTTON_Click(object sender, EventArgs e)
        {
            Clicker CLICKER = new Clicker(this.MAIN_FORM);
            CLICKER.SET_TOGGLE_OFF_KEY(TOGGLE_OFF_KEY_TEXTBOX.Text.ToUpper());
            this.MAIN_FORM.SET_TOGGLE_OFF_LABEL("Toggle Off: " + Clicker.GET_TOGGLE_OFF_KEY());
        }
    }
}
