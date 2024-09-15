const INITIAL_STATE = {
    page:'Login',
    id:'',
    username:'',
    type:'',
    token:'',
    error:null
}

export default function reducer (state = INITIAL_STATE,action){
    switch(action.type){
        case 'Login':
            return {...state,page:'Login',id:'',username:'',type:'',token:''}
        case 'Signup':
            return {...state,page:'Signup'}
        case 'Main':
            return {...state,page:'Main',id:action.payload.id,username:action.payload.username,type:action.payload.type,token:action.payload.token}
        default:
            return {...state}
    }
}