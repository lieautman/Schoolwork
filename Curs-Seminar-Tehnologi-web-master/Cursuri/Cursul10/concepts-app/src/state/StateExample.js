import{useState} from 'react'

function StateExample(){
    const [counter,setCounter]=useState(1);

    const handleClick=(evt)=>{
        setCounter(counter+1);
    }


    return(
        <>
            <h1>
                state of counter is: {counter}
            </h1>
            <div>
                <input type='button' value='+' onClick={handleClick}></input>
            </div>
        </>
    )

}

export default StateExample