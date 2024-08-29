const express = require('express');
const {departments} = require('../db');
const router = express.Router();



router.get('/', (req,res)=>{
    res.status(200).json({message:'succes'});


});

module.exports=router;