function PropsChild(props){
    const {item} = props;
    return(
        <>
            <div>I am item {item.id} with description {item.description}</div>
        </>
    )

}

export default PropsChild