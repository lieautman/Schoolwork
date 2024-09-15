import Login from "./Login/Login"
import Signup from "./Signup/Signup"
import Main from "./MainApp/Main"

//iau starea redux
import {useSelector,shallowEqual}from 'react-redux'

//var de selector
const pageSelector=state=>state.main.page

function App() {
  //var din store
  const page=useSelector(pageSelector,shallowEqual)


  //schimba valoare dupa valoare variabilei page
  function chooseDisplay(page){
    switch (page){
      case 'Login':
        return <Login></Login>
      case 'Main':
        return <Main></Main>
      case 'Signup':
        return <Signup></Signup>
      default:
        return <Login></Login>
    }
  }


  return (
    <>
      {chooseDisplay(page)}
    </>
  );

}

export default App;