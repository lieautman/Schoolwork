

function App() {
  return (
    <div className="App">
    </div>
  );
}

export default App;
//context este pt teme si chestii
//reducer actualizeaza mai multe componente ce fol aceleasi piese de stare
//cum se implementeaza un hook?
//se fol use guarded state(initial, min ,max)
//se retine cu starea de react
//se agata de o componenta





//redux trebuie instalat cu: npm i redux react-redux
//redux ne ajuta sa managuim starea

//pt un element global avem un reducer pt asta

//const bookListSelector = state => state.book.bookList (redes cand se modif bookList)
//const bookList = useSelector(bookListSelector,shallowEqual)
//const dispatch = useDispatch()
//useEffect(()=>{
//  dispatch(bookAction.getBooks())
//},[dispatch])



//folosire prime react
//ajuta la templetizare