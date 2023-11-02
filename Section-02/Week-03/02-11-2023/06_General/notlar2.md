control H
find replace


birden fazla kelime oldugunda bazen tırnak içinde yazmamızı istiyor

font awesome
ikonlar için


cdn linkleri

git css klasörümdeki dosyaları dahil etti
ve harici bir siteden de dosyayı dahil et dedik

304
local kendi sunucumuz

harici 200 yüklendi ise 

başarılı

bodynin içine yazdıgımız herşey sitenin içeriği
sabit standart parçası

developerlar diyorki
.container diye div oluşturur 
<div class="container"></div>
oluyor zaten bütün içeriği buraya alırız
body'yi kirletmemek için vs
container burda sınıf oldu
heryerde kullanabiliriz.
bodynin kendine ayrı yapısını bozmamış oluyoruz.

3 temel parçam olsun
bir header
bi tane içerik için
bir tane de footer olsun
Header - Main - Footer

solda marka
sagda menümüz olucak
headerimiz bu
bir a elementi oluşturalım header logo adında

/index.html kısaca / ile gösterilir ana sayfaya gider.

yenilediğimizde server'a gidip geliyor
istekte bulunuyoruz
o da talebimize cevap veriyor
ana sayfa dediğimiz sey ne : index.html

/
bu sitemizin neresinde olursak olalım ,sitemizin ana sayfasına gidiyor olacak.

# diyez de hiçbişey yapmamasını sağlıyor.

nav
bizden sonra kodu okuyacak kişi nav elementinin 


li.main-nav-item*4>a

site.css
library.css
index.html diye bir dosyanız var

bu dosyalara link verirken
href="/site.css"
olarak link vermeliyiz.

"css/site.css" olarak verirsek olmaz.

bizde index dışarıda.css dosyasının dışında


vw 
görünen tarayıcısı alanını yüzde olarak yapıyor.


auto diyince
left right 
olanı cıkarıp 
diyince ikiye bölüyor

 a
 inline
 
 nav
 block 
 elemet

 display inline block nedir

 şimdilik yanyana getirmeye calıştıgım elementler
 a ve nav
 kapsyıcı alenet header
 o zaman headera uygulayacagız.
 display: flex;

kapsayıcı elemente esnek dedim
bu header kutusu esnek olsun
yayılsınlar.

a ve nav'A yanyana gelin dedik galiba


noktalardam kurtulmak için
list-style-type: none;


li default olarak 
block


biz yanyana görmek istiyoruz
bunların kapsayıcı olan a flex diyoruz
display: flex;

movie bizim için a
diğerleri home'dan logine nav


flex içindeyse flex item diyoruz.

eşit aralıklara dagıtabilmek için
bizde 2 element var
justify-content 
içeriğin hizalanması
justify-content: space-between;


1.elemennti en sola sonuncu elementi en sağa yaslar ve diğerlerini eşit aralıklarla yerleştirir.


main-nav-itemsin genişliği şu an yazı kadar.
bir genişlik vermeliyiz.


hata aldıgında class isimlerine dikkat et 
- gibi aradakileri unutma

(vw dediğimde görünen ekranın demek istedim.)

 home için de sadece sağdan ver dicez.
 mr-4
 ile çevirdik
 diğerleri mh
 sagdan soldan

 login için
 ml-4
 buna sadece soldan ver dedik

bir flex kapsayıcısının içindeki flex itemların boşlukları gap ile verilir.
 gap: 20px;
 bu da araları açar.
bütün yönlere aralık bırakır.
sag sol üst alt aralarına da bırakıyor.


column-gap: 20px; bu sadece satır içindeki boşluklara bakıyor.


flex-direction: row;
bu default özellik

column yapınca
sanki flex yapmamışız gibi oldu

bir element row yapılırsa sıralamasını sağlıyoruz satır - 1 satırda 
column yaptıgımızda hepsi 1 kolonda alt alta koy demiş oluyoruz. 1 sütünda

flex-wrap: ;
sarmalama özelliği
fazla olanları sogmadıgı anda alt satıra at.
hala hepsi aynı row

default olarak
flex-wrap: nowrap;



flex-wrap: wrap-reverse;
sığmayana üst satıra atıyor.

flex-flow: row wrap ;
tek kalemde veriyoruz
direction ve wrap özelliği

justify-content: start;
default bu


justify-content: end;
sağa hizaladı.


bütün bu ayarlarımı kapsayıcısına uyguluyorum.

 justify-content: space-between;
 sol kenara ve sağ kenara yapıştırıp aradaki boşluga göre dagıttı.

 justify-content: space-around;
 bunların genişliklerini topladı toplam 500 oldu
 toplam ekran 1500 ise
 çıkardı 
 sağ ve sol tarafı da dahil eip 10 eşit parçaya böldü
 5 elementin soluna sağına eşit verdi.

 space evenly ne yapar

 height burda miras olarak verildi.



align-items: ;
row ise 



colorhunt
renkler için


:root özel bir alan açıyor değişken tanımlamalarınızı yapabilirsiniz.

--primary-color:#219C90;

başta -- kullanıyoruz.


HEXA DECİMal
EN BÜYÜK F 
black için #000000
ama beyaz için 0123456789ABCDEF olarak bakıldıgında
#FFFFFF


background-color: var(--secondary-color);

isim verdiğimiz renk değişkenlerini kullanmak için var() yapıyoruz.



 .main-nav-item a:hover{
    
}

hover üzerine gelince demek a ların


rgba
transparanlık
0 verdiğinde komple görünür












