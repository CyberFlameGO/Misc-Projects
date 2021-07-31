using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryReader
{
    public class ProcessManagement
    {
        private static string PROCESS_NAME = "";

        public static string GET_PROCESS() { return PROCESS_NAME; }
        public static void SET_PROCESS(string PROCESS) { PROCESS_NAME = PROCESS; }

        public static void LOAD_MEMORY_STRINGS()
        {

        }
    }
}
