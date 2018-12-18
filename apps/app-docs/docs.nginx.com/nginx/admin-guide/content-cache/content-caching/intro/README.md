* Title:	NGINX Docs | NGINX Content Caching
* Url:	https://docs.nginx.com/nginx/admin-guide/content-cache/content-caching/

### Run
```
$ nginx -c /home/aozdemir/Documents/Ggg.Nginx/apps/app-docs/docs.nginx.com/nginx/admin-guide/content-cache/content-caching/intro/config/nginx.conf
```
```
$ nginx -s reload -c /home/aozdemir/Documents/Ggg.Nginx/apps/app-docs/docs.nginx.com/nginx/admin-guide/content-cache/content-caching/intro/config/nginx.conf
```

Url: http://localhost:8085

### Sending the Purge Command
When the proxy_cache_purge directive is configured, you need to send a special cache‑purge request to purge the cache. You can issue purge requests using a range of tools, including the curl command as in this example:

```
$ curl -X PURGE -D – "http://localhost:8085"
HTTP/1.1 204 No Content
Server: nginx/1.15.0
Date: Sat, 19 May 2018 16:33:04 GMT
Connection: keep-alive
```

## Finish
You can end process with following
```
$ sudo ps -ax | grep nginx
$ netstat --tcp --listen --numeric-ports -p
$ kill -s QUIT 23929 
```