using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailAddress mail = new MailAddress();
                Console.WriteLine("Название вашей организации:");
                mail.OrganisationName = Console.ReadLine();
                Console.WriteLine("Почтовый индекс вашей организации: ");
                mail.Index = int.Parse(Console.ReadLine());
                Console.WriteLine("В каком стране находитсяваша организация:");
                mail.CountryName = Console.ReadLine();
                Console.WriteLine("В каком городе она находится?");
                mail.CityName = Console.ReadLine();
                Console.WriteLine("Укажите на какой улице находится ваша организация:");
                mail.StreetName = Console.ReadLine();
                Console.WriteLine("Укажите номер дома:");
                mail.HouseNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваша организация: \n");
                Console.WriteLine("Название: " + mail.OrganisationName);
                Console.WriteLine("Почтовый индекс: " + mail.Index);
                Console.WriteLine("Страна: " + mail.CountryName);
                Console.WriteLine("Город: " + mail.CityName);
                Console.WriteLine("Улица, дом: " + mail.StreetName + ", " + mail.HouseNumber);
            }
            catch (Exception)
        
            {
                Console.WriteLine("Неверно задано значение!");
            }

            Console.ReadKey();
        }
    }
}
