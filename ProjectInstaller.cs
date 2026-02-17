using System.ComponentModel;
using System.ServiceProcess;

namespace Hospital_System_Appointment_Reminder_Service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        private ServiceProcessInstaller serviceProcessInstaller;
        private ServiceInstaller serviceInstaller;

        public ProjectInstaller()
        {
            InitializeComponent();
            serviceProcessInstaller = new ServiceProcessInstaller
            {
                Account = ServiceAccount.NetworkService
            };

            serviceInstaller = new ServiceInstaller
            {
                ServiceName = "AppointmentsReminderService",
                DisplayName = "Appointments Reminder Service",
                StartType = ServiceStartMode.Automatic,
                Description = "This Windows service sends SMS messags to upcoming appointments. It is built for the hospital management system.",
                ServicesDependedOn = new string[] { "RpcSs", "EventLog", "nsi", "Tcpip", "Dnscache", "HTTP", "MSSQLSERVER" }
            };

            Installers.Add(serviceProcessInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}