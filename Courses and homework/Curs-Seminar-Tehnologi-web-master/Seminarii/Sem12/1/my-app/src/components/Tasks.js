import { useParams } from "react-router";

const Tasks=()=>{
    const {id} =useParams();
    return(
        <>
            <p>Task</p>
            <p>Id:{id}</p>
        </>
    )
}

export default Tasks;