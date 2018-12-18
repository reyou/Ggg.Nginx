Then we start the nginx server with our config file this way:

```
$ PATH=/usr/local/openresty/nginx/sbin:$PATH
$ export PATH
$ nginx -p `pwd`/ -c conf/nginx.conf
```

Url: http://localhost:8082