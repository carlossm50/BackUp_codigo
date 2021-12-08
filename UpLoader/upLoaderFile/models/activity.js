const mongoose = require("mongoose");

const Schema = mongoose.Schema;

const  activity = new Schema({
  actName: { type: String, required: true },
  description: String,
  responsable: String,
  date: String,
  files:[],
  folder:String
});

module.exports = activity;