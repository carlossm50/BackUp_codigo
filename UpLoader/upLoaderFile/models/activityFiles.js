const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const activityFiles  = new Schema({
  filesName: [],
  folder:String
});

module.exports = activityFiles;