const SERVER = 'http://localhost:8080'

export function getNotes(){
    return {
        type:'GET_NOTES',
        payload:async()=>{
            const response=await fetch(`${SERVER}/notes`)
            const data = await response.json()
            return data
        }
    }
}
export function removeNote(id){
    return {
        type:'REMOVE_NOTES',
        payload:async()=>{
            const response=await fetch(`${SERVER}/notes/${id}`,{
                method:'DELETE',
                mode: 'cors',
                headers: {
                    'Content-Type': 'application/json'
                    // 'Content-Type': 'application/x-www-form-urlencoded',
                  },
            })
            const data = await response.json()
            return data
        }
    }
}