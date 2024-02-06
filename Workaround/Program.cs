
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

           
            SelamVer("Ömer");
            SelamVer();
            int sonuc = Topla();


            // Diziler

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];

            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);   
            }

            Person person1 = new Person();
            person1.FirstName = "Ömer";
            person1.LastName = "Serfice";
            person1.DateOfBirthYear = 1993;
            person1.NationalIdentity = 122322;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            List<string> sehirler1 = new List<string> { "Ankara","İstanbul","İzmir" };
            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba "+ isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc.ToString());
            return sonuc;
        }


     
        private static void Degiskenler()
        {
            string mesaj = "Selam";

            double tutar = 100000;

            int sayi = 100;

            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
