* Title:	NGINX Docs | Configuring NGINX Plus as a Web Server
  * Url:	https://docs.nginx.com/nginx/admin-guide/web-server/web-server/


### Run
```
$ nginx -c /home/aozdemir/Documents/Ggg.Nginx/apps/app-docs/docs.nginx.com/nginx/admin-guide/web-server/web-server/intro/config/nginx.conf
```
```
$ nginx -s reload -c /home/aozdemir/Documents/Ggg.Nginx/apps/app-docs/docs.nginx.com/nginx/admin-guide/web-server/web-server/intro/config/nginx.conf
```

Url: http://localhost:8085


## Finish
You can end process with following
```
$ sudo ps -ax | grep nginx
$ netstat --tcp --listen --numeric-ports -p
$ kill -s QUIT 23929 
```