import {useState,useEffect} from 'react'

function UpdateChild(props){

    const {item} = props;
    const [ content, setContent] = useState({})
    
    const getPost = async (id)=>{
        const response = await fetch(`https://jsonplaceholder.typicode.com/posts/${id}`);
        const data = await response.json;
        setContent(data);
    }
    

    return(
        <>
            <div>I am item {item.id} with description {content.title}</div>
        </>
    )
}

export default UpdateChild