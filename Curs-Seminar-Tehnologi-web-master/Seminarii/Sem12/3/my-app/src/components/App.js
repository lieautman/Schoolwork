import NodeList from './NodeList'

import {useSelector,useDispatch,shallowEqual}from 'react-redux'
import {useState}from'react'

import {addNote,removeNote}from'../actions/actions'

const noteListSelector = state=>state.list.notes

function App() {
  const notes = useSelector(noteListSelector,shallowEqual)
  const [removeContent,setRemoveContent]=useState('')

  const dispatch=useDispatch()


  return (
    <div>
      I am the app
      <div>
        <h3>Remove a note</h3>
        <input type='text' placeholder='content' onChange={(evt)=>setRemoveContent(evt.target.value)}></input>
        <input type='button'value='remove' onClick={()=>dispatch(removeNote(removeContent))}></input>
      </div>
      <NodeList></NodeList>
    </div>
  );
}

export default App;
