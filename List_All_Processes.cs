using System;
using System.Diagnostics;

namespace ProcessIQ
{
    class List_Processes
    {
        public void Running_Processes()
        {
            int count = 0;
            Process process = new Process();
            Process[] running = Process.GetProcesses();
            // list all running processes 
            foreach(Process p in running)
            {
                count++;
                Console.WriteLine($"{count}. {p.ProcessName} - Process ID: {p.Id}");
            }
            Console.WriteLine($"Total running processes: {count}");
            Console.Write("\n");
        }
    }
}
