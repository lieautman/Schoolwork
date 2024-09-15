const Sequelize = require('sequelize');
const sequelize = new Sequelize({
    dialect:'sqlite',
    storage:'sample.db',
    define:{
        timestamps:false
    }
});

const Book = require('./book')(sequelize,Sequelize);




sequelize.sync({force:true})
    .then(()=>{
        console.warn('tables created');
    })