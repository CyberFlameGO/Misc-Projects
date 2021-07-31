using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoClicker3
{
    public class Clicker
    {
        private MainForm MAIN_FORM = null;
        public Clicker(Form FORM)
        {
            MAIN_FORM = FORM as MainForm;
        }

        private static int CPS = 1;
        private static string MOUSE_BUTTON = "Left";
        private static int REPEAT = 0;
        private static string TOGGLE_ON = "Q";
        private static string TOGGLE_OFF = "Z";
        private static bool TOGGLED = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int DW_FLAGS, int DX, int DY, int C_BUTTONS, int DW_EXTRA_INFO);
        private const int LEFTUP = 0x00000004;
        private const int LEFTDOWN = 0x00000002;
        private const int RIGHTUP = 0x00000010;
        private const int RIGHTDOWN = 0x00000008;

        public static int GET_CPS() { return CPS; }
        public static string GET_MOUSE_BUTTON() { return MOUSE_BUTTON; }


        public static void SET_CPS(int CPS) { Clicker.CPS = CPS; }
        public static void SET_MOUSE_BUTTON(string MOUSE_BUTTON) { Clicker.MOUSE_BUTTON = MOUSE_BUTTON; }

        public static int GET_REPEAT() { return REPEAT; }
        public static void SET_REPEAT(int REPEAT) { Clicker.REPEAT = REPEAT; }

        public static string GET_TOGGLE_ON_KEY() { return TOGGLE_ON; }
        public static string GET_TOGGLE_OFF_KEY() { return TOGGLE_OFF; }
        public void SET_TOGGLE_ON_KEY(string KEY) 
        { 
            TOGGLE_ON = KEY;
            this.MAIN_FORM.SET_START_BUTTON_TEXT("Start (" + KEY + ")");
        }
        public void SET_TOGGLE_OFF_KEY(string KEY)
        { 
            TOGGLE_OFF = KEY;
            this.MAIN_FORM.SET_STOP_BUTTON_TEXT("Stop (" + KEY + ")");
        }

        public static Keys GET_NATIVE_TOGGLE_ON_KEY() { return (Keys) Enum.Parse(typeof(Keys), GET_TOGGLE_ON_KEY());}
        public static Keys GET_NATIVE_TOGGLE_OFF_KEY() { return (Keys) Enum.Parse(typeof(Keys), GET_TOGGLE_OFF_KEY()); }

        public static bool IS_TOGGLED() { return TOGGLED; }
        public static void SET_TOGGLE(bool TOGGLE) { TOGGLED = TOGGLE; }


        public static void CLICK()
        {
            if (GET_MOUSE_BUTTON() == "Left")
            {
                mouse_event(DW_FLAGS: LEFTDOWN, DX: 0, DY: 0, C_BUTTONS: 0, DW_EXTRA_INFO: 0);
                mouse_event(DW_FLAGS: LEFTUP, DX: 0, DY: 0, C_BUTTONS: 0, DW_EXTRA_INFO: 0);
            }
            else if (GET_MOUSE_BUTTON() == "Right")
            {
                mouse_event(DW_FLAGS: RIGHTDOWN, DX: 0, DY: 0, C_BUTTONS: 0, DW_EXTRA_INFO: 0);
                mouse_event(DW_FLAGS: RIGHTUP, DX: 0, DY: 0, C_BUTTONS: 0, DW_EXTRA_INFO: 0);
            }
        }

        public void AUTOCLICK()
        {
            while (true)
            {
                if (IS_TOGGLED())
                {
                    if (GET_REPEAT() == 0)
                    {
                        CLICK();
                        Thread.Sleep(1000 / CPS);
                    }
                    else
                    {
                        for (int i = 0; i < GET_REPEAT(); i++)
                        {
                            CLICK();
                            Thread.Sleep(1000 / CPS);
                        }


                        SET_TOGGLE(false);
                        this.MAIN_FORM.SET_START_BUTTON_ENABLED(true);
                        this.MAIN_FORM.SET_STOP_BUTTON_ENABLED(false);
                    }
                }

            }

        }

    }
}
