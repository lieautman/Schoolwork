module.exports=(sequelize,Sequelize)=>{

    return sequelize.define('employee',{
        firstName:{
            type: Sequelize.STRING,
            allowNull:false
        },
        lastName:{
            type: Sequelize.STRING,
            allowNull:false
        },
        email:{
            type: Sequelize.STRING,
            allowNull:false,
            validate:{
                isEmail:true
            }
        },
        salary:{
            type: Sequelize.INTEGER,
            allowNull:false,
            default:0,
            validate:{
                min:0
            }
        },
        birthYear:{
            type: Sequelize.INTEGER,
            allowNull:false,
            validate:{
                min:1900
            }
        }
    });
}