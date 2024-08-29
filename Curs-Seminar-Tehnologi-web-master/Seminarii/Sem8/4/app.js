//de corectat
const express = require('express');
const app = express();
const port = 3000;

const Book=require('./Book');

//pt a nu fol body parser (4 ex)
app.use(express.urlencoded({extended:true}));
app.use(express.json());

const bookRouter = express.Router();
app.use('/api',bookRouter);

app.get('/', (req,res)=>{
    res.send('Welcome to my API');
});

let books =[new Book(1,"Dune","sf","Frank  Harbert"),
            new Book(2,"Dune2","sf2","Frank  Harbert2"),
            new Book(3,"Dune3","sf3","Frank  Harbert2")];

bookRouter.route('/books')
    .get((req,res)=>{
        let filteredBooks = [];
        if(req.query.genre){
            filteredBooks=books.filter(x=>x.genre==req.query.genre);
        }
        else{
            filteredBooks=books;
        }
        res.json(filteredBooks);
    })
    .post((req,res)=>{
        let newBook = new Book(req.body.id,
                            req.body.name, 
                            req.body.genre, 
                            req.body.author);

        books.push(newBook);
        console.log(books);
        return res.json(newBook);
    });

bookRouter.route('/books/:bookId')
    .put((req,res)=>{
        bookModif = books.find(x=>x.id==parseInt(req.params.bookId));

        bookModif.name = req.body.name;
        bookModif.genre = req.body.genre;
        bookModif.author = req.body.author;

        return res.json(bookModif);
    });











app.listen(port,()=>{
    console.log('Running on port'+port);
});



//in postman adaug content type header application/json