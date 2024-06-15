using System;
using System.Collections.Generic;
using System.IO;

public enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

class Manager
{
    #region Members
    private List<Yonetici> yoneticiler = new List<Yonetici>();
    private List<Memur> memurlar = new List<Memur>();
    private List<Temizlikci> temizlikciler = new List<Temizlikci>();
    #endregion

    #region Constructor Method
    public Manager()
    {
        if (!File.Exists(Program.pathYoneticiler))
            File.Create(Program.pathYoneticiler).Close();
        else
            YoneticileriDosyadanAl(Program.pathYoneticiler);
        if (!File.Exists(Program.pathMemurlar))
            File.Create(Program.pathMemurlar).Close();
        else
            MemurlariDosyadanAl(Program.pathMemurlar);
        if (!File.Exists(Program.pathTemizlikciler))
            File.Create(Program.pathTemizlikciler).Close();
        else
            TemizlikcileriDosyadanAl(Program.pathTemizlikciler);
    }
    #endregion

    #region Methods
    public void Listeleme(int durum)
    {
        Console.Clear();
        if (durum == 1)
        {
            Console.WriteLine("Yöneticiler\n--------------------------------");
            if (yoneticiler.Count == 0)
            {
                Console.Write("Kayıt bulunamadı!"); return;
            }
            foreach (var item in yoneticiler)
            {
                Console.Write("ID: {0}, Ad Soyad: {1}, Telefon No: {2}, Email: {3}, Adres: {4}, Yas: {5}, Erkek Mi: {6}, Maas: {7}, Görev: {8}, İzin Günleri: ", item.Id, item.AdSoyad, item.TlfNo, item.Email, item.Adres, item.Yas, item.ErkekMi, item.Maas, item.Gorev);
                foreach (var day in item.IzinGunleri)
                {
                    Console.Write(day + " ");
                }
                Console.WriteLine();
            }
        }
        else if (durum == 2)
        {
            Console.WriteLine("Memurlar\n--------------------------------");
            if (memurlar.Count == 0)
            {
                Console.Write("Kayıt bulunamadı!"); return;
            }
            foreach (var item in memurlar)
            {
                Console.Write("ID: {0}, Ad Soyad: {1}, Telefon No: {2}, Email: {3}, Adres: {4}, Yas: {5}, Erkek Mi: {6}, Maas: {7}, Görev: {8}, İzin Günleri: ", item.Id, item.AdSoyad, item.TlfNo, item.Email, item.Adres, item.Yas, item.ErkekMi, item.Maas, item.Gorev);
                foreach (var day in item.IzinGunleri)
                {
                    Console.Write(day + " ");
                }
                Console.WriteLine();
            }
        }
        else if (durum == 3)
        {
            Console.WriteLine("Temizlikçiler\n--------------------------------");
            if (temizlikciler.Count == 0)
            {
                Console.Write("Kayıt bulunamadı!"); return;
            }
            foreach (var item in temizlikciler)
            {
                Console.Write("ID: {0}, Ad Soyad: {1}, Telefon No: {2}, Email: {3}, Adres: {4}, Yas: {5}, Erkek Mi: {6}, Maas: {7}, Görev: {8}, İzin Günleri: ", item.Id, item.AdSoyad, item.TlfNo, item.Email, item.Adres, item.Yas, item.ErkekMi, item.Maas, item.Gorev);
                foreach (var day in item.IzinGunleri)
                {
                    Console.Write(day + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public string YoneticiEkleme(Yonetici yonetici)
    {
        if (yonetici != null)
        {
            foreach (var item in yoneticiler)
            {
                if (item.Id == yonetici.Id)
                {
                    return "Bu yönetici zaten kayıtlı!";
                }
            }
            yoneticiler.Add(yonetici);
            return "Yönetici eklendi!";
        }
        else
        {
            return "Yönetici eklenemedi!";
        }
    }
    public string MemurEkleme(Memur memur)
    {
        if (memur != null)
        {
            foreach (var item in memurlar)
            {
                if (item.Id == memur.Id)
                {
                    return "Bu memur zaten kayıtlı!";
                }
            }
            memurlar.Add(memur);
            return "Memur eklendi!";
        }
        else
        {
            return "Memur eklenemedi!";
        }
    }
    public string TemizlikciEkleme(Temizlikci temizlikci)
    {
        if (temizlikci != null)
        {
            foreach (var item in temizlikciler)
            {
                if (item.Id == temizlikci.Id)
                {
                    return "Bu temizlikçi zaten kayıtlı!";
                }
            }
            temizlikciler.Add(temizlikci);
            return "Temizlikçi eklendi!";
        }
        else
        {
            return "Temizlikçi eklenemedi!";
        }
    }
    public string YoneticiSilme(int Id)
    {
        foreach (var item in yoneticiler)
        {
            if (item.Id == Id)
            {
                yoneticiler.Remove(item);
                return "Yönetici silindi!";
            }
        }
        return "Bu yönetici zaten kayıtlı değil!";
    }
    public string MemurSilme(int Id)
    {
        foreach (var item in memurlar)
        {
            if (item.Id == Id)
            {
                memurlar.Remove(item);
                return "Memur silindi!";
            }
        }
        return "Bu memur zaten kayıtlı değil!";
    }
    public string TemizlikciSilme(int Id)
    {
        foreach (var item in temizlikciler)
        {
            if (item.Id == Id)
            {
                temizlikciler.Remove(item);
                return "Temizlikçi silindi!";
            }
        }
        return "Bu temizlikçi zaten kayıtlı değil!";
    }
    public string YoneticiBilgiGuncelleme(int ID)
    {
        Yonetici yonetici = yoneticiler.Find(yoneticiler => yoneticiler.Id == ID);
        if (yonetici != null)
        {
            Console.Write("Yeni Telefon No (varsa): "); string tlf = Console.ReadLine();
            Console.Write("Yeni Email (varsa): "); string email = Console.ReadLine();
            Console.Write("Yeni Adres (varsa): "); string adres = Console.ReadLine();
            Console.Write("Yeni Maaş (varsa): "); string maas = Console.ReadLine();
            Console.Write("Yeni Görev (varsa): "); string gorev = Console.ReadLine();
            if (!string.IsNullOrEmpty(tlf))
                yonetici.TlfNo = tlf;
            if (!string.IsNullOrEmpty(email))
                yonetici.Email = email;
            if (!string.IsNullOrEmpty(adres))
                yonetici.Adres = adres;
            if (maas != string.Empty)
                yonetici.Maas = int.Parse(maas);
            if (!string.IsNullOrEmpty(gorev))
                yonetici.Gorev = gorev;
            while (true)
            {
                Console.Write("İzin günü (varsa): ");
                string deger = Console.ReadLine();
                if (deger != string.Empty)
                {
                    if (deger == "1")
                        yonetici.IzinGunleri.Add(Gunler.Pazartesi);
                    else if (deger == "2")
                        yonetici.IzinGunleri.Add(Gunler.Salı);
                    else if (deger == "3")
                        yonetici.IzinGunleri.Add(Gunler.Çarşamba);
                    else if (deger == "4")
                        yonetici.IzinGunleri.Add(Gunler.Perşembe);
                    else if (deger == "5")
                        yonetici.IzinGunleri.Add(Gunler.Cuma);
                    else if (deger == "6")
                        yonetici.IzinGunleri.Add(Gunler.Cumartesi);
                    else if (deger == "7")
                        yonetici.IzinGunleri.Add(Gunler.Pazar);
                    else
                        break;
                }
                else
                    break;
            }
            return "Güncelleme başarılı!";
        }
        else
            return "Yönetici bulunamadı!";
    }
    public string MemurBilgiGuncelleme(int ID)
    {
        Memur memur = memurlar.Find(memurlar => memurlar.Id == ID);
        if (memur != null)
        {
            Console.Write("Yeni Telefon No (varsa): "); string tlf = Console.ReadLine();
            Console.Write("Yeni Email (varsa): "); string email = Console.ReadLine();
            Console.Write("Yeni Adres (varsa): "); string adres = Console.ReadLine();
            Console.Write("Yeni Maaş (varsa): "); string maas = Console.ReadLine();
            Console.Write("Yeni Görev (varsa): "); string gorev = Console.ReadLine();
            if (!string.IsNullOrEmpty(tlf))
                memur.TlfNo = tlf;
            if (!string.IsNullOrEmpty(email))
                memur.Email = email;
            if (!string.IsNullOrEmpty(adres))
                memur.Adres = adres;
            if (maas != string.Empty)
                memur.Maas = int.Parse(maas);
            if (!string.IsNullOrEmpty(gorev))
                memur.Gorev = gorev;
            while (true)
            {
                Console.Write("İzin günü (varsa): ");
                string deger = Console.ReadLine();
                if (deger != string.Empty)
                {
                    if (deger == "1")
                        memur.IzinGunleri.Add(Gunler.Pazartesi);
                    else if (deger == "2")
                        memur.IzinGunleri.Add(Gunler.Salı);
                    else if (deger == "3")
                        memur.IzinGunleri.Add(Gunler.Çarşamba);
                    else if (deger == "4")
                        memur.IzinGunleri.Add(Gunler.Perşembe);
                    else if (deger == "5")
                        memur.IzinGunleri.Add(Gunler.Cuma);
                    else if (deger == "6")
                        memur.IzinGunleri.Add(Gunler.Cumartesi);
                    else if (deger == "7")
                        memur.IzinGunleri.Add(Gunler.Pazar);
                    else
                        break;
                }
                else
                    break;
            }
            return "Güncelleme başarılı!";
        }
        else
            return "Memur bulunamadı!";
    }
    public string TemizlikciBilgiGuncelleme(int ID)
    {
        Temizlikci temizlikci = temizlikciler.Find(temizlikciler => temizlikciler.Id == ID);
        if (temizlikci != null)
        {
            Console.Write("Yeni Telefon No (varsa): "); string tlf = Console.ReadLine();
            Console.Write("Yeni Email (varsa): "); string email = Console.ReadLine();
            Console.Write("Yeni Adres (varsa): "); string adres = Console.ReadLine();
            Console.Write("Yeni Maaş (varsa): "); string maas = Console.ReadLine();
            Console.Write("Yeni Görev (varsa): "); string gorev = Console.ReadLine();
            if (!string.IsNullOrEmpty(tlf))
                temizlikci.TlfNo = tlf;
            if (!string.IsNullOrEmpty(email))
                temizlikci.Email = email;
            if (!string.IsNullOrEmpty(adres))
                temizlikci.Adres = adres;
            if (maas != string.Empty)
                temizlikci.Maas = int.Parse(maas);
            if (!string.IsNullOrEmpty(gorev))
                temizlikci.Gorev = gorev;
            while (true)
            {
                Console.Write("İzin günü (varsa): ");
                string deger = Console.ReadLine();
                if (deger != string.Empty)
                {
                    if (deger == "1")
                        temizlikci.IzinGunleri.Add(Gunler.Pazartesi);
                    else if (deger == "2")
                        temizlikci.IzinGunleri.Add(Gunler.Salı);
                    else if (deger == "3")
                        temizlikci.IzinGunleri.Add(Gunler.Çarşamba);
                    else if (deger == "4")
                        temizlikci.IzinGunleri.Add(Gunler.Perşembe);
                    else if (deger == "5")
                        temizlikci.IzinGunleri.Add(Gunler.Cuma);
                    else if (deger == "6")
                        temizlikci.IzinGunleri.Add(Gunler.Cumartesi);
                    else if (deger == "7")
                        temizlikci.IzinGunleri.Add(Gunler.Pazar);
                    else
                        break;
                }
                else
                    break;
            }
            return "Güncelleme başarılı!";
        }
        else
            return "Temizlikçi bulunamadı!";
    }
    public string YoneticileriDosyayaKaydet(string dosyaYolu)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                if (yoneticiler.Count > 0)
                {
                    foreach (var item in yoneticiler)
                    {
                        sw.Write(item.Id + "," + item.TCNoAl() + "," + item.AdSoyad + "," + item.TlfNo + "," + item.Email + "," + item.Adres + "," + item.Yas + "," + item.ErkekMi + "," + item.Maas + "," + item.Gorev + ",");
                        foreach (var days in item.IzinGunleri)
                        {
                            sw.Write(days + ";");
                        }
                        sw.WriteLine();
                    }
                }
            }
            return new FileInfo(Program.pathYoneticiler).Name + " dosyasına yöneticiler başarılı bir şekilde kaydedildi!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string YoneticileriDosyadanAl(string dosyaYolu)
    {
        List<Gunler> gunler = new List<Gunler>();
        yoneticiler.Clear();
        try
        {
            string line;
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts1 = line.Split(',');
                    if (parts1.Length > 10)
                    {
                        foreach (string day in parts1[10].Split(';'))
                        {
                            if (day == "Pazartesi")
                                gunler.Add(Gunler.Pazartesi);
                            else if (day == "Salı")
                                gunler.Add(Gunler.Salı);
                            else if (day == "Çarşamba")
                                gunler.Add(Gunler.Çarşamba);
                            else if (day == "Perşembe")
                                gunler.Add(Gunler.Perşembe);
                            else if (day == "Cuma")
                                gunler.Add(Gunler.Cuma);
                            else if (day == "Cumartesi")
                                gunler.Add(Gunler.Cumartesi);
                            else if (day == "Pazar")
                                gunler.Add(Gunler.Pazar);
                        }
                    }
                    YoneticiEkleme(new Yonetici(int.Parse(parts1[0]), parts1[1], parts1[2], parts1[3], parts1[4], parts1[5], int.Parse(parts1[6]), bool.Parse(parts1[7]), float.Parse(parts1[8]), parts1[9], gunler));
                }
            }
            return new FileInfo(Program.pathYoneticiler).Name + " dosyasından yöneticiler başarılı bir şekilde alındı!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string MemurlariDosyayaKaydet(string dosyaYolu)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                if (memurlar.Count > 0)
                {
                    foreach (var item in memurlar)
                    {
                        sw.Write(item.Id + "," + item.TCNoAl() + "," + item.AdSoyad + "," + item.TlfNo + "," + item.Email + "," + item.Adres + "," + item.Yas + "," + item.ErkekMi + "," + item.Maas + "," + item.Gorev + ",");
                        foreach (var days in item.IzinGunleri)
                        {
                            sw.Write(days + ";");
                        }
                        sw.WriteLine();
                    }
                }
            }
            return new FileInfo(Program.pathMemurlar).Name + " dosyasına memurlar başarılı bir şekilde kaydedildi!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string MemurlariDosyadanAl(string dosyaYolu)
    {
        List<Gunler> gunler = new List<Gunler>();
        memurlar.Clear();
        try
        {
            string line;
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts1 = line.Split(',');
                    if (parts1.Length > 10)
                    {
                        foreach (string day in parts1[10].Split(';'))
                        {
                            if (day == "Pazartesi")
                                gunler.Add(Gunler.Pazartesi);
                            else if (day == "Salı")
                                gunler.Add(Gunler.Salı);
                            else if (day == "Çarşamba")
                                gunler.Add(Gunler.Çarşamba);
                            else if (day == "Perşembe")
                                gunler.Add(Gunler.Perşembe);
                            else if (day == "Cuma")
                                gunler.Add(Gunler.Cuma);
                            else if (day == "Cumartesi")
                                gunler.Add(Gunler.Cumartesi);
                            else if (day == "Pazar")
                                gunler.Add(Gunler.Pazar);
                        }
                    }
                    MemurEkleme(new Memur(int.Parse(parts1[0]), parts1[1], parts1[2], parts1[3], parts1[4], parts1[5], int.Parse(parts1[6]), bool.Parse(parts1[7]), float.Parse(parts1[8]), parts1[9], gunler));
                }
            }
            return new FileInfo(Program.pathMemurlar).Name + " dosyasından memurlar başarılı bir şekilde alındı!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string TemizlikcileriDosyayaKaydet(string dosyaYolu)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                if (temizlikciler.Count > 0)
                {
                    foreach (var item in temizlikciler)
                    {
                        sw.Write(item.Id + "," + item.TCNoAl() + "," + item.AdSoyad + "," + item.TlfNo + "," + item.Email + "," + item.Adres + "," + item.Yas + "," + item.ErkekMi + "," + item.Maas + "," + item.Gorev + ",");
                        foreach (var days in item.IzinGunleri)
                        {
                            sw.Write(days + ";");
                        }
                        sw.WriteLine();
                    }
                }
            }
            return new FileInfo(Program.pathTemizlikciler).Name + " dosyasına temizlikçiler başarılı bir şekilde kaydedildi!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string TemizlikcileriDosyadanAl(string dosyaYolu)
    {
        List<Gunler> gunler = new List<Gunler>();
        temizlikciler.Clear();
        try
        {
            string line;
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts1 = line.Split(',');
                    if (parts1.Length > 10)
                    {
                        foreach (string day in parts1[10].Split(';'))
                        {
                            if (day == "Pazartesi")
                                gunler.Add(Gunler.Pazartesi);
                            else if (day == "Salı")
                                gunler.Add(Gunler.Salı);
                            else if (day == "Çarşamba")
                                gunler.Add(Gunler.Çarşamba);
                            else if (day == "Perşembe")
                                gunler.Add(Gunler.Perşembe);
                            else if (day == "Cuma")
                                gunler.Add(Gunler.Cuma);
                            else if (day == "Cumartesi")
                                gunler.Add(Gunler.Cumartesi);
                            else if (day == "Pazar")
                                gunler.Add(Gunler.Pazar);
                        }
                    }
                    TemizlikciEkleme(new Temizlikci(int.Parse(parts1[0]), parts1[1], parts1[2], parts1[3], parts1[4], parts1[5], int.Parse(parts1[6]), bool.Parse(parts1[7]), float.Parse(parts1[8]), parts1[9], gunler));
                }
            }
            return new FileInfo(Program.pathTemizlikciler).Name + " dosyasından temizlikçiler başarılı bir şekilde alındı!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    #endregion
}