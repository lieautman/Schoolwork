const axios=require('axios')

axios('http://ase.ro')
    .then((response)=>{
        console.warn(response.data)
    })
    .catch((error)=>{
        console.warn(error)
    })

    //pt fetch trebuie importat, este similar si textul se afla in response.text