/*******************************************************************************
* Copyright (C) 2018 NGINX, Inc.
* This program is provided for demonstration purposes only.
*******************************************************************************/
function batchAPI(req, res) {
    var n = 0, requestCount = 0;
    var resp = "[";
    var errorOccured = false;
    var keyval = "batch_api";

    function done(reply) { // Callback for completed subrequests
        n++;
        if (errorOccured) { /* Once one response has an error stop processing
                               any more responses */
            return;
        }
        if (n < requestCount) {
            if (reply.status != 200) {
                errorOccured = true;
                req.log("Error in response " + n.toString() + " " + reply.uri +
                        " " + reply.status.toString());
                res.return(reply.status, "Error in response " + n.toString() +
                           " " + reply.uri + "\n");
            } else {
                resp += '["' + reply.uri + '",' + reply.body + '],';
            }
        } else { // Last response
            if (reply.status != 200) {
                errorOccured = true;
                req.log("Error in response " + n.toString() + " " + reply.uri +
                        " " + reply.status.toString());
                res.return(reply.status, "Error in response " + n.toString() +
                           " " + reply.uri + "\n");
            } else {
                resp += '["' + reply.uri + '",' + reply.body + ']';
                res.return(200, resp);
            }
        }
    }

    var argInURI = req.variables.batch_api_arg_in_uri.toLowerCase();
    if (argInURI != "on") {
        keyval = "batch_api2";
    }

    var apiURIs = req.variables[keyval].split(",");
    requestCount = apiURIs.length;
    for (var i = 0; i < requestCount; i++) {
        if (argInURI == "on") {
            req.subrequest(apiURIs[i] + "/" + req.variables.uri_suffix,
                           req.variables.args, done);
        } else {
            req.subrequest(apiURIs[i], req.variables.args, done);
        }
    }
}