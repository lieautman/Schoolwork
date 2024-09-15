//var clasica
function ParentType(a){
    this.a=a
    this.doParent = function(){
        console.log('doing parent stull with a '+this.a)
    }
}
function ChileType(b){
    this.b=b
    this.doChild = function(){
        console.log('doing child stull with a '+this.b)
    } 
}
ChileType.prototype = new ParentType(3)
let o1=new ChileType(8)
o1.doChild(1)
o1.doParent(2)