using System;

namespace gunluk_gorevler
{
    class Program
    {
        static void Main(string[] args)
        {
            gunlukGorevler gunluk = new gunlukGorevler();
            gunluk.temizlik_suresi = 2;
            gunluk.calisma_suresi = 3;
            gunluk.yemek_yapma = 1;
            gunluk.uyuma = 8;

            gunlukGorevler[] isler = new gunlukGorevler[] { gunluk };

            foreach (gunlukGorevler i in isler)
            {
                Console.WriteLine(i.temizlik_suresi + i.calisma_suresi + i.yemek_yapma + i.uyuma);
            }

        }

        class gunlukGorevler
        {
            public int temizlik_suresi { get; set; }
            public int calisma_suresi { get; set; }
            public int yemek_yapma { get; set; }
            public int uyuma { get; set; }
        }
    }
}
/* Bir gün içerisinde yapılması gereken görevlerin olduğu bir class 
 * oluşturun. Classtaki işlerin yapılma süresi ile işlem yapılacaktır. 
 Kullanıcıdan bu iş için kaç saat harcayacağını girmesini isteyin ve
output olarak kullanıcının toplam kaç saat harcadığını bulun.*/
