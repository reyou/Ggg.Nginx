// http://nginx.org/en/docs/njs/reference.html#http
// http://nginx.org/en/docs/njs/examples.html#subrequest
// http://nginx.org/en/docs/http/ngx_http_js_module.html
// http://nginx.org/en/docs/njs/reference.html#njs_api_fs
var fs = require('fs');
var filename = "logs/fileexport.txt";
fs.writeFileSync("qqq.txt", "qqq",{ encoding: 'utf8' });
function batchAPI(req, res) {        
    function done(reply) {
      //res.headersOut['Content-Type'] = "text/plain; charset=utf-8"; 
      // fs.writeFileSync(filename, data[, options]);
     
      fs.writeFileSync(filename, "qqq",{ encoding: 'utf8' });
      res.return(500, reply.body);       
    }
    //req.log("GggLog: " + req.variables.args);
    fs.writeFileSync(filename, "qqq",{ encoding: 'utf8' });
    req.subrequest("/api", "", done);
}