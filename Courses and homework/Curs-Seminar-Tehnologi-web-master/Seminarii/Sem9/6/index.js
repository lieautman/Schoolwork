"use strict";

const PORT = 8080;



//includes
const express = require("express");
const bodyParser = require('body-parser');
const sequelize = require('./connection');

//app class
const app = express();
//parse post body
app.use(bodyParser.json());

//get classes in db
const Employee = require('./models/employee')(sequelize);



app.use("/api",require("./routes/employees"));


//routes
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



//error handleing
app.use((err,req,res,next)=>{
    console.warn(err);
    res.status(500).json({message:'some error'});
});


//start server
app.listen(PORT,()=>{
    console.log(`server started on port: ${PORT}`);
})