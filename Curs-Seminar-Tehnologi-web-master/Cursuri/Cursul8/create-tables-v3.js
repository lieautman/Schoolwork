const Sequelize = require('sequelize');
const sequelize = new Sequelize({
    dialect:'sqlite',
    storage:'sample.db',
    define:{
        timestamps:false
    }
});

const Author = sequelize.define('author',{
    name:{
        type:Sequelize.STRING,
        allowNull:false},
    email:{
        type:Sequelize.STRING,
        allowNull:false,
        validate:{
            isEmail:true//putem valida si mai corect cu un regex
            //putem crea si fct(in caz in care regex nu e de ajuns)
        }
    }
});

const Message = sequelize.define('message',{
    title:{
        type:Sequelize.STRING,
        allowNull:false},
    content:{
        type:Sequelize.TEXT
    }
})

Author.hasMany(Message);//message belongs to author

sequelize.sync({force:true})
    .then(()=>{
        console.warn('tables created');
    })



//Sequelize.NOW momentul in care serverul a primit comanda