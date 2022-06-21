using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telefon_Rehberi
{
    public class RehberBusiness
    {
        
        List<Rehber> rehber = new List<Rehber>
            {
                new Rehber{Name="Ali Kundilli",Number="555"},
                new Rehber{Name="Veli Öz",Number="444"},
                new Rehber{Name="Bora Kapan",Number="333"},
                new Rehber{Name="Metin Pınar",Number="888"},
                new Rehber{Name="Zeki Müze",Number="111"},


            };

        public string name;
        public string number;


        public void Add()
        {
            
            Console.WriteLine("İsim girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Numara girin: ");
            number = Console.ReadLine();
            rehber.Add(new Rehber { Name = name, Number = number });
            Console.WriteLine("....................................");
            foreach (var item in rehber)
            {
                Console.WriteLine(item.Name + " " + item.Number);
            }
        }

        public void Remove()
        {
            
            Console.WriteLine("İsim girin: ");
            name = Console.ReadLine();
            var result = rehber.FirstOrDefault(c => c.Name == name);
            if (result == null)
            {
                Console.WriteLine("Aradığınız isim bulunamadı");
            }
            else
            {
                rehber.Remove(result);
            }
            Console.WriteLine("..................................");
            foreach (var item in rehber)
            {
                Console.WriteLine(item.Name + " " + item.Number);
            }

        }

        public void Update()
        {
            
            Console.WriteLine("Tel nosunu güncellemek istediğiniz bir isim girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Yeni tel nosunu girin: ");
            number = Console.ReadLine();
            var result = rehber.FirstOrDefault(c => c.Name == name);
            result.Number = number;

            Console.WriteLine("..................................");
            foreach (var item in rehber)
            {
                Console.WriteLine(item.Name + " " + item.Number);
            }
        }

        public void List()
        {
            Console.WriteLine("Rehberde toplam: " + " " + rehber.Count + " " + "Kisi vardır");
            foreach (var item in rehber)
            {
                Console.WriteLine(item.Name + " " + item.Number);
            }
        }

        public void Search()
        {
            Console.WriteLine("Aramak istediğiniz kişinin ismini girin: ");
            name = Console.ReadLine();
            var result = rehber.FirstOrDefault(c => c.Name == name);
            if (result==null)
            {
                Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil");
            }
            else
            {
                Console.WriteLine("İsim: " + result.Name + " " + "\nTel: " + result.Number);
            }
            
        }
    }
}
