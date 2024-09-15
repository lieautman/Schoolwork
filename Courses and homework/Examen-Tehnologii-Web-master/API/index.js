const port = 8080;

//imports
const express = require('express');
const Sequelize = require("sequelize");
const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: './DB/simple.db'
});
const bodyParser = require('body-parser');
const cors = require('cors');
const { DataTypes } = require('sequelize');

const app = express();
app.use(cors())
app.use(bodyParser.json());

//definire entitati:
const Spacecraft = sequelize.define('spacecraft', {
    id: {
        type: DataTypes.INTEGER,
        primaryKey: true
    },
    nume:{
        type: DataTypes.STRING,
        validate: {
            customValidator(value) {
              if (value.length < 3) {
                throw new Error("Nume prea mic!");
              }
            }
        }
    },
    vitezaMaxima:{
        type: DataTypes.INTEGER,
        validate: {
            customValidator(value) {
              if (value <= 1000) {
                throw new Error("Viteza maxima prea mica!");
              }
            }
        }
    },
    masa:{
        type: DataTypes.INTEGER,
        validate: {
            customValidator(value) {
              if (value <= 200) {
                throw new Error("Masa prea mica!");
              }
            }
        }
    }
})
const Astronaut = sequelize.define('astronaut', {
    id: {
        type: DataTypes.INTEGER,
        primaryKey: true
    },
    nume:{
        type: DataTypes.STRING,
        validate: {
            customValidator(value) {
              if (value.length < 5) {
                throw new Error("Nume prea mic!");
              }
            }
        }
    },
    rol:{
        type: DataTypes.ENUM,
        values:['COMMANDER','PILOT','GUNNER']
    },
    idSpacecraft:{
        type: DataTypes.INTEGER
    }
})


//misc
app.get('/', (req,res)=>{
    res.status(200).json({message:'succes'});
    console.log('succes')
});
app.get('/sync', async (req, res, next) => {
    try {
        await sequelize.sync({ force: true })
        console.log('synced')
        res.status(200).json({message:'synced'});
    } 
    catch (err) {
        next(err)
    }
})

//operatii spacecraft
app.get('/spacecraft',async(req,res,next)=>{
    try {
        const spacecrafts = await Spacecraft.findAll();
        if (spacecrafts) {
            res.status(200).json(spacecrafts);
        } 
        else {
            res.status(404).json({ message: "Eroare la preluare spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})
app.post('/spacecraft',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.create(req.body);
        if (spacecraft) {
            res.status(200).json({ message: "Creat!"  });
        } 
        else {
            res.status(404).json({ message: "Eroare la creare spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})
app.put('/spacecraft/:id',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.id);
        if (spacecraft) {
            const updatedSpacecraft = await spacecraft.update(req.body);
            res.status(200).json({message: "Actualizat!" });
        }
        else {
            res.status(404).json({ message: "Eroare la updatare spacecraft!" });
        }
    } 
    catch (err) {
       next(err)
    }
})
app.delete('/spacecraft/:id',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.id);
        if (spacecraft) {
            const deletedSpacecraft = await spacecraft.destroy();

            const astronautsStersi = await Astronaut.findAll({
                where:{
                    idSpacecraft:spacecraft.id
                }
            })
            astronautsStersi.forEach(async(astr) => {
                await astr.destroy()
            });
            

            res.status(200).json({message: "Sters!" });
        }
        else {
            res.status(404).json({ message: "Eroare la delete spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})

//operatii astronaut
app.get('/astronaut/:idSpacecraft',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.idSpacecraft)

        const astronauts = await Astronaut.findAll(
            {
                where:{
                    idSpacecraft:spacecraft.id
                }
            }
        )

        if (astronauts) {
            res.status(200).json(astronauts);
        } 
        else {
            res.status(404).json({ message: "Eroare la preluare spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})
app.post('/astronaut/:idSpacecraft',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.idSpacecraft)

        const astronaut = await Astronaut.create({id:req.body.id,nume:req.body.nume,rol:req.body.rol,idSpacecraft:spacecraft.id});
        if (astronaut) {
            res.status(200).json({ message: "Creat!"  });
        } 
        else {
            res.status(404).json({ message: "Eroare la creare spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})
app.put('/astronaut/:idSpacecraft/:idAstronaut',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.idSpacecraft);
        const astronaut = await Astronaut.findByPk(req.params.idAstronaut);
        if (astronaut) {
            const updatedAstronaut = await astronaut.update(req.body);
            res.status(200).json({message: "Actualizat!" });
        }
        else {
            res.status(404).json({ message: "Eroare la updatare spacecraft!" });
        }
    } 
    catch (err) {
       next(err)
    }
})
app.delete('/astronaut/:idSpacecraft/:idAstronaut',async(req,res,next)=>{
    try {
        const spacecraft = await Spacecraft.findByPk(req.params.idSpacecraft);
        const astronaut = await Astronaut.findByPk(req.params.idAstronaut);
        if (astronaut) {
            const deletedAstronaut = await astronaut.destroy();
            res.status(200).json({message: "Sters!" });
        }
        else {
            res.status(404).json({ message: "Eroare la delete spacecraft!" });
        }
    } 
    catch (err) {
        next(err)
    }
})


//operatii aditionale
app.post('/filtrare',async(req,res,next)=>{
    res.status(404).json({ message: "Ruta necreata!" });
    
})
app.post('/sortare',async(req,res,next)=>{
    const field = req.body.field
    console.log(field)
    const spacecrafts = await Spacecraft.findAll(
        {
            order:[[field,'ASC']]
        }
    )
    console.log(spacecrafts)
    if (spacecrafts) {
        res.status(200).json(spacecrafts);
    } 
    else {
        res.status(404).json({ message: "Eroare la preluare spacecraft!" });
    }
})
app.post('/paginare',async(req,res,next)=>{
    const pageSize= req.body.pageSize
    const pageNumber = req.body.pageNumber

    let spacecrafts= await Spacecraft.findAll()

    res.status(404).json({ message: "Ruta necreata!" });
})
app.post('/export',async(req,res,next)=>{
    const spacecrafts = await Spacecraft.findAll();
    const astronauts = await Astronaut.findAll();
    res.status(200).json({spacecrafts: spacecrafts,astronauts:astronauts });
})
app.post('/import',async(req,res,next)=>{
    const jsonPrimit = req.body;
    console.log(jsonPrimit)

    const spacecrafts=jsonPrimit.spacecrafts;
    const astronauts=jsonPrimit.astronauts;
    console.log(spacecrafts)
    console.log(astronauts)


    await sequelize.sync({ force: true })


    spacecrafts.forEach(async(spacecraft) => {
        const spacecraftsCreate = await Spacecraft.create(spacecraft);
        console.log(spacecraftsCreate)
    });

    astronauts.forEach(async(astronaut) => {
        const astronautCreate = await Astronaut.create(astronaut);
        console.log(astronautCreate)
    });

    res.status(204).json({ message: "Imported!" });
})


//misc
app.use((err, req, res, next) => {
    console.warn(err)
    res.status(500).json({ message: err.message })
})
app.listen(port, () => {
  console.log(`Server started on http://localhost:${port}`);
});