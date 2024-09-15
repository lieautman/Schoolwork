export function addNote(content){
    return{
        type:'ADD_NOTE',
        payload:content
    }
}
export function removeNote(content){
    return{
        type:'REMOVE_NOTE',
        payload:content
    }
}