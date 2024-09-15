import {useSelector,useDispatch,shallowEqual}from 'react-redux'
import {useState}from'react'

import {addNote,removeNote}from'../actions/actions'

const noteListSelector = state=>state.list.notes

function NodeList(props) {
    const notes = useSelector(noteListSelector,shallowEqual)
    const [content,setContent]=useState('')
    const [removeContent,setRemoveContent]=useState('')

    const dispatch=useDispatch()

    return (
        <div>
            <div>
                <h3>List of nodes</h3>
                {
                    notes.map((e,i)=><div key={i}>{e}</div>)
                }
            </div>

            <div>
                <h3>Add a note</h3>
                <input type='text' placeholder='content' onChange={(evt)=>setContent(evt.target.value)}></input>
                <input type='button'value='add' onClick={()=>dispatch(addNote(content))}></input>
            </div>

            <div>
                <h3>Remove a note</h3>
                <input type='text' placeholder='content' onChange={(evt)=>setRemoveContent(evt.target.value)}></input>
                <input type='button'value='remove' onClick={()=>dispatch(removeNote(removeContent))}></input>
            </div>

        </div>
    );
  }
  
  export default NodeList;
  