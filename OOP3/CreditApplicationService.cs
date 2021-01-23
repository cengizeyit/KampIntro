using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Kredi Başvuru Servisi
    class CreditApplicationService
    {
        //başvuru servisini aynı zamanda loglamak istiyorsak 
        //sadece interfaceini veriyoruz. (ILoggerService)
        //Methot injection
        //burada dependency injection yapıyoruz.
        //bu methodun hangi kredi türü için başvuru yapacağını ve nasıl loglanacağını enjekte ediyoruz.
        //public void CreditApplication(ICreditService creditService, ILoggerService loggerService)
        //eğer loglama için birden fazla servis kullanacaksak List of ile getireceğiz
        public void CreditApplication(ICreditService creditService, List<ILoggerService> loggerServices)
        {
            //Kredi Başvuru bilgileri değerlendirme
            creditService.Calculate();

            //Seçilen Loglama servislerine loglama
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //Kredi Ön Bilgilendirmesi yap
        //Müşterinin istediği kredi bilgilendirmesi için Müşteri Temsilcisi 
        //Kredi Listesinden bir veya birden fazla kredi türünü seçerek hesaplar ve bilgilendirme yapar.
        public void MakeCreditPrenotification(List<ICreditService> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
