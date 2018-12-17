function kvHeaders(headers, parent) {
    var kvpairs = "";
    for (var h in headers) {
        kvpairs += " " + parent + "." + h + "=";
        if ( headers[h].indexOf(" ") == -1 ) {
		kvpairs += headers[h];
        } else {
            kvpairs += "'" + headers[h] + "'";
        }
    }
    return kvpairs;
}

function kvAccessLog(req, res) {
    var log = req.variables.time_iso8601;  // nginScript can access all variables
    log += " client=" + req.remoteAddress; // Property of request object
    log += " method=" + req.method;        // "
    log += " uri=" + req.uri;              // "
    log += " status=" + res.status;        // Property of response object
    log += kvHeaders(req.headers, "req");  // Send request headers object to function
    log += kvHeaders(res.headers, "res");  // Send response headers object to function
    return log;
}
