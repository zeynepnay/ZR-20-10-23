"use strict";

let students = ["ayşen" , "umay","ceyda" ,"begüm" , "köfte" , "heda"];

let result;

result = students.length;
result = students;
result=students.toString();
result =students.join(";");
result=result.split(";");

let products1=["Ürün1" , "Ürün2" , "Ürün3"];
let products2 =["Ürün4","Ürün5", "Ürün6"];

result=products1.concat(products2);

// students.push("zeynep"); //sona eleman ekler.
// students.pop(); //sondaki elemanı siler.
// students.shift(); //ilk elemanı siler
// students.unshift("Ece"); //başa eleman ekler.

//students dizisindeki "ceyda" değerini taşıyan değerini Ece olarak değiştirin.
// let indexno = students.indexOf("ceyda");
// students[indexno]="Ece";

// students[students.indexOf("ceyda")]="ece";


// students.splice(students.indexOf("ceyda"),1);

students.splice(2,3); //hangisinden başladığımızı söyleyip , kaç tane sileceğini söylüyoruz.

result=students;


console.log(result);

