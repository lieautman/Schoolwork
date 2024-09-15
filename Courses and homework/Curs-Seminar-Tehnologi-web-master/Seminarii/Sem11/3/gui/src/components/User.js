import './User.css'
import { useState } from 'react'
import RegularUser from './RegularUser'
import PowerUser from './PowerUser'

function User (props) {
  const { item } = props
  const { itemDetailsSet } = props

  const showDetails=()=>{
    itemDetailsSet(item)
  }

  return (
    <div className='user' onClick={showDetails}>
      {
        item.type === 'regular-user'
          ? (
            <RegularUser item={item}  />
            )
          : (
            <PowerUser item={item} />
            )
      }
    </div>
  )
}

export default User
