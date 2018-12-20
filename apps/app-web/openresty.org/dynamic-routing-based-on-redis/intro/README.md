* Title:	OpenResty - Dynamic Routing Based On Redis
  * Url:	http://openresty.org/en/dynamic-routing-based-on-redis.html

### How To Install and Secure Redis on Ubuntu 18.04 | DigitalOcean
* https://www.digitalocean.com/community/tutorials/how-to-install-and-secure-redis-on-ubuntu-18-04

In order to get the latest version of Redis, 
we will use apt to install it from the official Ubuntu repositories.
Update your local apt package cache and install Redis by typing:

```
$ sudo apt update
$ sudo apt install redis-server
$ cat /etc/redis/redis.conf
```

To test that Redis is functioning correctly, connect to the server using the command-line client:

```
$ redis-cli
$ ping
$ set test "It's working!"
$ get test
$ help <tab>
$ exit
```


And then let's start the redis server on the localhost:6379:

```
$ ./redis-server  # default port is 6379
```

and feed some keys into this using the redis-cli utility:

```
$ redis-cli
$ set foo apache.org
$ set bar nginx.org 
$ set webmd webmd.com
$ get foo
$ get bar
```

### Start

Then we start the nginx server with our config file this way:

```
$ export PATH=/usr/local/openresty/nginx/sbin:$PATH
$ cd /home/aozdemir/Documents/Ggg.Nginx/apps/app-web/openresty.org/dynamic-routing-based-on-redis/intro/
$ nginx -p `pwd`/ -c conf/nginx.conf
$ nginx -p `pwd`/ -c conf/nginx.conf -s reload
```

Url: http://localhost:8084

And then let's test our nginx app!

```
$ curl --user-agent foo localhost:8084
<apache.org home page goes here>

$ curl --user-agent bar localhost:8084
<nginx.org home page goes here>

$ curl --user-agent webmd localhost:8084
<webmd.com home page goes here>
```