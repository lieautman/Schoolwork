const Sequelize = require("sequelize");
const sequelize = require('../DB/DB_driver');
const { DataTypes } = require('sequelize');

const Bug = sequelize.define('bug', {
    id: {
        type: DataTypes.UUID,
        defaultValue: DataTypes.UUIDV4,
        primaryKey: true
    },    
    severity: {
        type: DataTypes.STRING,
        allowNull: false
    },
    priority: {
        type: DataTypes.STRING,
        allowNull: false
    },
    description: {
        type: DataTypes.STRING,
        allowNull: false
    },
    link: {
        type: DataTypes.STRING
    },
    idOfTester: {
        type:DataTypes.UUID,
        allowNull:false
    },
    idOfProject:{
        type:DataTypes.UUID,
        allowNull:false
    }
});

module.exports = Bug;