const express = require('express')

const router=express.Router()

//read
//ex parametrii: get /widgets?sort=description; ?filter=something; ?format=json; ?simplified=1
router.get('/widgets', (req,res)=>{
    if(parseInt(req.query.simplifier) ===1){
        res.status(200).json(res.app.locals.widgets.map(e=>e.description))
    }
    else{
        res.status(200).json(res.app.locals.widgets) // aici se serializeaza la string si content type este aplication json
        //send(text plain)
    }
})
router.get('/widgets/:id', (req,res)=>{
    const id = parseInt(req.params.id)
    const widget = res.app.locals.widgets.find(e=>e.id===id)

    if(widget){

        res.status(200).json(widget)
    }
    else{
        res.status(404).json({message:'not found'})
    }
})


//create
router.post('/widgets', (req,res)=>{
    //res cautata este in corpul requestului
    const widget = req.body //este gol fara middleware-ul din body-parser

    res.app.locals.widgets.push(widget)
    res.status(201).json({message:'created'})
})
router.put('/widgets/:id', (req,res)=>{
    const id = parseInt(req.params.id)
    const widgetIndex = res.app.locals.widgets.findIndex(e=>e.id===id)

    if(widgetIndex!==-1){
        res.app.locals.widgets[widgetIndex].description = req.body.description
        res.status(202).json({message:'accepted'})
    }
    else{
        res.status(404).json({message:'not found'})
    }
})
//app.patch


//delete
router.delete('/widgets/:id', (req,res)=>{
    const id = parseInt(req.params.id)
    const widgetIndex = res.app.locals.widgets.findIndex(e=>e.id===id)

    if(widgetIndex!==-1){
        res.app.locals.widgets.splice(widgetIndex)
        res.status(202).json({message:'accepted'})
    }
    else{
        res.status(404).json({message:'not found'})
    }
})


module.exports = router
//vrem sa le grupam separat