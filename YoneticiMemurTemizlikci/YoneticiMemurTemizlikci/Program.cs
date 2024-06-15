using System;
using System.Collections.Generic;

class Program
{
    public static string pathYoneticiler = ".\\Yoneticiler.txt";
    public static string pathMemurlar = ".\\Memurlar.txt";
    public static string pathTemizlikciler = ".\\Temizlikciler.txt";
    static void Main()
    {
        Manager manager = new Manager();
        while (true)
        {
            Console.WriteLine("0 ---> Çıkış\n1 ---> Listeleme\n2 ---> Yönetici Ekleme\n3 ---> Yönetici Silme\n4 ---> Memur Ekleme\n5 ---> Memur Silme\n6 ---> Temizlikci Ekleme\n7 ---> Temizlikci Silme\n8 ---> Yönetici Bilgi Güncelleme\n9 ---> Memur Bilgi Güncelleme\n10 ---> Temizlikçi Bilgi Güncelleme\n11 ---> Yöneticileri Dosyaya Kaydetme\n12 ---> Yöneticileri Dosyadan Alma\n13 ---> Memurları Dosyaya Kaydetme\n14 ---> Memurları Dosyadan Alma\n15 ---> Temizlikçileri Dosyaya Kaydetme\n16 ---> Temizlikçileri Dosyadan Alma");
            try
            {
                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                int islem = int.Parse(Console.ReadLine());
                Console.Clear();
                if (islem == 0)
                {
                    Console.Write("Uygulama kapatıldı!");
                    Console.ReadKey();
                    break;
                }
                else if (islem == 1)
                {
                    Console.Write("1 ---> Yöneticiler\n2 ---> Memurlar\n3 ---> Temizlikciler\nSeçiminiz: ");
                    manager.Listeleme(int.Parse(Console.ReadLine()));
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Yönetici Ekleme\n--------------------------------");
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("TC Kimlik No: "); string tc = Console.ReadLine();
                    Console.Write("Ad Soyad: "); string adSoyad = Console.ReadLine();
                    Console.Write("Telefon No: "); string tlf = Console.ReadLine();
                    Console.Write("Email: "); string email = Console.ReadLine();
                    Console.Write("Adres: "); string adres = Console.ReadLine();
                    Console.Write("Yaş: "); int yas = int.Parse(Console.ReadLine());
                    Console.Write("Erkek Mi: "); bool erkekMi = bool.Parse(Console.ReadLine());
                    Console.Write("Maaş: "); int maas = int.Parse(Console.ReadLine());
                    Console.Write("Görev: "); string gorev = Console.ReadLine();
                    Console.WriteLine(manager.YoneticiEkleme(new Yonetici(id, tc, adSoyad, tlf, email, adres, yas, erkekMi, maas, gorev, new List<Gunler>())));
                }
                else if (islem == 3)
                {
                    Console.WriteLine("Yönetici Silme\n--------------------------------");
                    Console.Write("Silinecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.YoneticiSilme(id));
                }
                else if (islem == 4)
                {
                    Console.WriteLine("Memur Ekleme\n--------------------------------");
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("TC Kimlik No: "); string tc = Console.ReadLine();
                    Console.Write("Ad Soyad: "); string adSoyad = Console.ReadLine();
                    Console.Write("Telefon No: "); string tlf = Console.ReadLine();
                    Console.Write("Email: "); string email = Console.ReadLine();
                    Console.Write("Adres: "); string adres = Console.ReadLine();
                    Console.Write("Yaş: "); int yas = int.Parse(Console.ReadLine());
                    Console.Write("Erkek Mi: "); bool erkekMi = bool.Parse(Console.ReadLine());
                    Console.Write("Maaş: "); int maas = int.Parse(Console.ReadLine());
                    Console.Write("Görev: "); string gorev = Console.ReadLine();
                    Console.WriteLine(manager.MemurEkleme(new Memur(id, tc, adSoyad, tlf, email, adres, yas, erkekMi, maas, gorev, new List<Gunler>())));
                }
                else if (islem == 5)
                {
                    Console.WriteLine("Memur Silme\n--------------------------------");
                    Console.Write("Silinecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.MemurSilme(id));
                }
                else if (islem == 6)
                {
                    Console.WriteLine("Temizlikçi Ekleme\n--------------------------------");
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("TC Kimlik No: "); string tc = Console.ReadLine();
                    Console.Write("Ad Soyad: "); string adSoyad = Console.ReadLine();
                    Console.Write("Telefon No: "); string tlf = Console.ReadLine();
                    Console.Write("Email: "); string email = Console.ReadLine();
                    Console.Write("Adres: "); string adres = Console.ReadLine();
                    Console.Write("Yaş: "); int yas = int.Parse(Console.ReadLine());
                    Console.Write("Erkek Mi: "); bool erkekMi = bool.Parse(Console.ReadLine());
                    Console.Write("Maaş: "); int maas = int.Parse(Console.ReadLine());
                    Console.Write("Görev: "); string gorev = Console.ReadLine();
                    Console.WriteLine(manager.TemizlikciEkleme(new Temizlikci(id, tc, adSoyad, tlf, email, adres, yas, erkekMi, maas, gorev, new List<Gunler>())));
                }
                else if (islem == 7)
                {
                    Console.WriteLine("Temizlikçi Silme\n--------------------------------");
                    Console.Write("Silinecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.TemizlikciSilme(id));
                }
                else if (islem == 8)
                {
                    Console.WriteLine("Yönetici Bilgi Güncelleme\n--------------------------------");
                    Console.Write("Güncellenecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.YoneticiBilgiGuncelleme(id));
                }
                else if (islem == 9)
                {
                    Console.WriteLine("Memur Bilgi Güncelleme\n--------------------------------");
                    Console.Write("Güncellenecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.MemurBilgiGuncelleme(id));
                }
                else if (islem == 10)
                {
                    Console.WriteLine("Temzilikçi Bilgi Güncelleme\n--------------------------------");
                    Console.Write("Güncellenecek ID: "); int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(manager.TemizlikciBilgiGuncelleme(id));
                }
                else if (islem == 11)
                {
                    Console.WriteLine("Yöneticileri Dosyaya Kaydetme\n--------------------------------");
                    Console.WriteLine(manager.YoneticileriDosyayaKaydet(pathYoneticiler));
                }
                else if (islem == 12)
                {
                    Console.WriteLine("Yöneticileri Dosyadan Alma\n--------------------------------");
                    Console.WriteLine(manager.YoneticileriDosyadanAl(pathYoneticiler));
                }
                else if (islem == 13)
                {
                    Console.WriteLine("Memurları Dosyaya Kaydetme\n--------------------------------");
                    Console.WriteLine(manager.MemurlariDosyayaKaydet(pathMemurlar));
                }
                else if (islem == 14)
                {
                    Console.WriteLine("Memurları Dosyadan Alma\n--------------------------------");
                    Console.WriteLine(manager.MemurlariDosyadanAl(pathMemurlar));
                }
                else if (islem == 15)
                {
                    Console.WriteLine("Temizlikçileri Dosyaya Kaydetme\n--------------------------------");
                    Console.WriteLine(manager.TemizlikcileriDosyayaKaydet(pathTemizlikciler));
                }
                else if (islem == 16)
                {
                    Console.WriteLine("Temizlikçileri Dosyadan Alma\n--------------------------------");
                    Console.WriteLine(manager.TemizlikcileriDosyadanAl(pathTemizlikciler));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Devam etmek için herhangi bir tuşa basınız!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}