const Sequelize = require("sequelize");
const sequelize = require("../../DB/DB_driver");

const router = require("express").Router();

//pt expirarea tokenului
const moment = require('moment')

//preluare forma clasa
const Project = require("../../models/project");
//preluare user pt accesibilitatea derivata din tokene
const User = require('../../models/user_account');

module.exports = router;
