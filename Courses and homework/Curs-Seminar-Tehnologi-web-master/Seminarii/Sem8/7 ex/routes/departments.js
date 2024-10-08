const express = require('express');
const {departments} = require('../db');
const router = express.Router();

//middleware pt a vedea daca id-ul primit ca parametru este un nr
const checkID = (req,res,next)=>{
  if(req.params.id && isNaN(req.params.id)){
    res.status(400).json({'error':'wrong input for id'})
  }
  else{
    next();
  }
} 

router.get('/departments',(req,res)=>{
  throw new Error('custom error!');
  res.status(200).json(departments);
});
//se trece in call
router.get("/departments/:id", checkID, (req, res) => {
    const department = departments.find(
      (department) => department.id === Number(req.params.id)
    );
    if (department) {
      res.status(200).json(department);
    } else {
      res.status(404).json({ error: "Entity not found" });
    }
  });

module.exports=router;