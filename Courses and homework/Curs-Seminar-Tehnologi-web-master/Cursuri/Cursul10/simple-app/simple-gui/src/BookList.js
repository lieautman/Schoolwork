import{useEffect, useState}from'react'
import store from "./BookStore";

function BookList(){
    const [books,setBooks]=useState([])

    useEffect(()=>{
        store.getBooks([]);
        store.emitter.addListener('GET_BOOK_SUCCESS',()=>{
            setBooks(store.data)
        })
    },[])
    const addBook =(book)=>{
        store.addBooks(book);
    }

    return (
        <div>
            <h1>
                {
                    books.map(e=> <div key={e.id}>e.title</div>)
                }
            </h1>
            <BookAddForm onAdd={addBook}></BookAddForm>
        </div>
    )
}
export default BookList