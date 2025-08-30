# 📚 LINQ Join Pratik

Bu proje, basit bir kütüphane yönetim sistemi üzerinde **LINQ Join** kullanımını göstermektedir. Amaç, kitaplar ile yazarları ilişkilendirip ekrana yazdırmaktır.

---

## 🚀 Özellikler

* **Author (Yazar)** ve **Book (Kitap)** adında iki sınıf tanımlanmıştır.
* Örnek yazar ve kitap verileri listeler halinde eklenmiştir.
* **LINQ join** ifadesi ile kitap ve yazarlar eşleştirilmiştir.
* Sonuçlar ekranda **Kitap Adı – Yazar Adı** formatında yazdırılmaktadır.

---

## 🏗️ Proje Yapısı

```plaintext
Linq_Join_Pratik/
│
├── Program.cs    # Ana uygulama dosyası
```

---

## 📄 Kod Parçası

```csharp
var query = from book in books
            join author in authors
            on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

foreach (var item in query)
{
    Console.WriteLine($"Kitap: {item.BookTitle} - Yazar: {item.AuthorName}");
}
```

---

## ✅ Örnek Çıktı

```
Kitap: Kar - Yazar: Orhan Pamuk
Kitap: Benim Adım Kırmızı - Yazar: Orhan Pamuk
Kitap: İnce Memed - Yazar: Yaşar Kemal
Kitap: Aşk - Yazar: Elif Şafak
```

---

## 🎯 Öğrenilenler

* LINQ `join` ile tabloların nasıl birleştirileceği.
* Koleksiyonlar üzerinde sorgulama mantığı.
* Basit bir **kütüphane sistemi** senaryosunda pratik uygulama.
