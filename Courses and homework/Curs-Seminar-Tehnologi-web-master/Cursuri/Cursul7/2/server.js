const express = require('express')

const app = express()

//putem scrie un api 
//sau o aplicatie clasica => formular catre server (serverul va avea un templating agent)
//cel mai simplu este un html cu markere(serverul citeste asta si inloc markerele)
//in multe cazuri va treb sa mentinem o stare prin coockies sau sesiuni

//

app.get('/',(req,res)=>{
   res.status(200).send('ok')
})

app.listen(8080)