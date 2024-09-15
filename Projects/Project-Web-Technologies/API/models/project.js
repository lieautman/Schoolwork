const Sequelize = require("sequelize");
const sequelize = require('../DB/DB_driver');
const { DataTypes } = require('sequelize');

const Project = sequelize.define('project', {
    id: {
        type: DataTypes.UUID,
        defaultValue: DataTypes.UUIDV4,
        primaryKey: true
    },    
    linkRepo: {
        type: DataTypes.STRING,
        allowNull: false
    },
    nume:{
        type: DataTypes.STRING,
        allowNull: false
    },
    idMembruProiect:{
        type: DataTypes.UUID,
        allowNull: false
    }
});

module.exports = Project;