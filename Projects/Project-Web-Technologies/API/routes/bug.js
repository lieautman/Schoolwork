const Sequelize = require("sequelize");
const sequelize = require("../DB/DB_driver");

const router = require("express").Router();

//preluare forma clasa
const Bug = require("../models/bug");

//subrute in fct de tip
router.use("/MP",require("./BugRoutes/MP"))
router.use("/TST",require("./BugRoutes/TST"))

//preluare toate bugurile
router.route("/all").get(async (req, res, next) => {
  try {
    const bugs = await Bug.findAll();
    if (bugs) {
      res.status(200).json({ bugs });
    } else {
      res.status(404).json({ message: "Nu exista bug-uri!" });
    }
  } catch (err) {
    next(err);
  }
});

router.route("/updateSolve/:id").put(async (req, res, next) => {
  try {
    const bug = await Bug.findByPk(req.params.id);
    if (bug) {
      console.log(req.body.link)
      const updatedBug = await bug.update({id:bug.id,severity:bug.severity,priority:bug.priority,description:bug.description,link:req.body.link,idOfTester:bug.idOfTester,idOfProject:bug.idOfProject});
      res.status(200).json({message:"Actualizat!"});
    } else {
      res.status(404).json({ message: "Nu exista proiectul cautat!" });
    }
  } catch (err) {
    next(err);
  }
});

module.exports = router;
