using System;

namespace ornek1
{
    class Program
    {
        //Mainde rastgele oluşturulan bir dizinin elemanlarının Hesapla isimli fonksiyon kullanılarak kare ve karekökleri hesaplanacaktır.
        //elemanları 1-100 arasında oluşturulan rastgele bir dizi Mainde oluşturulacak ve hangi işlem istendiği sorulacaktır.
        //İşlem tercihi ve rastgele dizi Hesapla metoduna gönderilecek. İşlemden sonra yeni dizi Maine döndürülecek.Mainde kacıncı dizi elemanı görülmek isteniyor? diye sorulacak
        //hem orijinal hem de işlem görmüş sonuç ekranda gösterilecek.
        static double []hesapla(string islem,double[]dizi)
        {
            double[] yenisonuc = new double[dizi.Length];
            if(islem=="1")
            {
                for (int i = 0; i < yenisonuc.Length; i++)
                {
                    yenisonuc[i] = Math.Pow(dizi[i], 2);
                }
            }
            else
            {
                for (int i = 0; i < yenisonuc.Length; i++)
                {
                    yenisonuc[i] = Math.Sqrt(dizi[i]);
                }
            }
            return yenisonuc;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] dizi = new double[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("İşlem tercihinizi seçiniz\nKare için 1'e basın,*nKarekök için 2'ye basın.");
            string secim = Console.ReadLine();
            double[] sonuc = new double[5];
            sonuc = hesapla(secim, dizi);
            Console.WriteLine("Kaçıncı dizi elemanını görüntülemek istiyorsunuz.");
            int tercih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eleman = {0}, işlem sonucu = {1}",dizi[tercih],sonuc[tercih]);
        }
    }
}
