const express = require('express')
const bodyParser = require('body-parser')
const {v4:uuidv4} = require('uuid')
const NodeCache = require('node-cache')
//pt compresare
const compression = require('compression')


const pasteCache = new NodeCache({stdTTl:1800,checkperiod:120})


const app=express()

app.set('view engine','ejs')

app.use(compression())
app.use(bodyParser.urlencoded({extended:true}))

app.get('/',(req,res)=>{
    res.render('pages/index')
})

app.post('/paste',(req,res)=>{
    const key = uuidv4()
    pasteCache.set(key,req.body.content)
    res.redirect(`pastes/${key}`)
})

app.get('/paste/:id',(req,res)=>{
    const paste = pasteCache.get((req.params.id))
    if(paste){
        res.render('pages/paste',{paste,key})
    }
    else{
        res.render('pages/404')
    }
})

app.get('/paste/:raw/:id',(req,res)=>{
    const paste = pasteCache.get((req.params.id))
    if(paste){
        res.status(200).set('Content-Type','text/plain').send(paste)
    }
    else{
        res.render('pages/404')
    }
})

app.listen(8080)