const Sequelize = require('sequelize');

const sequelize = new Sequelize({
    dialect:'sqlite',
    storage:'sample.db'
    
    //pt mysql ar treb username si pass(in documentateie le gasim)
});

const Author = sequelize.define('author',{
    name:Sequelize.STRING,
    email:Sequelize.STRING
});//create table if not exists
//biblioteca are o conventie, dar eu pot devia
//tabela va fi plural author in engleza
//col vor fi name si email
//2 elemente similare vor avea id-uri diferite autogenerate
//se creaza si o serie de time-stamp-uri
//la config putem da time-stamp false

sequelize.sync()
    .then(()=>{
        console.warn('tables created');
    })