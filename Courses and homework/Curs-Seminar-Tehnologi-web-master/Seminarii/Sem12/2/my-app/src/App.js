import{BrowserRouter,Routes,Route}from 'react-router-dom'
import Home from'./components/Home'
import Tasks from'./components/Tasks'
import About from'./components/About'
import NotFound from'./components/NotFound'


function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home></Home>}></Route>
        <Route path='/tasks' element={<Tasks></Tasks>}></Route>
        <Route path='/about' element={<About></About>}></Route>
        <Route path='/tasks/:id' element={<Tasks></Tasks>}></Route>
        <Route path='*' element={<NotFound></NotFound>}></Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
