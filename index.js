const express = require('express');
const app = express();
var bodyParser = require('body-parser');
const port = 8080;
app.use(bodyParser.urlencoded({ extended: false }));

app.post("/form", function(req,res){
    res.send("username: "+req.body.name);
});
app.listen(port, function () {
    console.log("app started success,port"+port);
});