const mongoose = require("mongoose");
const activity = require("../models/activity");
const {mkDir, mixName} = require("../setting/newDirectory");
const filesFolder = process.cwd() + '/files';
const {uploader} = require("./upLoadFiles");

/*Connection to MongoDB*/
mongoose.connect(process.env.MONGO_URI, { useNewUrlParser: true, useUnifiedTopology: true });

//Import models 
const Activity = mongoose.model("activity",activity);

class ActivityAndFilesController{
  constructor(){  }
  addActivity({actName, description,responsable, date,files,folder},callback){
    Activity.create({actName:actName, description:description, responsable:responsable,date:date || new Date().toDateString(),files: files, folder:folder}, (err, data)=>{
      if(data)
        {
          callback(data);
        }
        else callback(err); 
    });
  };
  getActivity({},callback){
    Activity.find({},(err, data) => {
      if(data) callback(data)
      else
          callback(err)
    });
  };
  deleteActivity(id,callback){
    Activity.deleteOne({_id:id},(err) => {
      if(err) callback(err)
      else
          callback({message:"Ok"})
    });

  }
};

module.exports = ActivityAndFilesController;