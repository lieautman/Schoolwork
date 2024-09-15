import {useState} from 'react';
import UpdateChild from './UpdateChild';

function UpdateParent(props){
    
    const [id,setId]=useState(1)

    const handleBlur = (evt)=>{
        setId(evt.target.value)
    }
    return(
        <>
            <div>
                <input type='text' />
            </div>
            <div>
                <UpdateChild item={id}></UpdateChild>
            </div>
        </>
    )

}

export default UpdateParent