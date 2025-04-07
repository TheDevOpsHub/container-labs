# The Apache HTTPD lab

## Overview

- https://httpd.apache.org/
- Docker image: https://hub.docker.com/_/httpd

## Labs

### Lab01 - Bring up HTTPD

```bash
cd labs/apache-httpd/basics
docker build -t my-apache-custom -f Basic.Dockerfile .
docker run -rm -dit --name my-running-app -p 9090:80 my-apache-custom
```

Open http://localhost:9090 in your browser.
