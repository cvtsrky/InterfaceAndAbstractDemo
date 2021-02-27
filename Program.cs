using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1986, 5, 5),
                FirstName = "İsim Giriniz",
                LastName = "Soyisim giriniz",
                NationalityId = "TC no giriniz"
            });

            ////Nero için
            ////Doğum tarihini (Yıl,Ay,Gün) olarak giriniz. Örn: DateOfBirth = new DateTime(1986, 5, 5)
            //BaseCustomerManager customerManager1 = new NeroCustomerManager(new MernisServiceAdapter());
            //customerManager1.Save(new Customer
            //{
            //    DateOfBirth = new DateTime(, , ),  
            //    FirstName = "İsim Giriniz",
            //    LastName = "Soyisim giriniz",
            //    NationalityId = "TC no giriniz"
            //});
        }
    }
}
