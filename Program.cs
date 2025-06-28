using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ProcessIQ;

namespace ProcessIQ
{
    class Program
    {
        static void Main()
        {
            // Create an instance of program 
            Program program = new Program();
            // Bool to keep program running 
            bool run_program = true;
            while (run_program)
            {
                Console.WriteLine("ProcessIQ v1.0 created by NullByNature");
                Console.WriteLine("Type a command, if you need help type 'help'");
                Console.Write("Input: ");
                string user_answer = Console.ReadLine();
                // Make sure user answer is not blank
                while (string.IsNullOrEmpty(user_answer))
                {
                    Console.WriteLine("Your input can not be blank");
                    Console.Write("Input: ");
                    user_answer = Console.ReadLine();
                }
                program.Commands(user_answer);
                
            }
        }
        #region Commands
        void Commands(string command)
        {
            // Switch statement for user input
            switch(command.ToLower())
            {
                case "help":
                    Console.WriteLine("Command names are the following:\n" +
                        "1. List - List all running processes with PID and name\n" +
                        "2. Find - Search for a specific process by name\n" +
                        "3. Kill - Forces a process to stop\n");
                    break;
                case "list":
                    List_Processes Lp = new List_Processes();
                    Lp.Running_Processes();
                    break;




                case "find":
                    Find_Process Fp = new Find_Process();
                    Console.WriteLine("How do you want to search?\n" +
                        "1. PID\n" +
                        "2. Name");
                    string input = Console.ReadLine();
                    // make sure name is not blank 
                    while (string.IsNullOrEmpty (input))
                    {
                        Console.WriteLine("Your input can not be blank");
                        input = Console.ReadLine();
                    }
                    if (input == "1")
                    {
                        int number = 0;
                        Console.WriteLine("Enter the PID: ");
                        string pid = Console.ReadLine();
                        while (string.IsNullOrEmpty (pid))
                        {
                            Console.WriteLine("Can not be left empty");
                            pid = Console.ReadLine();
                        }
                        try
                        {
                            number = int.Parse(pid);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Find_PID fPid = new Find_PID();
                        fPid.PID(number);
                    }
                    else
                    {
                        Console.WriteLine("Enter the name of the process");
                        string name = Console.ReadLine();
                        // check for blank input
                        while (string.IsNullOrEmpty (name))
                        {
                            Console.WriteLine("Name can not be blank");
                            name = Console.ReadLine();
                        }
                        Fp.Process_name(name);
                    }
                        break;




                case "kill":
                    Console.WriteLine("Processes will be killed by PID");
                    Console.Write("Enter PID: ");
                    string iD = Console.ReadLine();
                    // make sure id is not blank 
                    while(string.IsNullOrEmpty (iD))
                    {
                        Console.WriteLine("ID can not be blank");
                        iD = Console.ReadLine();
                    }
                    try
                    {
                        int PID = int.Parse(iD);
                        KillProgram kP = new KillProgram();
                        kP.Kill_By_PID(PID);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
        #endregion
    }
}