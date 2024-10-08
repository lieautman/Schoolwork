import {useState}from 'react'
//import './UserForm.css'


function UserFrom (props){
    const {onAdd}=props
    const [username,setUsername]=useState('')
    const [fullName,setFullName]=useState('')
    const [type,setType]=useState('')

    const options = [{
        label:'regular',
        value:'regular-user'
    },{
        label:'power',
        value:'power-user'
    }]

    const addUser=()=>{
        onAdd({
            username,
            fullName,
            type
        });
    }

    return(
        <div className='user-form'>
            <div className='username'>
                <input type='text' placeholder='username' onChange={(evt)=>setUsername(evt.target.value)}></input>
            </div>
            <div className='fullName'>
                <input type='text' placeholder='fullName' onChange={(evt)=>setFullName(evt.target.value)}></input>
            </div>
            <div className='type'>
                <select onChange={(evt)=>setType(evt.target.value)}>
                    {
                        options.map((o)=><option key={o.value} value={o.value}>{o.label}</option>)
                    }
                </select>
            </div>
            <div className='add'>
                <input type='button' value='add' onClick={addUser}></input>
            </div>
        </div>
    )
}
export default UserFrom