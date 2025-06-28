using System;
using System.Diagnostics;

namespace ProcessIQ
{
    class Find_PID
    {
        public void PID(int pid)
        {
            Process process = new Process();
            try
            {
                Process running = Process.GetProcessById(pid);
                if (running != null)
                {
                    Console.WriteLine($"Process found! {running.ProcessName} - {running.Id}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
