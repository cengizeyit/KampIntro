using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.customerId = 1;
            customer1.customerNo = "12345";
            customer1.customerName = "Engin";
            customer1.customerSurname = "Demiroğ";
            customer1.TcNo = "12345678910";

            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.customerId = 2;
            customer2.customerNo = "54321";
            customer2.companyName = "Kodlama.io";
            customer2.vergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerService customerService = new CustomerService();
            customerService.Add(customer1);
            customerService.Add(customer2);
            

        }
    }
}
