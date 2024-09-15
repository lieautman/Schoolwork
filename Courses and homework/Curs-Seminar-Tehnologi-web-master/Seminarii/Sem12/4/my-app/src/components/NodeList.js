import {useSelector,useDispatch,shallowEqual}from 'react-redux'
import {useEffect,useState}from'react'

import {getNotes,removeNote}from'../actions/actions'

const noteListSelector = state=>state.list.notes

function NodeList(props) {
    const notes = useSelector(noteListSelector,shallowEqual)

    const dispatch=useDispatch()

    useEffect(()=>{
        dispatch(getNotes())
    },[dispatch])


    const [removeContent,setRemoveContent]=useState('')

    return (
        <div>
            <div>
                <h3>List of nodes</h3>
                {
                    notes.map((e,i)=><div key={e.id}>{e.content}</div>)
                }
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
  