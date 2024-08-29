const o ={
    name:'jim',
    age:22,
    printMe:function(){
        console.log(`${this.name} is ${this.age} old.`)
    }
}
//methon invocation
o.printMe()
console.log(o.__proto__)


