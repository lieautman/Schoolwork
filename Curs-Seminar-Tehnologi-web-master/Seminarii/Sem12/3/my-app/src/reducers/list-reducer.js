const INITIAL_STATE={
    notes:[]
}
export default function(state=INITIAL_STATE,action){
    switch(action.type){
        case 'ADD_NOTE':
            return {...state,notes:[...state.notes,action.payload]}
        case 'REMOVE_NOTE':{
            let stateNew=[...state.notes];
            for(let i=0;i<stateNew.length;i++){
                if(stateNew[i]===action.payload){
                    stateNew.splice(i,1);
                    i--;
                }
            }
            return {...state,notes:[...stateNew]}
        }
        default:
            return state
    }
}