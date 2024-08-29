let fs = require('fs')
let rimraf = require('rimraf')

rimraf("./test/", function () { console.log("done"); });

fs.mkdirSync('./test/');
fs.writeFileSync("./test/ceva.txt","ceva");