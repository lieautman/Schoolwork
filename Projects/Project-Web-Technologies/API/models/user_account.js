const Sequelize = require("sequelize");
const sequelize = require('../DB/DB_driver');
const { DataTypes } = require('sequelize');

const User = sequelize.define('user', {
    id: {
        type: DataTypes.UUID,
        defaultValue: DataTypes.UUIDV4,
        primaryKey: true
    },    
    firstName: {
        type: DataTypes.STRING,
        allowNull: false
    },
    lastName: {
        type: DataTypes.STRING,
        allowNull: false
    },
    email: {
        type:DataTypes.STRING,
        allowNull:false
    },
    type: {
        type:DataTypes.STRING,
        allowNull:false,
    },
    username: {
        type:DataTypes.STRING,
        allowNull:false,
        unique:true
    },
    passwordHash: {
        type:DataTypes.STRING,
        allowNull:false
    },
    token:{
        type:DataTypes.INTEGER
    },
    expiery:{
        type:DataTypes.DATE
    },
    idBug:{
        type: DataTypes.UUID     
    }
});

module.exports = User;