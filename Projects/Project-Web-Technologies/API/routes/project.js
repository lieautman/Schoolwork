const Sequelize = require("sequelize");
const sequelize = require("../DB/DB_driver");

const router = require("express").Router();

//preluare forma clasa
const Project = require("../models/project");

//subrute in fct de tip
router.use("/MP",require("./ProjectRoutes/MP"))
router.use("/TST",require("./ProjectRoutes/TST"))

//preluare toate proiectele
router.route("/all").get(async (req, res, next) => {
  try {
    const projects = await Project.findAll();
    if (projects) {
      res.status(200).json({ projects });
    } else {
      res.status(404).json({ message: "Nu exista proiecte!" });
    }
  } catch (err) {
    next(err);
  }
});

module.exports = router;
