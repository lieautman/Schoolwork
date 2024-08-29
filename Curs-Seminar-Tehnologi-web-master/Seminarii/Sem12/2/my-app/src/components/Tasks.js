import {useReducer} from 'react'

const initialState = {count:0,history:[0]}

const reducer = (state,action)=>{
    switch(action.type){
        case 'increase':
            return{
                count:state.count+1,
                history:[...state.history,state.count+1],
            };
        case 'decrease':
            return{
                count:state.count-1,
                history:[...state.history,state.count-1],
            };
        case 'reset':
            return{
                count:state.history[0],
                history:[0],
            };
        default:
            throw Error();
    }
}

const Tasks=()=>{

    const [state,dispatch] = useReducer(reducer,initialState);
    console.log(state);

    return(
        <>
            <p>Task, count:{state.count}, history:{state.history.join(', ')}</p>
            <button onClick={()=>{
                dispatch({type:'increase'})
            }}>Increase</button>
            <button onClick={()=>{
                dispatch({type:'decrease'})
            }}>Decrease</button>
                        <button onClick={()=>{
                dispatch({type:'reset'})
            }}>Reset</button>
        </>
    )
}

export default Tasks;