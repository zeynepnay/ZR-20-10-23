import { arrayASC , getArray , arrayDESC} from "./MyModules/sort-array.js";

const randomNumbers = getArray(10);

console.log(randomNumbers);
console.log(arrayASC(randomNumbers));
console.log(arrayDESC(randomNumbers));



// let stringArray = ["Ece" , "Cağdaş" , "Melise" , "Furkan" , "Baransel"];
// console.log(arrayASC(stringArray));