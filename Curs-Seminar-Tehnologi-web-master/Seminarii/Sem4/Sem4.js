//1
console.log(`#############ex1###################`)
class Stream{
    #value;
    #nextValue;
    static #count=0;
    constructor(value,nextValue){
        this.#value=value;
        this.#nextValue=nextValue;
        Stream.#count++;
    }
    get value(){
        return this.#value;
    }
    get next(){
        this.#value = this.#nextValue(this.#value);
        return this.#value;
    }
    static get count(){
        return Stream.#count;
    }
}

class ConstantStream extends Stream{
    constructor(value){
        super(value, value=>value);
    }
}
class NextIntegerStream extends Stream{
    constructor(){
        super(0, value=>value+1)
    }
}

const constant = new ConstantStream(1);
const nextInteger = new NextIntegerStream();
for(let i =0;i<10;i++){
    console.log(`constant[${i}]=${constant.next}`);
    console.log(`nextInteger[${i}]=${nextInteger.next}`);
}
console.log(Stream.count);
//exercitiul 1
class SirCrescator{
    #valoareInitiala;
    #nextValue;
    constructor(valoareInitiala){
        this.#valoareInitiala=valoareInitiala;
        this.#nextValue=()=>{if(this.#valoareInitiala%2===1) return this.#valoareInitiala+1;else return this.#valoareInitiala+2;};
    }
    get valoareInitiala(){
        return this.#valoareInitiala;
    }
    get next(){
        this.#valoareInitiala = this.#nextValue(this.#valoareInitiala);
        return this.#valoareInitiala;
    }
}

const sirCrescator1 = new SirCrescator(1);
console.log(sirCrescator1.next)
console.log(sirCrescator1.next)

//2
console.log(`#############ex2###################`)
class Robot{
    constructor(name){
        this.name =name;
    }
    move(){
        console.log(`${this.name}is moving`)
    }
}
const r0=new Robot(`some robot`)
r0.move()

class Weapon {
    constructor(description){
        this.description=description
    }

    fire(){
        console.log(`${this.description} is fireing`)
    }
}
const w0=new Weapon(`pew pew laser`)
w0.fire()

class CombatRobot extends Robot{
    constructor(name){
        super(name)
        this.weapons = []
    }
    addWeapon(w){
        this.weapons.push(w)
    }
    fire(){
        console.log(`fireing all weapons`)
        for(const w of this.weapons){
            w.fire()
        }
    }
}
const r1=new CombatRobot(`some combat robot`)
r1.addWeapon(w0)
r1.fire()

Robot.prototype.fly = function(){
    console.log(`${this.name} is flying`)
}
r1.fly()

//exercitiul 2

class Software{
    constructor(nume){
        this.nume=nume;
    }
    run(){
        console.log(`${this.nume} ruleaza`);
    }
}
class Plugin1{
    constructor(nume){
        this.nume=nume
    }
    descrie(){
        console.log(this.nume)
    }
}
class Browser extends Software{
    constructor(nume){
        super(nume)
        this.plugin =[]
    }
    adaugaPlugin(p){
        this.plugin.push(p)
    }
}
const b1 = new Browser(`Chrome`)
b1.run()
const p1=new Plugin1(`addBlock`)
b1.adaugaPlugin(p1)
b1.plugin[0].descrie()


//3
console.log(`#############ex3###################`)
//caching
//treb ca fct sa fie returnata din alta functie pentru a avea closure
function fibgen(){
    const cache=[1, 1]
    const fib = (index)=>{
        if(index<cache.length){
            console.log(`found ${index}`)
            return cache[index]
        }
        else{
            console.log(`calculated ${index}`)
            cache [index]=fib(index-1)+fib(index-2)
            return cache[index]
        }
    }
    return fib
}
const fib = fibgen()

console.log(fib(1))
console.log(fib(5))
console.log(fib(3))

//exercitiul 3
//intrebare: pot sa am 2 indici pt cache?
console.log("###################")
function fctExponentiereGen(){
    const cache=[]
    const number=5
    const fctExponentiere = (index)=>{
        let ok=0
        let indexCautat=0
        for(let i=0;i<cache.length;i++){
            if(cache.indexOf(cache[i])){
                indexCautat=cache.indexOf(cache[i])
                ok=1
            }
        }
        if(ok===1){
            console.log(`found ${index}`)
            return cache[index-1]
        }
        else{
            console.log(`calculated ${index}`)
            let resultTemp=1;
            for(let i=0;i<index;i++){
                resultTemp=resultTemp*5;
                cache [i]=resultTemp;
            }
            cache [index]=resultTemp
            return cache[index]
        }
    }
    return fctExponentiere
}
const fctExponentiere = fctExponentiereGen()

console.log(fctExponentiere(1))
console.log(fctExponentiere(3))
console.log(fctExponentiere(2))

//4
console.log("###########ex4########")
String.prototype.capitalizeWords = function(){
    return this.replace(/\b[a-z]/g,match=>match.toUpperCase())
}
console.log("this words will be capitalized".capitalizeWords());

//exercitiul 4
//intrebare: este ok?
Number.prototype.times = function(functie){
    for(let i=0;i<this;i++){
        functie();
    }
}
let trei=3
trei.times(()=>console.log("am facut-o"))

//5
console.log("###########ex5########")
const orderCoffee = (type)=>{
    const types={
        SPECIAL:'SPECIAL',
        REGULAR:'REGULAR'
    }
    if(Object.values(types).indexOf(type)===-1){
        throw new Error('coffee error')
    }
    else{
        console.log(`preparing ${type} coffee`)
    }
}

try{
    orderCoffee('REGULAR')
    //orderCoffee('SWEET_COFFEE')
}
catch(err){
    console.warn(err)
}
//exercitiul 5
function increaseSalary(arraySalarii, procent) {
    if(typeof(procent)!=typeof(2)){
        throw new Error('procent error')
    }
    else{ 
        ok=0
        for(let i=0;i<arraySalarii.length;i++){
            if(typeof(arraySalarii[i])!=typeof(2)){
                ok=1
            }
        }


        if(typeof(arraySalarii)!=typeof([1, 2])||ok===1){
            throw new Error('array error')
        }
        else{
            for(elem in arraySalarii){
                arraySalarii[elem]=arraySalarii[elem]*(procent+100)/100
            }
            return arraySalarii
        }
    }
}
try{
    console.log(increaseSalary([1,2],10))
}
catch(err){
    console.warn(err)
}

//6
//part1
console.log("###########ex6.1########")
const fetch = require('node-fetch');

function getObjectFromUrl(url){
    return new Promise(resolve => {
        fetch(url)
        .then(response =>response.text())
        //text este tot asincrona asa ca deserializam cu JSON.prase
        .then(text=>resolve(JSON.parse(text)))
        
    });
}
function getCountryBounds(country){
    return new Promise(resolve=>{
        getObjectFromUrl(`https://nominatim.openstreetmap.org/search?country=${country}&format=json`)
        .then(object=>resolve({
            minLatitude:object[0].boundingbox[0],
            maxLatitude:object[0].boundingbox[1],
            minLongitude:object[0].boundingbox[2],
            maxLongitude:object[0].boundingbox[3]
        }))
    });
}

function main() {
    getCountryBounds('Romania').then(bounds=>console.log(bounds))
}
main()
//6
//part2
async function getObjectFromUrl1(url){
    const response = await fetch(url);
    const text =await response.text();
    return JSON.parse(text);
}
async function getCountryBounds1(country){
    const object =await getObjectFromUrl1(`https://nominatim.openstreetmap.org/search?country=${country}&format=json`)
    //console.log(object)
    return{
        minLatitude:object[0].boundingbox[0],
        maxLatitude:object[0].boundingbox[1],
        minLongitude:object[0].boundingbox[2],
        maxLongitude:object[0].boundingbox[3]
    }
}

async function main1() {
    await getCountryBounds1('Romania').then(bounds=>console.log(bounds))
}
main1()
//exercitiul 6
async function getObjectFromUrl2(url){
    const response = await fetch(url);
    const text = await response.text();
    return JSON.parse(text);
}

async function main2() {
    //luam aeroporturile
    const url=`http://api.aviationstack.com/v1/airports?access_key=1f3a225e54cf872fac52ea1b62626e7d`
    const aeroporturi = await getObjectFromUrl2(url)
    const aeroporturiData = aeroporturi.data;
    const aeroporturiPagination = aeroporturi.pagination;
    //console.log(aeroporturiData)
    //console.log(aeroporturiData.length)





    //luam numele aeroporturilor
    //am adaugat unul care exista deja ca sa vad daca merge. lista este comentata la randul 256
    const numeAeroporturiCautate=['Beijing Capital International']
    for(let i=0;i<aeroporturiData.length;i++){
        //console.log(aeroporturiData[i])
        if(aeroporturiData[i].latitude>43.618682&&aeroporturiData[i].latitude<100&&aeroporturiData[i].latitude>20.2619955&&aeroporturiData[i].latitude<100){
            //ii dau o marime mai mare ca sa am date
            //puteam sa pun si marginile europei (cred ca am pus N-E romaniei deci hei, date despre Russia :) )
            //console.log(aeroporturiData[i])
            numeAeroporturiCautate.push(aeroporturiData[i].airport_name)
        }
    }

    // //avem nevoie si de zboruri
    // //incerc sa gasesc zborurile care au aeroportul de aterizare in "Romania"
    const url1=`http://api.aviationstack.com/v1/flights?access_key=1f3a225e54cf872fac52ea1b62626e7d`
    const zboruri = await getObjectFromUrl2(url1)
    //console.log(zboruri)

    for(let i=0;i<zboruri.data.length;i++){
        //daca arrival-ul este in aeroporturi cautate, il logam
        //console.log(zboruri.data[i].arrival.airport)
        if(numeAeroporturiCautate.includes(zboruri.data[i].arrival.airport)){
            console.log(zboruri.data[i]);
        }
    }
    //console.log(numeAeroporturiCautate)


}
main2()

//lista avioanelor deasupra romaniei