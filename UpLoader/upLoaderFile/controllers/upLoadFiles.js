const multer = require("multer");
const {mkDir, mixName} = require("../setting/newDirectory");
var storage = null;
module.exports = {
  uploader: (pathFolder)=>
  {
      mkDir(pathFolder+"/"+mixName(),(pFolder)=>{
        process.env.FILEDIR = pFolder;
        storage = multer.diskStorage({
          destination: function (req, file, cb) {
            cb(null, pFolder)
          },
          filename: function (req, file, cb) {
          cb(null, file.originalname); //Upload opcion 1

            //const ext = file.originalname.split(".")[1];  //Upload opcion 2
          // cb(null, `${file.fieldname}.${ext}`); //Upload opcion 2
          }
        });
      });
      
    
    const upload = multer({ storage: storage });
    return upload;
  } 
};