using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Telefon_Rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            RehberBusiness rehberBusiness = new RehberBusiness();
            
            

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("..................................");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)     
            {
                case 1:
                    {
                        rehberBusiness.Add();

                    }
                    break;
                case 2:
                    {
                        rehberBusiness.Remove();
                        
                    }
                    break;

                case 3:
                    {
                        rehberBusiness.Update();
                    }
                    break;

                case 4:
                    {
                        rehberBusiness.List();
                    }
                    break;

                case 5:
                    {
                        rehberBusiness.Search();

                    }
                    break;
                        
                default:
                    break;
            }


        }
    }

   
}
