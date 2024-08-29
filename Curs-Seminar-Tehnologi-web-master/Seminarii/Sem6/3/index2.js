let firstChild = document.querySelector("tbody tr:first-child")
let lastChild = document.querySelector("tbody tr:last-child")
let oddCollection = document.querySelectorAll("tbody tr:nth-child(odd)")

if(oddCollection&&oddCollection.length>0){
    for(let item of oddCollection){
        item.bgColor="pink"
    }
}


firstChild.bgColor="blue";

lastChild.bgColor="green";


