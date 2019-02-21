print("Hello")
ngx.log(ngx.ERR, "host: just a ERR")
ngx.log(ngx.CRIT, "host: just a CRIT")
ngx.log(ngx.ALERT, "host: just a ALERT")
ngx.say('Hello,world!')

ngx.print('some data here')
local key = ngx.var.http_user_agent
if not key then
    ngx.log(ngx.ERR, "no user-agent found")
    return ngx.exit(400)
end

local redis = require "resty.redis"
local red = redis:new()

red:set_timeout(1000) -- 1 second

local ok, err = red:connect("127.0.0.1", 6379)
if not ok then
    ngx.log(ngx.ERR, "failed to connect to redis: ", err)
    return ngx.exit(500)
end

local host, err = red:get(key)               
ngx.log(ngx.ERR, "host: ", host)
ngx.log(ngx.ERR, "err: ", err)               
if not host then
    ngx.log(ngx.ERR, "failed to get redis key: ", err)
    return ngx.exit(500)
end

if host == ngx.null then
    ngx.log(ngx.ERR, "no host found for key ", key)
    return ngx.exit(400)
end

ngx.var.target = host