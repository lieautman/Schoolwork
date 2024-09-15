//1
const words = ["fox","wolf","snake","crocodile","dog"]

const forbiddenWord = "crocodile"
const minLength = 4;

const filterWords = (words, forbiddenWord, minLength) =>{
    const result = words.filter((word) => {
        if (word != forbiddenWord && word.length >= minLength)
            return true;
        return false;
    });
    return result;
};

console.log(filterWords(words,forbiddenWord,minLength));

//exercitiu 1
const varste = [12,32,25,10,56]

const minVarsta=18;
const filterVarsta = (varste,minVarsta)=>{return varste.filter((varsta)=> varsta>minVarsta)}

console.log(filterVarsta(varste,minVarsta));

//2
const squareDimensions = [3,5,12,3,5,3];
const getTotalArea = (squareDimensions)=>{
    return squareDimensions.map((side)=>{
        return side*side;
    }).reduce((prev,current) =>{
        return prev+current;
    }, 0);
};

console.log(getTotalArea(squareDimensions));

//exercitiu 2
const arrayNumere = [1,5,4,67,2,43,53,10]
const divizibilCu = 5;

const getSumOfDivizible = (arrayNumere,divizibilCu)=>{
    return arrayNumere.map((numar)=>{
        if(numar%divizibilCu===0)
            return numar;
        return 0;
    }).reduce((prev,current)=>{
        return prev+current;
    }, 0);
};

console.log(getSumOfDivizible(arrayNumere,divizibilCu));

//3
//functie variadica globala(nr oarecare de parametrii)
const formatString = (s, ...format)=>{
    let modified = s;
    for(let i=0;i<format.length;i++){
        if(modified.indexOf('{'+i+'}') !== -1){
            modified=modified.replace('{'+i+'}',format[i]);
        }
    }
    return modified;
};

console.log(formatString("this is a {0} string and we've {1} it","nice","formatted"));

//exercitiu 3

const formatString3 = (s, ...format)=>{
    let modified = s;

    //daca dadeam liste
    // for (const key in format){
    //     if(modified.indexOf('{'+key+'}')!==-1){
    //         modified=modified.replace('{'+key+'}',format[key]);
    //     }
    // };
    //replace inloc prima apar si expresii regulate
    //for (const key of Object.keys(format)){}
    //for (const [key,value] of Object.entries(format)){}


    if(modified.indexOf('{substantiv}') !== -1){
        modified=modified.replace('{substantiv}' , format[0]);
    };
    if(modified.indexOf('{adjectiv}') !== -1){
        modified=modified.replace('{adjectiv}' , format[1]);
    };
    return modified;
};

console.log(formatString3("un {substantiv} este {adjectiv}","calut","dragut"));


//4
//map metoda pe array
//cream map ca functie globala ce ia doar elementul nu si indexul

const sampleArray=[1,2,3,4,5]

const map = (array, transformation) => {
    const result =[];
    for(const element of array){
        result.push(transformation(element))
    }
    return result
}

console.log(map(sampleArray, (x) => x*2));



//exercitiu 4
//reduce left ca global function

const reduce = (array,update,initialValue) =>{
    let accumulator = initialValue;

    for(const element of array){
        accumulator = update(accumulator,element);
    }

    return accumulator;
}
console.log(reduce([1,2,3,4],(a,e)=>a+e,0))

//5
//array method chaining
const dictionary = ["the","quick","brown","fox","jumps","over","lazy","dog"];

const smapleText = `
    best
    read
    on
    windy
    nights
`
const chechAcrostih = (text,dictionary) =>{
    const candidate= text.split('\n').filter(e => e/* string vid se eval la fals */).map(e=>e.trim()).map(e=>e[0]).join('');
    return dictionary.indexOf(candidate)!==-1;
}

console.log(chechAcrostih(smapleText,dictionary));

//exercitiu 5
const dictionary2 = ["este"];
const smapleText2="javascript este minunat";

// const cenzurareText = (text,dictionar) =>{
//     const textModificat = text.split(' ').filter(e => {
//         for(var i=0;i<dictionar.length;i++){
//             if(e===dictionar[i]&&e.length>1){
//                 var sirNou=e[0]
//                 for(var j=1;j<e.length-1;j++)
//                     sirNou.push('*');
//                 sirNou.push(e[e.length]);
//             }
//         }
//         return e;
//     });



//     return textModificat;
// }


const cenzurareText = (text,dictionar) =>{
    const textModificat = text.split(' ').map(e => {
        for(var i=0;i<=dictionar.length;i++){
            if(e===dictionar[i]&&e.length>1){
                var sirNou=`${e[0]}${'*'.repeat(e.length-2)}${e[e.length-1]}`;
                //console.log(sirNou);
                // for(var j=1;j<e.length-1;j++)
                //     sirNou.push('*');
                // sirNou.push(e[e.length]);
                return sirNou;
            }
        }
        return e;
    }).join(' ');



    return textModificat;
}

console.log(cenzurareText(smapleText2,dictionary2));

//6
const getFilteredObjects = (array,object) =>{
    return array.filter((element)=>{
        let result=false;
        Object.keys(object).forEach((key)=>{
            if(!element[key]||element[key]!==object[key]){
                result=true;
            }
        })
        return result;
    })
}

const laptops =[
    {
        brand:'HP',
        processor:'i5',
        ram:8
    },
    {
        brand:'Lenovo',
        processor:'i7',
        ram:8
    },
    {
        brand:'HP',
        processor:'i5',
        ram:16
    },
    {
        brand:'Acer',
        processor:'i5',
        ram:8
    },
    {
        brand:'Assus',
        processor:'i3',
        ram:32
    }
]

console.log(getFilteredObjects(laptops,{processor:'i5',ram:8}))

//exemplu 6

// const sorteazaDupa = (array,cheie) => {
//     var arrayNou = [];

//     for(element in array){
//         for(var i=0;i<=arrayNou.length;i++){
//             console.log(cheie);
//             console.log(array[cheie]);
//             if(arrayNou[cheie]>=element[cheie]){
//                 //arrayNou[i].push(element);
//                 for(var j=i;j<=arrayNou.length;j++){
//                     arrayNou[j+1]=arrayNou[j];
//                 }
//                 arrayNou[i]=element;

                
//             }
//         }
//     }

//     return arrayNou;
// }

const sorteazaDupa = (array,cheie) => {
    var arrayNou = array;

    const sizeOfArray = arrayNou.length;
    for(var i = 0;i<sizeOfArray-1;i++)
        for(var j = i;j<sizeOfArray;j++)
            if(arrayNou[i][cheie]>arrayNou[j][cheie]){
                var aux = arrayNou[i];
                arrayNou[i]=arrayNou[j];
                arrayNou[j]=aux;
            }


    return arrayNou;
}

console.log(laptops);
console.log(sorteazaDupa(laptops,'processor'))

//7
let arrayNr = [1,2,3,4,5,6]

console.log(arrayNr.reduce((prevVal,currVal,currentIndex)=>{

    var array = prevVal.split(",");
    var a=array[0];
    var b=array[1];

    var sum = parseInt(a)+currVal;
    currentIndex=parseInt(b)+1;

    if((currentIndex+1)===arrayNr.length)
        return sum/(currentIndex+1);

    return sum+","+currentIndex.toString();
},'0,-1'));


//functii de functii
//y combinator: accelerator de firme
//y combinator functie ce creaza recursie intr-un limbaj ce nu are
