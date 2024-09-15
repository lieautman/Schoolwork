const Sequelize = require("sequelize");
const sequelize = require("../../DB/DB_driver");

const router = require("express").Router();

//pt expirarea tokenului
const moment = require('moment')

//preluare forma project
const Project = require("../../models/project");
//preluare user pt accesibilitatea derivata din tokene
const User = require('../../models/user_account');
//preluare forma bug
const Bug = require('../../models/bug');

module.exports = router;
