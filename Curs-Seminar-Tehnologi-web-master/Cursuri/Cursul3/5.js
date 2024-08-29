//var moderna
class ParentType {
    constructor(a){
        this.a=a
    }
    doParent(){
        console.log('doing parent stull with a '+this.a)
    }
}

class ChildType extends ParentType{
    constructor(a,b){
        super(a)
        this.b=b
    }
    doChild(){
        console.log('doing child stull with a '+this.b)
    }
}

const c0 = new ChildType(1,2)
c0.doChild()
c0.doParent()

//pot sa modific comport lui c0?
//c0.doNewStuff()

//putem adauga functia la runtime?
//c0.doNewStuff = 
//vreau sa modific toate obiectele nu doar c0
ChildType.prototype.doNewStuff = function(){
    console.log('doing new stuff')
}
c0.doNewStuff()

//diferente arrow function si function in inter obiectelor
console.log(c0)//in browser era {obiect:obiect}
console.log(c0.doParent)
console.log(c0.doParent.length)//functiile sunt si ele obiecte

let f = c0.doParent

//f() //nu e definit this
//functia s-a deconectat de la obiect

//functia este un obiect ce are o metoda call si apply
//functiile se pot reconecta

f.call(c0)//temporar (f()nu va merge)
let f1 = f.bind(c0)//definitiv
f1()