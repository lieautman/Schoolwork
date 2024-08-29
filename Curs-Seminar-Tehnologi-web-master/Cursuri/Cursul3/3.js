class Person {
    //poate fi scris asa dar ce se intampla este acelas lucru ca un 2.js
    constructor(name,age){
        this.name=name
        this.age=age
    }

    printMe () {
        console.log(`${this.name} is ${this.age} old.`)
    }
}

let p0 = new Person('jim',22)
p0.printMe()

let p1 = new Person('jane',25)
p1.printMe()

console.log(p0)

//p0->object->null
//cauta proprietatea to string in ordinea de mai sus

//compozitie si mostenire
//mostenire in 2 feluri
//felul traditional nu este foarte prietenos

