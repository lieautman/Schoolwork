const Sequelize = require("sequelize");
const sequelize = require('../DB/DB_driver');

const router = require("express").Router();

//pt token
//const crypto = require('crypto')
const moment = require('moment')
const TOKEN_TIMEOUT=3600

//preluare forma clasa
const User = require('../models/user_account');

//algoritm de hashing - de implementat
const hash_sha256=(string)=>{
    return string;
}

//functie de check pt tip
const checktType=(type)=>{
    if(type!=="TST"&&type!=="MP")
        throw {name:'Problema cu tip-ul'};
}


//creare user
router.route('/signup').post(async(req,res,next)=>{
    try{
        //testare date nulle sau siruri vide
        // console.warn('//////////////////////////////')
        // console.warn(req.body.firstName)
        // console.warn(req.body.lastName)
        // console.warn(req.body.email)
        // console.warn(req.body.username)
        // console.warn(req.body.passwordHash)
        // console.warn('//////////////////////////////')
        if((req.body.firstName===''||
            req.body.lastName===''||
            req.body.email===''||
            req.body.username===''||
            req.body.passwordHash==='')||(
            req.body.firstName===null||
            req.body.lastName===null||
            req.body.email===null||
            req.body.username===null||
            req.body.passwordHash===null))
            res.status(400).json({message:"Introduceti toate campurile!"});
        //hash password for database
        const passwordHash = hash_sha256(req.body.passwordHash);
        //console.warn(passwordHash)
        
        //check if username is used
        const username = req.body.username;
        const user1=await User.findOne({where:{username:username}});
        if(user1)
            res.status(409).json({message:"Username deja folosit!"});

        //check if type is good
        const type = req.body.type;
        checktType(type);
        
        const user = await User.create({
            "firstName":req.body.firstName,
            "lastName":req.body.lastName,
            "type":req.body.type,
            "email":req.body.email,
            "username":req.body.username,
            "passwordHash":passwordHash,
            "idBug":(req.body.idBug!==null)?req.body.idBug:null,
            "idProiect":(req.body.idProiect!==null)?req.body.idProiect:null,

        });
        if(user){
            res.status(200).json({message:"Created"});
        }
        else{
            res.status(404).json({message:"Eroare la creare!"});
        }
    }
    catch(err){
        next(err);
    }
});


//vedem daca userul este in db si ii intoarcem datele
router.route('/login').post(async (req,res,next)=>{
    try{
        const username = req.body.username;
        const password = req.body.password;
        const user = await User.findOne({where:{username:username}});
        if(user){
            if(user.passwordHash===hash_sha256(password)){
                let token=Math.random().toString(36);
                let expiery=moment().add(TOKEN_TIMEOUT,'seconds');

                user.token=token;
                user.expiery=expiery;
                await user.save()



                res.status(201).json({
                    id:user.id,
                    username:user.username,
                    type:user.type,
                    token:user.token
                });
            }
            else{
                res.status(401).json({message:'Parola incorecta!'});
            }
        }
        else{
            res.status(404).json({message:'Nu gasim utilizatorul!'});
        }
    }
    catch(err){
        next(err);
    }
});


//testing get all users
router.route('/getAll').get(async (req,res,next)=>{
    try{
        const users = await User.findAll();
        if(users){
            res.status(201).json(users);
        }
        else{
            res.status(404).json({message:'Nu gasim utilizatori!'});
        }
    }
    catch(err){
        next(err);
    }
});

module.exports = router;