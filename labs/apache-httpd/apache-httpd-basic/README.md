# The Apache HTTPD lab

## Overview

- https://httpd.apache.org/
- Docker image: https://hub.docker.com/_/httpd

## Labs

### Lab01 - Bring up HTTPD

```bash
docker build -t my-apache-custom .
docker run -dit --name my-running-app -p 9090:80 my-apache-custom
```

Open http://localhost:9090 in your browser.
