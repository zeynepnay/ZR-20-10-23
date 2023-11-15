let courseName = "Fullstack Web Developer Eğitimi";
let result;

result= courseName.toLowerCase();
result= courseName.toLocaleLowerCase();
result=courseName.toUpperCase();
result=courseName.toLocaleUpperCase();


result=courseName.length; // Property - Özellik
result= courseName[0];
result=courseName[12];

result=courseName.slice(0,2);

result=courseName.slice(14,23);

result=courseName.replace("Eğitimi" , "Kursu");
result=courseName.replace("e" , "a");
result=courseName.trim();
result=courseName.trimStart();
result=courseName.trimEnd();

result=courseName.indexOf("D", 14 );

console.log(result);


