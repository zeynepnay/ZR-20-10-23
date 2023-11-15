let result;
let now;
now = new Date;
result = now;
result = now.getDate();  // günü verir.
result = now.getDay(); //haftanın kaçıncı günü oldugunu verir.

// let newDate = new Date(2023 , 5 , 12); // ayları 0dan başlıyor . ocak sıfırdan alıyor.
// result = newDate.getDay();  // günleri numaralandırmaya 0dan başlıyor ama pazar günü.

result = now.getFullYear();
result = now.getHours();
result = now.getTime();

result = new Date(1900, 0, 1);
let year = result.getFullYear() + 3;
let month = result.getMonth();
let day = result.getDate();
result = new Date(year, month, day);
// console.log(result);


//kaç gün yaşadığımızı bulan kod

let birthday = new Date(1995, 4, 15)
let milisecond = now - birthday;
let second= milisecond / 1000;
let minute = second/60;
let hour = minute/60 ;
let dayCount=hour / 24;


console.log(dayCount);
console.error(dayCount);
console.warn(dayCount);

//araştırma ödevi = getTime()'ı sıfır olan tarih nedir?


