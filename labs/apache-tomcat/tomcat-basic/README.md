Here’s a similar version of your Apache HTTPD lab, but for **Apache Tomcat**:

---

# The Apache Tomcat Lab

## Overview

- Website: https://tomcat.apache.org/
- Docker image: https://hub.docker.com/_/tomcat

## Labs

### Lab01 - Bring up Tomcat

```bash
docker pull tomcat
docker run -dit --name my-tomcat-app -p 9190:8080 tomcat
```

Open [http://localhost:9190](http://localhost:9190) in your browser.
