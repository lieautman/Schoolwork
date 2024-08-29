const express = require('express')
const app = express()
//pt post
const bodyParser = require('body-parser')

const widgetRouter = require('./widget-router')

//pt a-l aceesa in alte fis, cream o stare globala volatila
//poate fi accesat din app.locals.widgets
app.locals.widgets = [{
    id:1,
    description:'some widget'
}]


//middleware-ul meu
app.use((req,res,next)=>{
    //modifica req sau res si preda controlul mai departe
    console.log('Requested'+req.url)
    next()
})


//aplicam middleware
app.use(bodyParser.json()) // pune in body un JSON cu ce am parsat

app.use('./widger-api', widgetRouter)



const pingMiddleware = (req,res,next)=>{
    console.log('i have been pinged')
    next()
}


app.use('/ping', pingMiddleware,(req,res)=>{
    res.status(200).json({message:'pong'})
})


app.get('/error', (req,res,next)=>{
    try{
        if(req.query.trigger ==='on'){
            throw new Error('some error')
        }
        else{
            res.status(200).json({message:'no error'})
        }
    }
    catch(err){
        //console.warn(err)
        //res.status(500).json({message:'some error'})
        next(err)
    }
    //vrem ca logica asta sa fie intr-un loc specific
    //se duc la cel de mai jos
})

app.use((err,req,res,next)=>{
    console.warn(err)
    res.status(500).json({message:'some error'})
})

app.listen(8080)