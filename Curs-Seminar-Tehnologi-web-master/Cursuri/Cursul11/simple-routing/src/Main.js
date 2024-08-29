import {useParams} from 'react-router-dom'

function Main(props){
    const params = useParams()

    return(
        <div>
            I am the item component for {params.item}
        </div>
    )
}

export default Main