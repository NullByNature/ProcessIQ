using System;
using System.Diagnostics;

namespace ProcessIQ
{
   class KillProgram
    {
        public void Kill_By_PID(int ID)
        {
            Process process = new Process();
            Process running = Process.GetProcessById(ID);
            try
            {
                running.Kill();
                Console.WriteLine("Process has been terminated\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
