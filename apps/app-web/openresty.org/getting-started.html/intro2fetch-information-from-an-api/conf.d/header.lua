local res = ngx.location.capture('/fetch_api', { method = ngx.HTTP_GET, args = {} });

ngx.log(ngx.ERR, res.status);
if res.status == ngx.HTTP_OK then
  ngx.var.api_result = res.body;
else
  ngx.exit(403);
end
