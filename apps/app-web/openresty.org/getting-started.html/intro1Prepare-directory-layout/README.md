- Title: OpenResty - Getting Started
  - Url: https://openresty.org/en/getting-started.html

### Start the Nginx server

Assuming you have installed OpenResty into /usr/local/openresty (this is the default), we make our nginx executable of our OpenResty installation available in our PATH environment:

```
PATH=/usr/local/openresty/nginx/sbin:\$PATH
export PATH
```

Then we start the nginx server with our config file this way:

```
PATH=/usr/local/openresty/nginx/sbin:$PATH
export PATH
$ nginx -p `pwd`/ -c conf/nginx.conf
$ resty -p `pwd`/ -c conf/nginx.conf
$ curl http://localhost:8081
```

Url: http://localhost:8081

Error messages will go to the stderr device or the default error log files logs/error.log in the current working directory.
