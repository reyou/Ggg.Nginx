/*
http://localhost:3010
http://localhost:3010/api/pain-management/news/20181213/aromatherapy-can-you-smell-relief
*/
var port = 3010;
var express = require('express');
var app = express();
var requestTime = function (req, res, next) {
    req.requestTime = Date.now()
    next()
}
app.use(requestTime);
app.get('/api/*', function (req, res) {   
    var responseText = 'req.url: ' + req.url;
    responseText += "<br />"; 
    responseText += 'Requested at: ' + req.requestTime ;
    console.log(responseText);
    let targetUrl = req.url.replace("/api","");
    let resObj = {
        reqUrl: req.url,
        targetUrl: "http://www.webmd.com" + targetUrl
    }
    res.json(resObj);
})

app.listen(port, () => {
    console.log("App is running at http://localhost:%d in %s mode", port, "Local");
    console.log("Press CTRL-C to stop\n");
})
