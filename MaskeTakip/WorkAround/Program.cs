namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {


            SelamVer();
            SelamVer();

            int sonuc = Topla(3, 5);
            //int sonuc = Topla(50);  // bunda mesela b nin defaultu olmazsa yalnis olur 

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