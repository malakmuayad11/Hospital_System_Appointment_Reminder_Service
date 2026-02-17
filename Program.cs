using System;
using System.ServiceProcess;

namespace Hospital_System_Appointment_Reminder_Service
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                Console.WriteLine("Running in console mode.");
                AppointmentsReminderService service = new AppointmentsReminderService();
                service.StartInConsole();
            }
            else
            {
                // Service is deployed.
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new AppointmentsReminderService()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
