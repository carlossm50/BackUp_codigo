require('dotenv').config(); //Carga las variables de entorno del archivo .env y las pone dentro del objeto process.env
const express = require("express");
const cors = require('cors');
const bodyParser = require('body-parser');
const {uploader} = require("./controllers/upLoadFiles");
const app = express();
const ActivityAndFilesController = require("./controllers/activityAndFile");
const  activityAndFilesController = new ActivityAndFilesController();

//Variables for files destination 
const filesFolder = process.cwd() + '/files';
const upload = uploader(filesFolder); //Uploader files
console.log(process.env.MONGO_URI);
/* Begin Mideleware */
app.use(cors());
app.use(express.static('public'));
//app.use('/public', express.static(publicFolder));
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());


//Rutas a llamar 
app.get("/",(req, res)=>{});

app.post("/p",(req, res)=>{
  res.json(req);
});

app.post("/addActivity", upload.array("myFile") ,(req, res) => {
  const _body ={actName     :req.body.actName, 
                description :req.body.description,
                responsable :req.body.responsable, 
                date        :req.body.date,
                files       :[],
                folder      :process.env.FILEDIR};
  req.files.map(file => {
    _body.files.push(file.originalname);
  });

  activityAndFilesController.addActivity(_body, (data) => { 
    res.json( data)
  });
});

app.get("/download/:folder/:file", (req, res)=>{
  let {folder,file} = req.params;
  res.download( filesFolder+"/"+folder+"/"+file);
});

app.get("/getActivity", (req, res) => {
  const {actName} = req.query;
  console.log(actName);
  activityAndFilesController.getActivity({}, (data) => {
    const datafiltered = data.filter( i => i.actName.toUpperCase().includes(actName.toUpperCase()));
    res.send(datafiltered);
  })
});
app.get("/getAll", (req, res) => {
  
  
  activityAndFilesController.getActivity({}, (data) => {
    const datafiltered = data;
    res.send(datafiltered);
  })
});
app.get("/deleteActivity", (req, res) => {
  const {_id} = req.query;
console.log(_id)

 activityAndFilesController.deleteActivity(_id, (data => {
    if (data.err){ res.json(data.err) }
    else res.json(data.message);
  }));
});

//Start server
app.listen ( process.env.PORT || 4000, ()=> {
  console.log("Server online!");
});