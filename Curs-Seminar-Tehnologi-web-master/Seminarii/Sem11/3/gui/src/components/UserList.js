import { useEffect, useState } from 'react'
import User from './User'
import UserForm from './UserForm'
import UserDetail from './UserDetail'
import './UserList.css'

const SERVER = 'http://localhost:8080'

function UserList (props) {
  const [users, setUsers] = useState([])
  const [userShow,setUserShow]=useState()

  const getUsers = async () => {
    const response = await fetch(`${SERVER}/users`)
    const data = await response.json()
    setUsers(data)
  }

  const addUser = async(user)=>{
    await fetch(`${SERVER}/users`,{
      method:'post',
      headers:{
        'Content-Type':'application/json'
      },
      body:JSON.stringify(user)
    })
    getUsers()
  }

  useEffect(() => {
    getUsers()
  }, [])


  return (
    <div className='user-view'>
      <div className='user-list'>
        {
          users.map(e => <User key={e.id} item={e} itemDetails={userShow} itemDetailsSet={setUserShow}/>)
        }
        <UserForm onAdd={addUser}></UserForm>
      </div>
      <div className='user-details'>
        <UserDetail itemDetails={userShow}></UserDetail>
      </div>
    </div>
  )
}

export default UserList
