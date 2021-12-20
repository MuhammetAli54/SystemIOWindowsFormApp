using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool theFileisExists = false;
            theFileisExists = File.Exists(@"C:\NetworkAkademi\Selam.txt");
            if (!theFileisExists)
            {
                FileCreate(@"C:\NetworkAkademi\Selam.txt");
            }
            else
            {
                Console.WriteLine("Selam.txt dosyası sistemde bulunuyor...");
            }

            Console.WriteLine("Dosya içine yazılacak metni giriniz:");
            Console.WriteLine();
            string metin = Console.ReadLine();
            FileAppendTheText(@"C:\NetworkAkademi\Selam.txt", metin);
            //FileCreate(@"C:\NetworkAkademi\Selam.txt");

            Console.WriteLine("Dosyanızı kopyalıyoruz...");
            FileCopy(@"C:\NetworkAkademi\Selam.txt", @"C:\NetworkAkademi\Selam-Copy.txt");
            Console.WriteLine();

            Console.WriteLine("Dosyanızı Taşıyoruz...");
            FileMove(@"C:\NetworkAkademi\Selam.txt", @"C:\NetworkAkademi2\Selam.txt");


            Console.WriteLine("Selam.txt metin belgesini silmek ister misiniz? E/H");
            ConsoleKeyInfo cevap = Console.ReadKey();
            if (cevap.Key==ConsoleKey.E)
            {
                Console.WriteLine();
                FileDelete(@"C:\NetworkAkademi\Selam.txt");
            }
            else if (cevap.Key == ConsoleKey.H)
            {
                Console.WriteLine();
                Console.WriteLine("Silmedik...");
            }
            else
            {
                Console.WriteLine("Geçerli bir cevap vermediniz...");
            }
            

            Console.ReadKey();
        }

        private static void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }

        private static void FileAppendTheText(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        private static void FileDelete(string path)
        {
            File.Delete(path);
        }

        private static void FileCopy(string sourceFile, string destFile)
        {
            File.Copy(sourceFile, destFile);
        }

        private static void FileMove(string sourceFile, string destFile)
        {
            File.Move(sourceFile, destFile);
        }
    }
}
