const express = require('express');
const bodyParser = require('body-parser');
const Sequelize = require('sequelize');

const sequelize = new Sequelize({
    dialect:'sqlite',
    storage:'sample.db',
    define:{
        timestamps:false
    }
});


const Book = sequelize.define('book',{
    title:Sequelize.STRING,
    content:Sequelize.TEXT
})

const app=express();

app.use(bodyParser.json());//pt post pt req.body


app.get('/sync',async(req,res)=>{
    try{
        await sequelize.sync({force:true});
    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})

//oper sincrone in sqlite
app.get('/books',async(req,res)=>{
    try{
        const books = await Book.findAll();
        res.status(200).json(books);
    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})
app.post('/books',async(req,res)=>{
    try{
        await Book.create(req.body);
        res.status(201).json({message:'created'});
    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})

app.get('/books/:bid',async(req,res)=>{
    try{

    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})
app.put('/books/:bid',async(req,res)=>{
    try{
        const book = await Book.findByPk(req.params.bid);
        if(book){
            await book.update(req.body,{fields:['title','content']});
            res.status(201).json({message:'carte modificata'});
        }
        else{
            res.status(404).json({message:'nu s-a gasit cartea'});
        }
    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})
app.delete('/books/:bid',async(req,res)=>{
    try{
        const book = await Book.findByPk(req.params.bid);
        if(book){
            await book.delete();
            res.status(201).json({message:'carte modificata'});
        }
        else{
            res.status(404).json({message:'nu s-a gasit cartea'});
        }
    }
    catch(err){
        console.warn(err);
        res.status(500).json({message:'some error occured'});
    }
})




app.listen(8080);