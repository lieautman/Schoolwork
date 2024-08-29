const express = require('express');
const app = express();
const port = 3000;

const Book=require('./Book');


app.get('/', (req,res)=>{
    res.send('Welcome to my API');
});

let books =[new Book(1,"Dune","sf","Frank  Harbert"),
            new Book(2,"Dune2","sf2","Frank  Harbert2"),
            new Book(3,"Dune3","sf3","Frank  Harbert2")];
app.get('/books',(req,res)=>{
    let filteredBooks = [];
    if(req.query.genre){
        filteredBooks=books.filter(x=>x.genre==req.query.genre);
    }
    else{
        filteredBooks=books;
    }
    res.json(filteredBooks);
})

app.listen(port,()=>{
    console.log('Running on port'+port);
})