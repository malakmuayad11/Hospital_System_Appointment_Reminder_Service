using Service_Business;
using System;
using System.Diagnostics;
using System.ServiceProcess;
using Infrastructure;

namespace Hospital_System_Appointment_Reminder_Service
{
    public partial class AppointmentsReminderService : ServiceBase
    {
        private clsLog _Logger;
        private clsReminder _Reminder;
        public AppointmentsReminderService()
        {
            InitializeComponent();
            _Logger = new clsLog(new clsEventLog());
            _Reminder = new clsReminder(new clsSMSReminder());
        }

        protected async override void OnStart(string[] args)
        {
            _Logger.LogMessage("Appointments Reminder Service started...", enLogType.eInfo);
            await _Reminder.SendUpcomingReminders();
        }

        protected override void OnStop() =>
            _Logger.LogMessage("Appointments Reminder Service stopped...", enLogType.eInfo);

        /// <summary>
        /// Starts the service in the debug mode. Used only for testing the service before deployment.
        /// </summary>
        [Conditional("DEBUG")]
        public void StartInConsole()
        {
            OnStart(null);
            Console.WriteLine("Please press enter to stop this service...");
            Console.ReadLine();
            OnStop();
            Console.ReadKey();
        }
    }
}