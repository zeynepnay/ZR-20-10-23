<<<<<<< HEAD
# Javascript Kod Yapısına Dair Birkaç Söz
* Komutları oluşturabilmek için yazdığımız kod cümlelerine ifade(statement) denir.
* İfadeler birbirinden (;) işareti ile ayrılır.
* JS ifadelerin sonuna (;) konulmasını zorunlu kılmaz, kendisi otomatik olarak koyabilir.
* Ancak bu özelliğe güvenmemeliyiz. Kendimiz (;) koymaya alışmalıyız.
* Nedenlerini ilerledikçe öğreneceksiniz.
* Yine de detaylı bilgi almak isteyenler  [ECMAScript Automatic Semicolon Insertion](https://tc39.es/ecma262/#sec-automatic-semicolon-insertion) linkinden inceleyebilirler.
* Tanımlayıcı(Değişken, Fonksiyon vb.) adlandırma kuralları:
    * Tanımlayıcı adları harf, (_), ($) işareti ile başlayabilir; diğer özel karakterler ya da rakamlarla başlayamaz.
    * İlk karakterden sonra (_), ($), harf ya da rakam dışında herhanbi bir karakter bulunamaz.
    * Tanımlayıcı adları küçük/BÜYÜK harf duyarlıdır.
* İSİMLENDİRMEDE TÜRKÇE KARAKTER KULLANMAMAYA ALIŞMALIYIZ!
* İsimlendirme Yöntemleri(Her programlama dilinde geçerli)
    * Camel Case:
        En çok kullanılan isimlendirme yöntemlerinden biridir. Sözcüklerin ilk harfi büyük geri kalan harfleri küçük yazılır. İki kullanım şekli vardır:
        * Upper Camel Case: Buna Pascal Case de denir. Her sözcüğün ilk harfi büyük, geri kalan harfleri küçük yazılır. Ör: AdSoyad, DogumTarihi, KdvOrani
        * Lower Camel Case: İlk sözcük tamamen küçük, geri kalanların ise ilk harfi büyük geri kalanları küçük yazılır. Ör: adSoyad, dogumTarihi, kdvOrani
    * Snake Case:
        Sözcükler birbirinden (_) ile ayrılır. Upper, Lower ve Screaming versiyonları vardır. Ör: Ad_Soyad, ad_soyad, dogum_tarihi, Dogum_Tarihi, AD_SOYAD, DOGUM_TARIHI
    * Diğer

* Java Script Name Conventions
    * Değişkenler: 
        * Büyük küçük harf duyarlı.
        * camelCase kullanılır, harfler başlanır.
        * İçindeki değeri açıklayıcı nitelikte.
        * Mantıksal(Boolean) değişkenler genellikle is ya da has ifadesiyle başlatılır.
        * İngilizce kavramlar kullanın.
    * Fonksiyon ve Sınıf Metotları
        * Büyük küçük harf duyarlı.
        * camelCase kullanılır, harfler başlanır.
        * Genelde get, make, apply gibi emir kipi ile başlamalı.
    * Sabitler:
        * Büyük küçük harf duyarlı.
        * Screaming Snake Case kullanılır.
        * Genelde en üstte olur.
    * Sınıflar: 
        * Büyük küçük harf duyarlı.
        * PascalCase kullanılır, harfle başlanır.
        * Sınıfın işlevselliğini açıklayıcı nitelikte.
    * Private:
        * _ ile başlar.


* Resmi Dökümantasyon: [ECMAScript Official Documentation](https://tc39.es/ecma262)

* MDN Javascript Tutorial: [MDN JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
=======
normal metin dosyası gibi
md olmasından dolayı özel bazı seyleri lkarakterleri kullanrak biçim verebilmenizi sağlıyor
# olarak yazabiliriz.
# javascript syntax (söz dizimi)
* liste olusturmamızı sağlıyor 
*official dokumantasyondan bakabiliriz.
* Javascript'te komut oluşturabilmek için yazdıgımız kod cumlelerine ifade(statement diyoruz.)


document.getElementById("button").addEventListener("click", () => {
    alert("Butona tıkladın (Yöntem-3-External)")
});

mesela bu bir ifade ve birbirlerinden ; ile ayrılıyorlar.

*Ancak Js'te ifadelerin sonuna ; isareti koymak zorunlu değildir.

* her ne kadar zorunlu değilse de ifadelerin sonuna mutlaka ; koymaya dikkat edin

* [ECMAScript Automatic Semicolumn Insertion detaylı bilgi](https://tc39.es/ecma262/multipage/ecmascript-language-lexical-grammar.html#sec-automatic-semicolon-insertion)

ekrana yaz fonksiyonu hazırlıcaz mesela
yas hesapla diye bir fonksiyonumuz olacak
classlarımız olacak tanımlayıcılar diyoruz
abzı kurallar var bununla ilgili

* tanımlıyıcıların isimlendirilmesi ile ilgili hususlar :
    tab tusuna basında liste gibi yapıyor
    tanımlayıcı adları (değişken, fonksiyon,) adları(_) , ($) ve harf ile başlayabilir.
    yani özel karakter ya da rakamla başlayamaz.

tanımlayıcı adları küçük/büyük harf duyarlıdır.


yas= 30;
şu an bir değişken tanımladık.
_yas= 40;
bu şekilde de başlayabilir

$yas = 50 ;
bu sekilde de kullanılabilir.


* İSİMLENDİRME YAPARKEN TÜRKÇE KARAKTER KULLANMAYIN.
* Tanımlayıcı isimlendirme teknikleri
    *Camel Case:
    En cok kullanılan isimlendirme tekniklerinden biridir.
    sözcüklerin ilk harfi büyük geri kalanlar küçük yazılır.iki kullanım şekli var.
        *Upper Camel Case: Pascal Case de denir.bu yöntemde gerçekten de sözcüklerin ilk harfi büyük
        ,diğerleri küçüktür.
        örnek : FirstName , DogumTarihi , GirisSartı, İseBaslamaTarihi
        * Lower Camel Case : Genellikle Camel Case dendiğinde akla bu gelir. ilk sözcük tamamen küçük harflerle yazılır.
        geri kalanlar Upper Camel Case kuralı ile yazılır.
        dogumTarihi , firstName mesela
*Snake Case : sözcüklerin birbirinden _ işareti ile ayrılarak yazıldıgı tekniktir.3 kullanım şekli vardır
    * Upper Snake Case : FIRST_NAME, DOGUM_TARİHİ , GİRİS_SAATİ , İSE_BASLAMA_TARİHİ
    * Lowe Snake Case : first_name , dogum_tarihi
    * Screaming Snake Case : First_Name 


* Java Script'te isimlendirme teknikleri
    * Değişkenler:
        * Büyük Küçük harf duyarlı
        * camelCase tekniği kullanılır.
        * değişken içerdiği değeri tanımlayacak şekilde bir isme sahip olmalıdır.
        * mantıksal(boolean) değişkenlere isim verirken is , has gibi ifadelerle başlamasına dikkat edilmelidir.
        * Mümkün olduğu kadar ingilizce kavramlarla isimlendirme yapılmalıdır.
    * Fonksiyonlar:
        * Büyük küçük harf duyarlı
        * camelCse tekniği kullanılır.
        * fonksiyonlara isim verirken get , make , apply gibi emir kipi içeren ifadelerle başlanmalıdır.





>>>>>>> 3ae083e76647e8d1da5dd98c06a25b38f99c135b
