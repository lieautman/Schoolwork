const sequelize = require('../connection');
const Employee = require("../models/employee")(sequelize);

const router = require("express").Router();

router.route("/employees").get(async (req,res,next)=>{
    try{
        const employees = await Employee.findAll();
        return res.status(200).json(employees);
    }
    catch(err){
        next(err);
    }
});

router.route("/employees").post(async(req,res,next)=>{
    try{
        const employee=req.body;
        const createdEmployee = await Employee.create(employee);
        res.status(201).json(createdEmployee);
    }
    catch(err){
        next(err);
    }
});

module.exports = router;