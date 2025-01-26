using System;
using System.ServiceProcess;


namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                // Servis başlatıldığında yapılacak işlemler
                LogHelper.LogToFile("Uygulama başlatıldı.");
            }
            catch (Exception ex)
            {
                // Hata durumunda log yazma
                LogHelper.LogToFile("Servis başlatma hatası: " + ex.Message);
            }
        }

        protected override void OnStop()
        {
            // Servis durduğunda yapılacak işlemler
            LogHelper.LogToFile("Servis durduruldu");
        }
    }
}
