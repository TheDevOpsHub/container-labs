Here’s a similar version of your Apache HTTPD lab, but for **Apache Tomcat**:

---

# The Apache Tomcat Lab

## Overview

- Website: https://tomcat.apache.org/
- Docker image: https://hub.docker.com/_/tomcat

## Labs

### Lab01 - Bring up Tomcat

```bash
docker run -dit --name my-tomcat-app -p 9190:8080 tomcat:9.0
```

Note: as of docker-library/tomcat#181⁠, the upstream-provided (example) webapps are not enabled by default, per upstream's security recommendations⁠, but are still available under the webapps.dist folder within the image to make them easier to re-enable.

Open [http://localhost:9190](http://localhost:9190) in your browser (noting that it will return a 404 since there are no webapps loaded by default).
