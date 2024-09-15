const Sequelize = require('sequelize');
const sequelize = require('../../DB/DB_driver');

const router = require('express').Router();

//pt expirarea tokenului
const moment = require('moment');

//preluare forma clasa
const Bug = require('../../models/bug');
//preluare user pt accesibilitatea derivata din tokene
const User = require('../../models/user_account');

//token usage middleware
router.use(async (req, res, next) => {
  let token = req.body.token;
  try {
    const user = await User.findOne({
      where: {
        token: token,
      },
    });
    if (user) {
      if (moment().diff(user.expiery, 'seconds') < 0) {
        if (user.type === 'TST') {
          next();
        } else {
          res.status(401).json({ message: 'Tip gresit!' });
        }
      } else {
        res.status(401).json({ message: 'Token expirat!' });
      }
    } else {
      res.status(401).json({ message: 'Neautorizat!' });
    }
  } catch (err) {
    next(err);
  }
});

//preluare toate proiectele unui utilizator specific
router.route('/all').post(async (req, res, next) => {
  try {
    let token = req.body.token;
    const user = await User.findOne({
      where: {
        token: token,
      },
    });
    const bugs = await Bug.findAll({
      where: {
        idOfTester: user.id,
      },
    });
    if (bugs) {
      res.status(200).json({ bugs });
    } else {
      res.status(404).json({ message: 'Nu exista proiecte!' });
    }
  } catch (err) {
    next(err);
  }
});

//creare proiect
router.route('/create').post(async (req, res, next) => {
  try {
    const bug = await Bug.create({
      severity: req.body.severity,
      priority: req.body.priority,
      description: req.body.description,
      link: req.body.link,
      idOfTester: req.body.idOfTester,
      idOfProject: req.body.idOfProject,
    });
    if (bug) {
      res.status(200).json({ message: 'Bug added!' });
    } else {
      res.status(404).json({ message: 'Error!' });
    }
  } catch (err) {
    next(err);
  }
});

router.route('/update/:id').put(async (req, res, next) => {
  try {
    const bug = await Bug.findByPk(req.params.id);
    if (bug) {
      const updatedBug = await bug.update(req.body);
      res.status(200).json({ message: 'Actualizat!' });
    } else {
      res.status(404).json({ message: 'Nu exista proiectul cautat!' });
    }
  } catch (err) {
    next(err);
  }
});

router.route('/delete/:id').delete(async (req, res, next) => {
  try {
    console.warn(req.params.id);
    const bug = await Bug.findByPk(req.params.id);
    if (bug) {
      const deletedBug = await bug.destroy();
      res.status(200).json({ message: 'Sters!' });
    } else {
      res.status(404).json({ message: 'Nu exista proiectul cautat!' });
    }
  } catch (err) {
    next(err);
  }
});

module.exports = router;
