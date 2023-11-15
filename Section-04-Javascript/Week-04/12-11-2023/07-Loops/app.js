// Döngü: Aynı kod parçasının tekrar tekrar çalıştırılmasını sağlayan yapıya döngü denir.

//WHILE
// let a = 1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

// 1-10 arasındaki çift sayıları konsola yazdırın.
// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// };
2575
// SORU:
// 1-50 arasındaki 4'ün katı olan sayıların adedini bulup konsola yazdırın.

// let i = 1;
// let counter = 0;434
// while (i <= 50) {
//     if (i % 4 == 0) {
//         counter++;
//     }
//     i++
// }
// console.log("1-50 arasındaki 4'ün katları olan sayı adedi: " + counter);

// girilecek 3 adet sayıyı toplayıp,konsola yazdırın.

// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("Lütfen sayı giriniz:"));
//     // total= total + num;
//     total += num;
//     i++
// }
// console.log(total);


//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız.not : kullanıcı 0 girerse uygulama sona ersin.

// let i = 1;
// let total = 0;
// let num;
// while (true) {
//     num = Number(prompt("Lütfen bir sayı giriniz:"));
//     if (num == 0) {
//         break;
//     }
//     total += num;


// console.log("toplam: " + total);

//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız.not : kullanıcı Exit girerse uygulama sona ersin.

// let i = 1;
// let num;
// let total = 0;

// while (true) {
//     num = prompt("Lütfen " + i + ". sayı giriniz:");
//     if (num.toLocaleLowerCase() ==6 "exit") {
//         break;
//     }
//     total += Number(num);
//     i++;
// }
// i--;
// console.log("Girdiğiniz " + i + " adet sayının toplamı: " + total);

// let count = Number(prompt("Lütfen 1 sayı gir:"));
// for (let i = 1; i <= count; i++) {
//     console.log(i);
// }


//1-10 arasındaki çift sayıları konsola yazdır.

// for (let i = 0; i <= 10; i++) {
//     if (i % 2 == 0)
//         console.log(i);
// }


// for (i = 1; i <= 10; i += 2) {

//     if (i % 2 == 0) {
//         continue;
//     }
//     console.log(i);
// }

//kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız.not : kullanıcı Exit girerse uygulama sona ersin. not2: for kullanın.

// let total = 0;
// let num;
// for (let i = 0; i == 0;) {
//     num = prompt("Lütfen bir sayı giriniz: ");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
// }
// console.log(total);


// 1- 20 arasındaki sayıları consolea şu şekilde yazdıran kodu hazırlayınız.

// 1-Tek Sayı
// 2-Çift Sayı
// 3-Tek Sayı


for (let i = 1; i <= 20; i++) {

    if (i % 2 == 1) {
        console.log(i + "-) Tek Sayı")
    }
    else {
        console.log(i + "-) Çift Sayı")
    }

}

