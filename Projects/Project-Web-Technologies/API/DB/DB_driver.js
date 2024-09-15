const Sequelize = require("sequelize");
//database config
const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: './DB/simple.db'
});
module.exports = sequelize;