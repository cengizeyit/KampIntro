using System;
using System.Collections.Generic;
using System.IO;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İhtiyaç Kredisi
            ICreditService consumerLoanService = new ConsumerLoanService();
            //consumerLoanService.Calculate();

            //Araç Kredisi
            ICreditService transportCreditService = new TransportCreditService();
            //transportCreditService.Calculate();

            //Konut Kredisi
            ICreditService mortgageLoanService = new MortgageLoanService();
            //mortgageLoanService.Calculate();

            //Esnaf Kredisi
            ICreditService artisanLoanService = new ArtisanLoanService();
            //artisanLoanService.Calculate();



            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsloggerService = new SmsLoggerService();



            List<ILoggerService> loggerServices = new List<ILoggerService> { smsloggerService, databaseLoggerService };

            //Kredi Başvuru ekranı
            CreditApplicationService creditApplicationService = new CreditApplicationService();
            creditApplicationService.CreditApplication(artisanLoanService, loggerServices);

            //Kredi Başvuru ekranından kredi türünü seçerek ön bilgilendirmeyi yapıyor
            List<ICreditService> credits = new List<ICreditService>() { consumerLoanService, transportCreditService };
            //creditApplicationService.MakeCreditPrenotification(credits);



        }
    }
}
