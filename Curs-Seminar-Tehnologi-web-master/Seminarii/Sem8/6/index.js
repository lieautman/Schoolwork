"use strict";

const express = require("express");
const departamentsRouter = require('./routes/departments');
const statusRouter = require('./routes/status');
require("dotenv").config();

const app = express();

app.use('/api',departamentsRouter);
app.use('/status',statusRouter);



app.set("port", process.env.PORT || 7000);

app.listen(app.get("port"), () => {
  console.log(`Server started on http://localhost:${app.get("port")}`);
});