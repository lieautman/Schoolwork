// Express Initialisation
const express = require("express");
const app = express();
const port = 3000;

// Sequelize Initialisation
const sequelize = require("./sequelize");

// Import created models
const University = require("./models/university");
const Student = require("./models/student");

// Define entities relationship
University.hasMany(Student);

// Express middleware
app.use(
  express.urlencoded({
    extended: true,
  })
);
app.use(express.json());

//Define entities relationship
University.hasMany(Student);

// Kickstart the Express aplication
app.listen(port, () => {
  console.log("The server is running on http://localhost:" + port);
});

// Create a middleware to handle 500 status errors.
app.use((err, req, res, next) => {
  console.error("[ERROR]:" + err);
  res.status(500).json({ message: "500 - Server Error" });
});

/**
 * Create a special GET endpoint so that when it is called it will
 * sync our database with the models.
 */
app.get("/create", async (req, res, next) => {
  try {
    await sequelize.sync({ force: true });
    res.status(201).json({ message: "Database created with the models." });
  } catch (err) {
    next(err);
  }
});

/**
 * GET all the universities from the database.
 */
app.get("/universities", async (req, res, next) => {
  try {
    const universities = await University.findAll();
    res.status(200).json(universities);
  } catch (err) {
    next(err);
  }
});

/**
 * POST a new university to the database.
 */
app.post("/university", async (req, res, next) => {
  try {
    await University.create(req.body);
    res.status(201).json({ message: "Univeristy Created!" });
  } catch (err) {
    next(err);
  }
});

/**
 * GET all students.
 */
app.get("/students", async (req, res, next) => {
  try {
    const students = await Student.findAll();
    res.status(200).json(students);
  } catch (err) {
    next(err);
  }
});

/**
 * GET a specific university's students.
 */
app.get("/universities/:universityId/students", async (req, res, next) => {
  try {
    const university = await University.findByPk(req.params.universityId, {
      include: [Student],
    });
    if (university) {
      res.status(200).json(university.students);
    } else {
      res.status(404).json({ message: "404 - University Not Found!" });
    }
  } catch (err) {
    next(err);
  }
});

/**
 * IMPLEMENT POST METHOD BELOW
 */
app.post('/universities/:universityId/students',async (req,res,next)=>{
  try{
    const university = await University.findByPk(req.params.universityId);
    if(university){
      const student = new Student(req.body);
      student.universityId=university.id;
      await student.save();
      res.status(201).json(({message:'Student created!'}));
    }
    else{
      res.status(404).json({message:'404-University Not Found!'});
    }
  }catch(error){
    next(error);
  }
});


/**
 * IMPLEMENT GET FOR STUDENTS OF A SPECIFIC UNIVERSITY
 */
 app.get("/universities/:universityId/students", async (req, res, next) => {
  try
  {
    const university = await University.findByPk(req.params.universityId);
    if(university){
      const student = await Student.findAll({where:{universityId:`${university.id}`}});
      //const student = await university.getStudents();
      //const university = await University.findByPk(req.params.universityId,{include:[Student]});
      //const university = await University.findByPk(req.params.universityId,{include:[{model:Student,as:'students',include[Pencil]}]});
      
      res.status(201).json(({Studentul:student}));
    }
    else{
      res.status(404).json({message:'404-University Not Found!'});
    }
  }
  catch(error)
  {
    next(error);
  }
});