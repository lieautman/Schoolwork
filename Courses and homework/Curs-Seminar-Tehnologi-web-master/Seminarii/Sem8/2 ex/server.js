const express = require('express');
const app=express();
const port = 3000;
const Book = require('./Book');

let books =[new Book(1,"Dune2","sf2","Frank  Harbert2"),
            new Book(2,"Adune","sf","Frank  Harbert"),
            new Book(3,"Dune3","sf3","Frank  Harbert2")];
app.get('/books',(req,res)=>{
    let filteredBooks = [];
    if(req.query.genre){
        filteredBooks=books.filter(x=>x.genre==req.query.genre);
    }
    else if(req.query.sortField){
        const sortField = req.query.sortField;
        const sortOrder = req.query.sortOrder?parseInt(req.query.sortOrder):1;
        filteredBooks=books.sort((first,second)=>{
            if(first[sortField]===second[sortField]){
                return 0;
            }
            else if(first[sortField]>second[sortField]){
                return 1*sortOrder;
            }
            else
                return -1*sortOrder;
        });
    }
    else{
        filteredBooks=books;
    }

    res.status(200).json(filteredBooks);
})

app.listen(port,()=>{
    console.log('Running on port'+port);
})