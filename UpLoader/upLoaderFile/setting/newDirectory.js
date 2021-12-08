const fs = require("fs"); 
 //create a new directory if not exists
module.exports = {
    mkDir :  function(pathFolder,callback){ fs.mkdirSync(pathFolder ,{recursive:true}); callback(pathFolder)},
    mixName : (str="")=>{
      var nombre = str.split(" ");
        var mix = "";
        if (nombre.length >0){
          if (nombre.length >1)
          {
            mix =nombre[0];
            for(var x = 1;x<nombre.length; x++ )
            {
              mix += nombre[x][0];
            } 
          }
          else mix += nombre[0];
        }
      return mix + Date.now();
    }
  }