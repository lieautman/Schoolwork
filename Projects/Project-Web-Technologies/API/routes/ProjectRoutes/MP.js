const Sequelize = require("sequelize");
const sequelize = require("../../DB/DB_driver");

const router = require("express").Router();

//pt expirarea tokenului
const moment = require('moment')

//preluare forma clasa
const Project = require("../../models/project");
//preluare user pt accesibilitatea derivata din tokene
const User = require('../../models/user_account');

//token usage middleware
router.use(async(req,res,next)=>{
  let token = req.body.token
  try{
    const user = await User.findOne({
      where:{
        token:token
      }
    })
    if(user){
      if(moment().diff(user.expiery,'seconds')<0){
          if(user.type==='MP'){
            next()
          }
          else{
            res.status(401).json({message:'Tip gresit!'})
          }
      }
      else{
        res.status(401).json({message:'Token expirat!'})
      }
    }
    else{
      res.status(401).json({message:'Neautorizat!'})
    }
  }
  catch(err){
    next(err)
  }
});
//preluare toate proiectele unui utilizator specific
router.route("/all").post(async (req, res, next) => {
  try {
    let token = req.body.token
    const user = await User.findOne({
      where:{
        token:token
      }
    });
    const projects = await Project.findAll({
      where:{
        idMembruProiect:user.id
      }
    });
    if (projects) {
      res.status(200).json({ projects });
    } else {
      res.status(404).json({ message: "Nu exista proiecte!" });
    }
  } catch (err) {
    next(err);
  }
});
//creare proiect
router.route("/create").post(async (req, res, next) => {
  try {
    const project = await Project.create({linkRepo:req.body.linkRepo,nume:req.body.nume,idMembruProiect:req.body.idMembruProiect});
    if (project) {
      res.status(200).json({ message: "Creat!"  });
    } else {
      res.status(404).json({ message: "Eroare la creare!" });
    }
  } catch (err) {
    next(err);
  }
});

router.route("/update/:id").put(async (req, res, next) => {
  try {
    const project = await Project.findByPk(req.params.id);
    if (project) {
      const updatedProject = await project.update(req.body);
      res.status(200).json({message:"Actualizat!"});
    } else {
      res.status(404).json({ message: "Nu exista proiectul cautat!" });
    }
  } catch (err) {
    next(err);
  }
});

router.route("/delete/:id").delete(async (req, res, next) => {
  try {
    console.warn(req.params.id)
    const project = await Project.findByPk(req.params.id);
    if (project) {
      const deletedProject = await project.destroy();
      res.status(200).json({message:"Sters!"});
    } else {
      res.status(404).json({ message: "Nu exista proiectul cautat!" });
    }
  } catch (err) {
    next(err);
  }
});

module.exports = router;
