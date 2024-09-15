const express = require('express')
const cors = require('cors')

const Sequelize = require('sequelize')

const sequelize = new Sequelize({
  dialect: 'sqlite',
  storea: 'sample.db'
})

const Note = sequelize.define('note', {
  content: Sequelize.STRING
})

const app = express()
app.use(cors())
app.use(express.json())

app.get('/notes', async (req, res, next) => {
  try {
    const notes = await Note.findAll()
    res.status(200).json(notes)
  } catch (err) {
    next(err)
  }
})
app.post('/notes',async(req,res,next)=>{
  try{
    const note = await note.create(req.body);
    res.status(201).json(note);
  }
  catch(err){
    next(err);
  }
})

app.get('/notes/:id', async (req, res) => {
  try {
    const note = await Note.findByPk(req.params.id)
    if (note) {
      res.status(200).json(note)
    } else {
      res.status(404).json({ message: 'not found' })
    }
  } catch (e) {
    console.warn(e)
    res.status(500).json({ message: 'server error' })
  }
})

app.put('/notes/:id', async (req, res) => {
  try {
    const note = await Note.findByPk(req.params.id)
    if (note) {
      await note.update(req.body)
      res.status(202).json({ message: 'accepted' })
    } else {
      res.status(404).json({ message: 'not found' })
    }
  } catch (e) {
    console.warn(e)
    res.status(500).json({ message: 'server error' })
  }
})

app.delete('/notes/:id',async(req,res,next)=>{
  try {
    const note = await Note.findByPk(req.params.id)
    if (note) {
      await note.destroy()
      const notes = await Note.findAll()
      res.status(202).json(notes)
    } else {
      res.status(404).json({ message: 'not found' })
    }
  }
  catch(err){
    next(err);
  }
})

app.use((err, req, res, next) => {
  console.warn(err)
  res.status(500).json({ message: 'server error' })
})

app.listen(8080,async()=>{
  try{
    await sequelize.sync({ force: true })
    const sample=['test1','test2','test3']
    sample.forEach(async (e)=>{
      console.warn('creating'+e)
      await Note.create({content:e})
    })
  }
  catch(err){
    console.warn(err)
  }
})
