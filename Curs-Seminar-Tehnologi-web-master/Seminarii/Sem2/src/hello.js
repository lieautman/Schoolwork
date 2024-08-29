console.log("hello world!");

let sayHello = (name) => {
  return `Hello, ${name}!`;
};
//let sayHello1 = (name) => `Hello, ${name}!`;
//1
let concatenateArray = (arguments) => {
  let srtingConcat = "";
  for (let i = 0; i < arguments.length; i++) srtingConcat += arguments[i];
  return srtingConcat;
};
let concatenateArray1 = (arguments) => {
  let result = "";
  for (const element of arguments) {
    result += element;
  }
  return result;
};
let concatenateArray2 = (arguments) => {
  return arguments.join("");
};
let concatenateArray3 = (list) => list.join("");
const params = process.argv.slice(3, process.argv.length);

console.log(concatenateArray3(params));
console.log(sayHello(process.argv[2]));
console.log(concatenateArray(["EU ", "pot ", "sa o fac!"]));

//... pentru destructurare(spread oeprator)
//2
function checkDivisivle(n, divisor) {
  if (n % divisor) {
    return false;
  } else {
    return true;
  }
}
console.log(checkDivisivle(10, 2));
console.log(checkDivisivle(10, 3));

function countDifferences(a, b) {
  if (a.length !== b.length) return -1;
  else {
    let nr = 0;
    for (let i = 0; i < a.length; i++) {
      if (a[i] !== b[i]) nr++;
    }
    return nr;
  }
}

console.log(countDifferences("aaa", "aab"));
console.log(countDifferences("aaa", "aabb"));

//3
function accurances(text, character) {
  let count = 0;
  for (var i = 0; i < text.length; i++) {
    if (text.charAt(i) === character) count++;
  }
  return count;
}

//let occurances = (text, character) => text.split(character).length - 1;

console.log(accurances("sample text", "e"));

const sampleInput = "1,23,3,455,2,3";
function listOfNumbersToArray(numbers) {
  const result = [];
  const items = numbers.split(",");
  for (const item of items) {
    result.push(parseInt(item));
  }
  return result;
}

const convert = (s) => s.split(",").map((e) => parseInt(e));

console.log(listOfNumbersToArray(sampleInput));
console.log(convert(sampleInput));

//4
function addToArray() {
  let args = arguments;
  let array = args[0];
  for (var i = 1; i < args.length; i++) array.push(args[i]);
  return array;
}
let array = ["a"];
console.log(addToArray(array, "b", "c").join(", "));

function intercalareArray(array1, array2) {
  let arrayResult = [];
  for (let i = 0; i < array1.length; i++) {
    arrayResult.push(array1[i]);
    arrayResult.push(array2[i]);
  }
  return arrayResult;
}

console.log(intercalareArray(["a", "c"], ["b", "d"]));

function addToArrayOfArguments() {
  //(array, ...args)//fara urm linie
  let args = arguments;
  let array = args[0];
  for (var i = 1; i < args.length; i++) {
    array.push(args[i]);
  }
  return array;
}

let array4 = new Array();
let array5 = ["a"];
console.log(addToArray(array5, "b", "c").join(", "));

//5
if (process.argv.length < 3) {
  console.log("not enough params");
} else {
  console.log("fine");
}

//de facut tema
//6
const sampleString1 = "the quick brown fox jumps over the lazy dogs";
const getCounts = (text) => {
  const words = text.split(" ");
  const result = {};
  for (let word of words) {
    if (word in result) {
      result[word]++;
    } else {
      result[word] = 1;
    }
  }
  for (let word in result) {
    result[word] /= words.length;
  }
  return result;
};

console.log(getCounts(sampleString1));

//de facut tema
let a = "a";
//in plus
//const sampleString = "i am a {type}";
//const sampleFormat = { type: "special" };

//function format(s, formatSpec) {
//  let modified = this;
// for (let prop in formatSpec) {
// if (modified.indexOf("{" + prop + "}") !== -1) {
//   modified = modified.replace("{" + prop + "}", formatSpec[prop]);
// }
//}
//return modified;
//}

//console.log(format(sampleString, sampleFormat));
//console.log("i am a {type} string".format(sampleFormat));
