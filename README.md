# Proje Açıklaması
Bu proje, **`Person`** adında bir sınıf ve konsol uygulamasını içerir. **`Person`** sınıfı, öğrenci ve öğretmen bilgilerini tutar ve konsola yazdırır.

## Özellikler
- **Ad**: Kişinin adı (**string**).
- **Soyad**: Kişinin soyadı (**string**).
- **DogumTarihi**: Kişinin doğum tarihi (**DateTime**).

## Proje Detayları
- Öğrenci ve öğretmen bilgileri, **`ToShortDateString()`** kullanılarak yalnızca **tarih** olarak yazdırılır (**saat bilgisi olmadan**).
- **`Yazdir` metodu**, kişilerin bilgilerini konsola düzenli bir formatta yazar.

## Örnek Çıktı

Aşağıda projenin çalıştırıldığında konsolda ürettiği çıktı verilmiştir:

```plaintext
Öğrenci Adı: Gamze
Öğrenci Soyadı: Bilge
Öğrenci Doğum Tarihi: 15.05.2000
---------------------------
Öğrenci Adı: Ayşe
Öğrenci Soyadı: Güler
Öğrenci Doğum Tarihi: 19.07.2005
---------------------------
Öğretmen Adı: Ali
Öğretmen Soyadı: Akça
Öğretmen Doğum Tarihi: 06.07.1984
---------------------------
Öğretmen Adı: Merve
Öğretmen Soyadı: Pınar
Öğretmen Doğum Tarihi: 01.02.1990
---------------------------
