namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();//Burda ctrl r m yaptik asagidaki blogu secip method yapmis olduk kutuya koyduk diyebiliriz 

            Vatandas vatandas1 = new Vatandas();

            

            Console.ReadLine();
        }

      

        private static void Degiskenler()
        {
            string feedback = "Iyi Gunler Dileriz";
            bool girisYapmisMi = false;
            double tutar = 100000;


            string ad = "Emre";
            string soyad = "Capar";
            int dogumyil = 2002;
            long tcNo = 12345678901;//neden string yapmadik cunku islem yapmiyoruz zaten niye int degil long cunku hanesi fazla


            Console.WriteLine(feedback);
            Console.WriteLine(tutar * 0.18);
        }
    }
    //pascal casing (basharfleri buyuk oluyor)
    public class Vatandas
    {
        //prop yazip tabtab yazinca gelir bunlar ozellik anlamina gelir
        public string Ad { get; set; }//get {} acip kullanabilirsin fakat cok kullanilan bisey degil

        public string Soyad { get; set;}

        public int DogumYili { get; set;}
        public long TcNo { get; set;}

    }
}