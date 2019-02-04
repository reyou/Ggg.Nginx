Title:	nginx - Fetch information from an API before sending the request upstream - Stack Overflow
Url:	https://stackoverflow.com/questions/48348647/fetch-information-from-an-api-before-sending-the-request-upstream

Then we start the nginx server with our config file this way:

```
$ PATH=/usr/local/openresty/nginx/sbin:$PATH
$ export PATH
$ nginx -p `pwd`/ -c conf.d/test.conf
```

Url: http://localhost:8083