let courseName = "Fullstack Web Developer Eğitimi";
let result;

result = courseName.toLowerCase();
result = courseName.toLocaleLowerCase();
result = courseName.toUpperCase();
result = courseName.toLocaleUpperCase();


result = courseName.length; // Property - Özellik
result = courseName[0];
result = courseName[12];

result = courseName.slice(0, 2);

result = courseName.slice(14, 23);

result = courseName.replace("Eğitimi", "Kursu");
result = courseName.replace("e", "a");
result = courseName.trim();
result = courseName.trimStart();
result = courseName.trimEnd();

result = courseName.indexOf("D", 3);
result=courseName.split("");

result=courseName.startsWith("f");
result=courseName.endsWith("i");

console.log(result);


//indexOf ile ilgili minnak bir örnek

// let message;
// let findedText;

// message = prompt("Lütfen metni giriniz:");
// findedText = prompt("Lütfen arayacagınız metni ya da karakteri giriniz.");
// result = message.indexOf(findedText);

// if (result == -1) {
//     alert(message + "içinde " + findedText + " bulunamamıştır.");
// }
// else {
//     alert("'" + message + "' içinde '" + findedText + "' " + (result +1) + ". sırada bulunmaktadır");
// }

