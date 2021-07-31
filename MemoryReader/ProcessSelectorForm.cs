using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryReader
{
    public partial class ProcessSelectorForm : Form
    {
        public ProcessSelectorForm()
        {
            InitializeComponent();
        }

        private MainForm MAIN_FORM = null;
        public ProcessSelectorForm(Form FORM)
        {
            MAIN_FORM = FORM as MainForm;
            InitializeComponent();
        }

        private void ENTER_PROCESS_NAME_TextChanged(object sender, EventArgs e)
        {
            if (ENTER_PROCESS_NAME.Text.Length != 0)
                ENTER_BUTTON.Enabled = true;
            else
                ENTER_BUTTON.Enabled = false;
        }

        private void ENTER_BUTTON_Click(object sender, EventArgs e) {
            Process PROCESS;
            try { PROCESS = Process.GetProcessesByName(ENTER_PROCESS_NAME.Text)[0]; } 
            catch 
            {
                MessageBoxButtons BUTTONS = MessageBoxButtons.OK;
                MessageBoxIcon ICON = MessageBoxIcon.Error;

                MessageBox.Show("Process not found.", "Error", BUTTONS, ICON);
                return;
            }

            ProcessManagement.SET_PROCESS(ENTER_PROCESS_NAME.Text);
            this.MAIN_FORM.ACC_CURRENT_PROCESS_LABEL = "Current Process: " + ProcessManagement.GET_PROCESS();

            Memory.Win64.MemoryHelper32 MEMORY_HELPER = new Memory.Win64.MemoryHelper32(PROCESS);
            uint TARGET_ADDRESS;
            uint BASE_ADDRESS;
            int[] OFFSETTS = { };

            BASE_ADDRESS = (uint) PROCESS.MainModule.BaseAddress.ToInt64();
            TARGET_ADDRESS = Memory.Utils.MemoryUtils.OffsetCalculator(MEMORY_HELPER, BASE_ADDRESS, OFFSETTS);

            this.MAIN_FORM.ACC_MEM_STRINGS.Items.Add(ProcessManagement.GET_PROCESS() + " -- " + TARGET_ADDRESS.ToString());

            Close();
        }
    }
}
