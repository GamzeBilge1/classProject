
using classProject;

// öğrenci ve ogretmen sınıflarından her kişi için nesne oluşturulur.

Person ogrenci1 = new Person();
Person ogrenci2 = new Person();
Person ogretmen1 = new Person();
Person ogretmen2 = new Person();

// kişilerin bilgileri atanır

ogrenci1.Ad = "Gamze";
ogrenci1.Soyad = "Bilge";
ogrenci1.DogumTarihi = new DateTime(2000, 5, 15);


ogrenci2.Ad = "Ayşe";
ogrenci2.Soyad = "Güler";
ogrenci2.DogumTarihi = new DateTime(2005, 7, 19);


ogretmen1.Ad = "Ali";
ogretmen1.Soyad = "Akça";
ogretmen1.DogumTarihi = new DateTime(1984, 7, 6);

ogretmen2.Ad = "Merve";
ogretmen2.Soyad = "Pınar";
ogretmen2.DogumTarihi = new DateTime(1990, 2, 1);


static void Yazdir(Person kisi , string rol) // kod tekrarını azaltmak amacıyla yazdırma işlemi için metod
{
    Console.WriteLine($"{rol} Adı: {kisi.Ad}");
    Console.WriteLine($"{rol} Soyadı: {kisi.Soyad}");
    Console.WriteLine($"{rol} DoğumTarihi: {kisi.DogumTarihi.ToShortDateString()}"); // DateTime varsayılan olarak hem tarih hem de saat bilgisini tutar ve yazdırır.
                                                                                     // Konsola sadece tarih bilgisini yazdırmak için "ToShortDateString" metodunu kullandım.
}

// Öğrenciler ve öğretmenlerin bilgilerini yazdırmak için Yazdir() metodu çağrılır

Yazdir(ogrenci1, "Öğrenci");
Yazdir(ogrenci2, "Öğrenci");
Yazdir(ogretmen1, "Ögretmen");
Yazdir(ogretmen2, "Ögretmen");