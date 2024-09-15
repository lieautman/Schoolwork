const Sequelize = require("sequelize");

const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: './simple.db'
});


const Employee = require('./models/employee')(sequelize,Sequelize);

sequelize.sync({force:true})//alter:true
    .then(()=>{
        console.log('tables created');
    })
    .catch((err)=>{
        console.warn(err);
    });