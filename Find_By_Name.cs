using System;
using System.Diagnostics;

namespace ProcessIQ
{
    class Find_Process
    {
        public void Process_name(string name)
        {
            int count = 0;
            Process process = new Process();
            // Make sure name is not empty
           try
            {
                Process[] running = Process.GetProcessesByName(name.ToLower());
                // Get each process by that name 
                foreach (Process p in running)
                {
                    count++;
                }
                Console.WriteLine($"I've found {count} processes by that name");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
