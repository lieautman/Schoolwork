//diferente arrow function si function in inter obiectelor
let o = {
    name: 'jim',
    age: 22
}

o.printMe = function(){
    const that=this
    //in print me avem this
    const f = function(){
        //in f nu avem this, ci il ia spatiu de nume global.
        //this este unbound
        //functia f isi ia this din contextul in care a fost invocata


        //workaround1


        console.log(that.name+' '+that.age)
    }
    f()
}

o.printMe()


o.printMe1 = function(){
    //in print me avem this
    const f = function(){
        //in f nu avem this, ci il ia spatiu de nume global.
        //this este unbound
        //functia f isi ia this din contextul in care a fost invocata


        //workaround2
        console.log(this.name+' '+this.age)
    }.bind(this)
    f()
}
o.printMe1()

//workaround3
o.printMe2 = ()=>{
    const f = function(){
        //in f nu avem this, ci il ia spatiu de nume global.
        //this este unbound
        //functia f isi ia this din contextul in care a fost invocata


        //workaround1


        console.log(this.name+' '+this.age)
    }
    f()
}
o.printMe2()

//sau defineProperty()
//pot crea metainformatii despre un camp
//ex writable:flase(const)
//pt a nu putea modif struct unui obiect se fol .seal()
//daca le vreau si sealed si constante se fol .freeze()



//vom face memoizare abstracta

//programare asincrona