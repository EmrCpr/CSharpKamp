using Business.Concrete;
using Entities.Concrete;


namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {


            SelamVer();
            SelamVer();
            //

            int sonuc = Topla(3, 5);
            //int sonuc = Topla(50);  // bunda mesela b nin defaultu olmazsa yalnis olur 


            //Diziler
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Emre";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Veli";

            ogrenciler = new string[4];//new yazinca referans adresi degisti 101 ken 102 oldu o yuzden sadece Ilkeri yazcak
            ogrenciler[3] = "Ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            //

            string[] sehirler1 = new string[] { "Konya", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };//new[]ile new string[] ayni
            sehirler1 = sehirler2;//referans esitliyorsun
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //
            Person person1 = new Person();
            person1.FirstName = "EMRE";
            person1.LastName = "ÇAPAR";
            person1.dateOfBirthYear = 2002;
            person1.NationalIdentity = 42682289540;

            Person person2 = new Person();
            person2.FirstName = "Veli";
            //

            foreach (string sehir in sehirler1)//sehirler1'in icinde dolasip hespini yazcaz diziler icin iyi 
            {
                Console.WriteLine(sehir);
            }

            //Dizi kavraminin yerine gecmeye baslayan list(GENERIC COLLECTION)
            //Odev mylist yazcam eklemeyi addsiz yapcaz 

            List<string> yeniSehirler = new List<string> { "Ankara1", "Istanbul1", "Izmir1" };
            yeniSehirler.Add("Hatay");
            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }
            //

            PttManager pttManager = new PttManager(new PersonManager());
            //PttManager pttManager = new PttManager(new ForeignManager());    yabanci icin
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }


        static void SelamVer(string isim = "isimsiz")//default isimsiz atar
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int a = 5, int b = 10)//default sirayla yapar ama 
        {
            int sonuc = a + b;
            Console.WriteLine("Toplam :" + sonuc);
            return sonuc;
        }

    }


}