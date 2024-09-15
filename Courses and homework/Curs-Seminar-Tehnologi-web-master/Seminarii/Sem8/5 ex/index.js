"use strict";

const express = require("express");
const { departments } = require("./db");
require("dotenv").config();

const app = express();

app.get("/departments", (req, res) => {
  res.status(200).json(departments);
});

app.get("/departments/:id", (req, res) => {
  const department = departments.find(
    (department) => department.id === Number(req.params.id)
  );
  if (department) {
    res.status(200).json(department);
  } else {
    res.status(404).json({ error: "Entity not found" });
  }
});

const routerStatus = express.Router();

routerStatus.get('/', (req,res)=>{
    res.status(200).json({message:'succes'});


});

app.use('/status',routerStatus);






app.set("port", process.env.PORT || 7000);

app.listen(app.get("port"), () => {
  console.log(`Server started on http://localhost:${app.get("port")}`);
});