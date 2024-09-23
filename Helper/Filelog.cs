using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Helper
{
    public static class Filelog
    {
        //string projectPath = AppDomain.CurrentDomain.BaseDirectory;
        //string logFilePath = Path.Combine(projectPath, "logs", "app_log.txt");
        public static void LogMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "app_log.txt"), true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        public static void LogError(string errorMessage)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "app_log.txt"), true))
            {
                writer.WriteLine($"{DateTime.Now}: ERROR - {errorMessage}");
            }
        }
    }
}
