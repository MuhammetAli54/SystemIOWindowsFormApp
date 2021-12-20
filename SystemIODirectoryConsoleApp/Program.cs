using System;
using System.IO;

namespace SystemIODirectoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = "C:\\NetworkAkademi103";
            //if ile kontrol edelim
            if (KlasordenVarMi(myPath))
            {
                Console.WriteLine($"{myPath} dosya yolu zaten oluşturulmuş.");
            }
            else   //false dönmüş demektir
            {
                YeniKlasorOlustur(myPath);
            }
            Console.WriteLine();

            //KlasoruSil(myPath);
            //Console.WriteLine($"{myPath} directory silindi...");

            //klasör taşıma işlemi

            KlasoruTasi(myPath,"C:\\ALİ");

            Console.ReadKey();
        }
        private static void YeniKlasorOlustur(string dosyaYolu)
        {
            DirectoryInfo di = Directory.CreateDirectory(dosyaYolu);
        }

        private static bool KlasordenVarMi(string dosyaYolu)
        {
            bool sonuc = false;
            sonuc = Directory.Exists(dosyaYolu);
            return sonuc;
        }

        private static void KlasoruSil(string dosyaYolu)
        {
            Directory.Delete(dosyaYolu);
        }

        private static void KlasoruTasi(string kaynakYol, string HedefYol)
        {
            Directory.Move(kaynakYol, HedefYol);
            Console.WriteLine($"kaynak: {kaynakYol}, {HedefYol} hedefine taşındı...");
        }
    }

}
