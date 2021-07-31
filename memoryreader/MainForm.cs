using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryReader
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        public string ACC_CURRENT_PROCESS_LABEL
        {
            get { return CURRENT_PROCESS_LABEL.Text; }
            set { CURRENT_PROCESS_LABEL.Text = value; }
        }

        public ListBox ACC_MEM_STRINGS
        {
            get { return MEM_STRINGS; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MEM_STRINGS.MultiColumn = true;
            MEM_STRINGS.SelectionMode = SelectionMode.One;
        }

        private void PROCESS_SELECT_BUTTON_Click(object sender, EventArgs e)
        {
            ProcessSelectorForm PROCESS_SELECTOR_FORM = new ProcessSelectorForm(this);
            PROCESS_SELECTOR_FORM.Show();
        }

        private void MEM_STRINGS_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string CURRENT_ITEM = MEM_STRINGS.SelectedItem.ToString();

            if (CURRENT_ITEM != null)
                COPY_BUTTON.Enabled = true;
            else
                COPY_BUTTON.Enabled = false;
        }

        private void COPY_BUTTON_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MEM_STRINGS.SelectedItem.ToString());
        }
    }
}
