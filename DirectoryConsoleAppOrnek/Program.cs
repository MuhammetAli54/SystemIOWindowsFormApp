using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryConsoleAppOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Bas:
            Console.WriteLine("HOŞGELDİNİZ...");
            Console.WriteLine("Lütfen oluşturmak istediğiniz dosyanın adınız giriniz:");
            string dosyam = Console.ReadLine();
            string myPath = $"C:\\{dosyam}";
            if (KlasordenVarMi(myPath))
            {
                Console.WriteLine($"{myPath} dosya yolu zaten oluşturulmuş.");
                goto Bas;
            }
            else  
            {
                KlasorOlustur(myPath);
                Console.WriteLine($"{myPath} isimli dosyanız oluturuldu...");
            }
            Baslangic:
            Console.WriteLine("Hangi işlemi yapmak istersiniz \n" +
                "Klasörü Sil ---> 1 \n" +
                "Klasörü Taşı --->2");
            try
            {
                int islem = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1:
                    Secenek:
                        Console.WriteLine("Bu dosyayı silmek istediğinize emin misiniz? E/H");
                        ConsoleKeyInfo tercih = Console.ReadKey();
                        Console.WriteLine();
                        if (tercih.Key == ConsoleKey.E)
                        {
                            KlasoruSil(myPath);
                        }
                        else if (tercih.Key == ConsoleKey.H)
                        {
                            goto Baslangic;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız !");
                            goto Secenek;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Lütfen taşımak istediğiniz dosyanın adını giriniz :");
                        string yeniHedef = Console.ReadLine();
                        KlasoruTasi(myPath, $"C:\\{yeniHedef}");
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız !");
                        goto Baslangic;
                }

            }
            catch (Exception ex )
            {
                Console.WriteLine("HATA: Sayı giriniz !! " + ex.Message);
            }
            Console.ReadKey();
        }
        private static void KlasorOlustur(string dosyaYolu)
        {
            DirectoryInfo dy = Directory.CreateDirectory(dosyaYolu);
        }

        private static void KlasoruSil(string dosyaYolu)
        {
            Directory.Delete(dosyaYolu);
            Console.WriteLine("Klasörünüz silindi...");
        }

        private static void KlasoruTasi(string kaynakYol, string HedefYol)
        {
            Directory.Move(kaynakYol, HedefYol);
            Console.WriteLine("Klasörünüz taşındı...");
        }

        private static bool KlasordenVarMi(string dosyaYolu)
        {
            bool sonuc = false;
            sonuc = Directory.Exists(dosyaYolu);
            return sonuc;
        }

    }
}
