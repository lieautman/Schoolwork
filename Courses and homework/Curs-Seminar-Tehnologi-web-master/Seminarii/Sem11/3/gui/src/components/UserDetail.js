import {useState}from 'react'

function UserDetail (props){
    const { itemDetails } = props
    console.log(itemDetails)
    return (
        <div>
            <p>{(itemDetails)?itemDetails.username:'Not selected!'}</p>
            <p>{(itemDetails)?itemDetails.fullName:'Not selected!'}</p>
            <p>{(itemDetails)?itemDetails.createdAt:'Not selected!'}</p>
            <p>{(itemDetails)?itemDetails.updatedAt:'Not selected!'}</p>
        </div>
    );
}

export default UserDetail