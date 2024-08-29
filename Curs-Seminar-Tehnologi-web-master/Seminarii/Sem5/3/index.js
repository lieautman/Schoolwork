let express = require('express')
let bodyParser= require('body-parser')
let cors = require('cors')

let app=express();
let router = express.Router();

app.use(bodyParser.urlencoded({extended:true}))
app.use(bodyParser.json());
app.use(cors())
app.use("/api",router);

const array=
[
    {id:1,nume:"Ion",age:25},
    {id:2,nume:"Alex",age:34},
    {id:3,nume:"Cristi",age:13},
    {id:4,nume:"Adi",age:19},
    {id:5,nume:"Carmen",age:20},
    {id:6,nume:"Cristina",age:21}
]

router.route("/getList").get((req,res)=>{
    res.json(array);
})

router.route("/postList").get((req,res)=>{
    let el = req.body;
    array.push(el);

    res.json(el)
})

router.route("/getList/:id").get((req,res)=>{
    let idCautat=parseInt(req.params.id,10);
    //console.log(idCautat)
    const el1 = array.find(e => {
        //console.log(idCautat)
       // console.log(e)
        return e.id === idCautat})
    //console.log(el1)
    if (el1) {
        res.status(200).json(el1)
    }
    else{
        res.status(404).json({ message: 'not found' })
    }

})

app.listen(8080)
console.log("API is running")