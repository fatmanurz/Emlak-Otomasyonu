using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{

    public static class LogHelper
    {
        // Log dosyasının yolu
        private static string logFilePath = @"C:\Projects\LogService\serviceLog.txt";

        public static void LogToFile(string message)
        {
            try
            {
                // Dosyanın varlığını kontrol et, yoksa oluştur
                if (!File.Exists(logFilePath))
                {
                    File.Create(logFilePath).Dispose();
                }

                // Log mesajına tarih eklemek
                string logMessage = $"{DateTime.Now}: {message}";

                // Dosyaya log yazma
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Hata durumunda log yazma
                string errorMessage = $"{DateTime.Now}: Log yazma hatası - {ex.Message}";
                File.AppendAllText(logFilePath, errorMessage + Environment.NewLine);
            }
        }
    }
}


