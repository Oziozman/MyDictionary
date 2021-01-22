using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(01, "Adana");
            cities.Add(02, "Adıyaman");
            cities.Add(03, "Afyon");
            cities.Add(04, "Ağrı");
            cities.Add(05, "Amasya");
            cities.Add(06, "Ankara");
            cities.Add(07, "Antalya");
            cities.Add(08, "Artvin");
            cities.Add(09, "Aydın");
            cities.Add(10, "Balıkesir");
            cities.Add(11, "Bilecik");
            cities.Add(12, "Bingöl");
            cities.Add(13, "Bitlis");
            cities.Add(14, "Bolu");
            cities.Add(15, "Burdur");
            cities.Add(16, "Bursa");
            cities.Add(17, "Çanakkale");
            cities.Add(18, "Çankırı");
            cities.Add(19, "Çorum");
            cities.Add(20, "Denizli");
            cities.Add(21, "Diyarbakır");
            cities.Add(22, "Edirne");
            cities.Add(23, "Elazığ");
            cities.Add(24, "Erzincan");
            cities.Add(25, "Erzurum");
            cities.Add(26, "Eskişehir");
            cities.Add(27, "Gaziantep");
            cities.Add(28, "Giresun");
            cities.Add(29, "Gümüşhane");
            cities.Add(30, "Hakkari");
            cities.Add(31, "Hatay");
            cities.Add(32, "Isparta");
            cities.Add(33, "Mersin");
            cities.Add(34, "Istanbul");
            cities.Add(35, "Izmir");
            cities.Add(36, "Kars");
            cities.Add(37, "Kastamonu");
            cities.Add(38, "Kayseri");
            cities.Add(39, "Kırklareli");
            cities.Add(40, "Kırşehir");
            cities.Add(41, "Kocaeli");
            cities.Add(42, "Konya");
            cities.Add(43, "Kütahya");
            cities.Add(44, "Malatya");
            cities.Add(45, "Manisa");
            cities.Add(46, "K.Maraş");
            cities.Add(47, "Mardin");
            cities.Add(48, "Muğla");
            cities.Add(49, "Muş");
            cities.Add(50, "Nevşehir");
            cities.Add(51, "Niğde");
            cities.Add(52, "Ordu");
            cities.Add(53, "Rize");
            cities.Add(54, "Sakarya");
            cities.Add(55, "Samsun");
            cities.Add(56, "Siirt");
            cities.Add(57, "Sinop");
            cities.Add(58, "Sivas");
            cities.Add(59, "Tekirdağ");
            cities.Add(60, "Tokat");
            cities.Add(61, "Trabzon");
            cities.Add(62, "Tunceli");
            cities.Add(63, "Şanlıurfa");
            cities.Add(64, "Uşak");
            cities.Add(65, "Van");
            cities.Add(66, "Yozgat");
            cities.Add(67, "Zonguldak");
            cities.Add(68, "Aksaray");
            cities.Add(69, "Bayburt");
            cities.Add(70, "Karaman");
            cities.Add(71, "Kırıkkale");
            cities.Add(72, "Batman");
            cities.Add(73, "Şırnak");
            cities.Add(74, "Bartın");
            cities.Add(75, "Ardahan");
            cities.Add(76, "Iğdır");
            cities.Add(77, "Yalova");
            cities.Add(78, "Karabük");
            cities.Add(79, "Kilis");
            cities.Add(80, "Osmaniye");
            cities.Add(81, "Düzce");

            foreach (var plaka in cities.Keys)
            {
                Console.WriteLine(plaka);
            }

            foreach (var sehir in cities.Values)
            {
                Console.WriteLine(sehir);
            }

          

        }
    }
}