"use strict";

const express = require("express");
const bodyParser = require('body-parser');
const Sequelize = require("sequelize");

const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: './simple.db'
});

const app = express();
app.use(bodyParser.json());

const Employee = require('./models/employee')(sequelize,Sequelize);

app.get('/employees',async(req,res,next)=>{
    try{
        const employees=await Employee.findAll();
        res.status(200).json(employees);
    }
    catch(err){
        next(err);
    }
});
app.post('/employees',async(req,res,next)=>{
    try{
        const employee=req.body;
        const createdEmployee = await Employee.create(employee);
        res.status(201).json(createdEmployee);
    }
    catch(err){
        next(err);
    }
});
app.use((err,req,res,next)=>{
    console.warn(err);
    res.status(500).json({message:'some error'});
});

app.listen(8080,()=>{
    console.log('server started');
})