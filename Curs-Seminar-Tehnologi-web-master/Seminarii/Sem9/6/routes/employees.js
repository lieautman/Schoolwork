const sequelize = require('../connection');
const Employee = require("../models/employee")(sequelize);

const router = require("express").Router();

const {Op}=require('sequelize');

router.route("/employees").get(async (req,res,next)=>{
    try{
        //filtrare dupa salariu
        const {minSalary}=req.query;
        const {name}=req.query;

        if(minSalary){
            const employees = await Employee.findAll({
                where:minSalary?{salary:{[Op.gt]:minSalary}}:undefined
            });
            return res.status(200).json(employees);
        }

        if(name){
            const employees = await Employee.findAll({
                where:name?{lastName:{[Op.eq]:name}}:undefined
            });
            return res.status(200).json(employees);
        }
        // const employees = await Employee.findAll();
        // return res.status(200).json(employees);
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


router.route("/employees/:id").get(async (req,res,next)=>{
    try{
        const employees = await Employee.findByPk(req.params.id);
        if(employee){
            return res.status(200).json(employees);
        }
        else{
            return res.status(404).json({message:`Employee with id ${req.params.id} not found`});
        }
    }
    catch(err){
        next(err);
    }
});
router.route("/employees/:id").put(async (req,res,next)=>{
    try{
        const employee = await Employee.findByPk(req.params.id);
        if(employee){
            const updatedEmployee = await employee.update(req.body);
            return res.status(200).json(updatedEmployee);
        }
        else{
            return res.status(404).json({message:`Employee with id ${req.params.id} not found`});
        }
    }
    catch(err){
        next(err);
    }
});
router.route("/employees/:id").delete(async (req,res,next)=>{
    try{
        const employee = await Employee.findByPk(req.params.id);
        if(employee){
            const updatedEmployee = await employee.destroy(req.body);
            return res.status(200).json(updatedEmployee);
        }
        else{
            return res.status(404).json({message:`Employee with id ${req.params.id} not found`});
        }
    }
    catch(err){
        next(err);
    }
});

router.route("/employees-all").get(async (req,res,next)=>{
    try{
        const {simplified}=req.query;

        const query = {}
        if (req.query.sortField) {
			const sortField = req.query.sortField
			const sortOrder = req.query.sortOrder ? req.query.sortOrder : 'ASC'
			query.order = [
				[sortField, sortOrder]
			]
		}



        if (req.query.simplified) {
            query.attributes={exclude:'id'}
        }

        const employees=await Employee.findAll(query);
        res.status(200).json(employees);
    }
    catch(err){
        next(err);
    }
});

module.exports = router;
