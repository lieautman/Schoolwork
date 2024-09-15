//treb npm i sequelize
//am nevoie de drivere pt bd specifica
//

const Sequelize = require('sequelize');

const sequelize = new Sequelize({
    dialect:'sqlite',
    storage:'sample.db'
    
    //pt mysql ar treb username si pass(in documentateie le gasim)
});

sequelize.authenticate()
    .then(()=>{
    console.warn('we are connected!!!');
})
    .catch((err)=>{
    console.ward(err);
});

