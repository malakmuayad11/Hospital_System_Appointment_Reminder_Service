# Hospital System Appointment Reminder Service
A Windows service that sends SMS reminders for upcoming appointments. This service is built for the [Hospital Management System](https://github.com/malakmuayad11/Hospital-Management-System).

## ✅ Features
- 📧 Send reminders for appointments that are scheduled within the next hour from the current time.
- 💾 Log errors in the event viewer.
- 📊 Store and retrieve data from SQL Server.
- 💬 Send appointment reminder SMS messages using the smsmode API. Note: During development, the integration successfully submits messages and receives tracking IDs, while actual delivery may vary in sandbox environments.

## 📲 Build Instructions (Release Mode):
1. Save the source code.
2. Build the solution (ctrl + shift + b) in release mode.

## 📲 Deployment Instructions:
### ⬇️ Installation (Using InstallUtil):
1. Open the solution's folder in File Explorer.
2. Open bin -> release -> copy file path **(service's file path)**.
3. Open the command prompt in **administrator mode**.
4. Change the current directory to the **service's file path**.
5. Use the following command:
   - for 64-bit systems: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe 
Hospital_System_Appointment_Reminder_Service.exe
   - for 32-bit systems: C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe 
Hospital_System_Appointment_Reminder_Service.exe
### 🎇 Start Service:
1. Open the command prompt in administrator mode.
2. Use this command: sc start DatabaseBackupService
### 🛑 Stop Service:
1. Open the command prompt in administrator mode.
2. Use this command: sc stop DatabaseBackupService

## ⛔ Uninstallation (Using InstallUtil):
1. Open the command prompt in administrator mode.
2. Use the following command:
   - for 64-bit systems: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe -u DatabaseBackupService.exe
   - for 32-bit systems: C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe -u DatabaseBackupService.exe
  
## ⚙️ Technologies:
- C# (.NET Framework / .NET)
- SQL Server
- Windows Service
- ADO.NET
- Three-tier architecture
- smsmode API.

## 👩‍💻 Author
**Malak Muayad**  
📧 [malakmuayad15@gmail.com](mailto:malakmuayad15@gmail.com)  
🔗 [malakmuayad11](https://github.com/malakmuayad11)
