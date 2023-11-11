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





