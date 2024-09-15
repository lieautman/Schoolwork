const Sequelize = require("sequelize");
const sequelize = require('./DB/DB_driver')

//reference to table
const User = require('./models/user_account');
const Bug = require('./models/bug');
const Project = require('./models/project');

sequelize.sync({force:true})//alter:true
    .then(()=>{
        console.log('tables created');
    })
    .catch((err)=>{
        console.warn(err);
    });