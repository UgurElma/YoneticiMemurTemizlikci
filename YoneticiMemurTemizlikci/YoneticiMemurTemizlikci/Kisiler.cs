using System.Collections.Generic;

class Insan
{
    #region Members
    protected string TCKmlkNo { get; set; }
    internal string AdSoyad { get; set; }
    internal string TlfNo { get; set; }
    internal string Email { get; set; }
    internal string Adres { get; set; }
    internal int Yas { get; set; }
    internal bool ErkekMi { get; set; }
    #endregion

    #region Constructor Method
    protected Insan() { }
    #endregion
}

class Yonetici : Insan
{
    #region Members
    internal int Id { get; set; }
    internal float Maas { get; set; }
    /// <summary>
    /// Neyi yönetir?
    /// </summary>
    internal string Gorev { get; set; }
    internal List<Gunler> IzinGunleri { get; set; }
    #endregion

    #region Constructor Method
    internal Yonetici(int id, string tcKmlkNo, string adSoyad, string tlfNo, string email, string adres, int yas, bool erkekMi, float maas, string gorev, List<Gunler> izinGunleri)
    {
        Id = id;
        base.TCKmlkNo = tcKmlkNo;
        base.AdSoyad = adSoyad;
        base.TlfNo = tlfNo;
        base.Email = email;
        base.Adres = adres;
        base.Yas = yas;
        base.ErkekMi = erkekMi;
        Maas = maas;
        Gorev = gorev;
        IzinGunleri = izinGunleri;
    }
    #endregion

    #region Method
    /// <summary>
    /// Özel durumlarda alınmalı
    /// </summary>
    /// <returns></returns>
    internal string TCNoAl()
    {
        return base.TCKmlkNo;
    }
    #endregion
}
class Memur : Insan
{
    #region Members
    internal int Id { get; set; }
    internal float Maas { get; set; }
    /// <summary>
    /// İşi nedir?
    /// </summary>
    internal string Gorev { get; set; }
    internal List<Gunler> IzinGunleri { get; set; }
    #endregion

    #region Constructor Method
    internal Memur(int id, string tcKmlkNo, string adSoyad, string tlfNo, string email, string adres, int yas, bool erkekMi, float maas, string gorev, List<Gunler> izinGunleri)
    {
        Id = id;
        base.TCKmlkNo = tcKmlkNo;
        base.AdSoyad = adSoyad;
        base.TlfNo = tlfNo;
        base.Email = email;
        base.Adres = adres;
        base.Yas = yas;
        base.ErkekMi = erkekMi;
        Maas = maas;
        Gorev = gorev;
        IzinGunleri = izinGunleri;
    }
    #endregion

    #region Method
    /// <summary>
    /// Özel durumlarda alınmalı
    /// </summary>
    /// <returns></returns>
    internal string TCNoAl()
    {
        return base.TCKmlkNo;
    }
    #endregion
}
class Temizlikci : Insan
{
    #region Members
    internal int Id { get; set; }
    internal float Maas { get; set; }
    /// <summary>
    /// İşi nedir?
    /// </summary>
    internal string Gorev { get; set; }
    internal List<Gunler> IzinGunleri { get; set; }
    #endregion

    #region Constructor Method
    internal Temizlikci(int id, string tcKmlkNo, string adSoyad, string tlfNo, string email, string adres, int yas, bool erkekMi, float maas, string gorev, List<Gunler> izinGunleri)
    {
        Id = id;
        base.TCKmlkNo = tcKmlkNo;
        base.AdSoyad = adSoyad;
        base.TlfNo = tlfNo;
        base.Email = email;
        base.Adres = adres;
        base.Yas = yas;
        base.ErkekMi = erkekMi;
        Maas = maas;
        Gorev = gorev;
        IzinGunleri = izinGunleri;
    }
    #endregion

    #region Method
    /// <summary>
    /// Özel durumlarda alınmalı
    /// </summary>
    /// <returns></returns>
    internal string TCNoAl()
    {
        return base.TCKmlkNo;
    }
    #endregion
}