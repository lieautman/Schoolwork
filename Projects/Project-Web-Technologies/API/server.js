const port = 8080;

const express = require('express');
const Sequelize = require("sequelize");
const sequelize = require('./DB/DB_driver');
const bodyParser = require('body-parser');
const cors = require('cors');

const app = express();
app.use(cors())
app.use(bodyParser.json());

//ruta pentru operatii pe contul clientului
app.use("/user",require("./routes/user_account"));
//ruta pentru administrarea cererilor pentru bug-uri
app.use("/bug",require("./routes/bug"))
//ruta pentru administrarea cererilor pentru proiecte
app.use("/project",require("./routes/project"))

//modelarea erorilor
app.use((err, req, res, next) => {
    console.error(`[ERROR]: ${err}`);
    res.status(500).json({message:err.name});
  });
app.listen(port);