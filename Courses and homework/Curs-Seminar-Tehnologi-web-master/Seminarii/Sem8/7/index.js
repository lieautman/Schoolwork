"use strict";

const express = require("express");
const departamentsRouter = require('./routes/departments');
const statusRouter = require('./routes/status');
require("dotenv").config();

const app = express();

//metoda implementata de mine
const printeazaURL = (req,res,next)=>{
  console.log(req.method, req.url);
  next();
}
app.use(printeazaURL);



app.use('/api',departamentsRouter);
app.use('/status',statusRouter);



//middleware de tratat erori globale
app.use((err,req,res,next)=>{
  res.status(500).json({'Error':'Something broke!'});
});




app.set("port", process.env.PORT || 7000);

app.listen(app.get("port"), () => {
  console.log(`Server started on http://localhost:${app.get("port")}`);
});