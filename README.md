# Container Labs 🐳

Container Labs is a **DevOps practice** project designed to set up and manage multiple server environments using Docker containers and networks, along with monitoring using Prometheus, Grafana, and Alertmanager.

## Getting Started

### Prerequisites

- [Docker](https://docs.docker.com/engine/install/)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Setup

Clone the repository and navigate into it:

```bash
git clone https://github.com/TheDevOpsHub/container-labs.git
cd container-labs
```

## Labs

We devided this repo into 3 main areas:

- [**pools**](./pools/): Contains the base infrastructure for each tool and server. For example: `ubuntu-vm`, `grafana`, `prometheus`, ...

- [**src**](./src/): Contains source code, script for configuration and infrastructure as code approach. E.g: Ansible/Terraform

- [**labs**](./labs/): Contains various labs with different architectural combinations. These labs combine components from the [**pools**](./pools/) directory and utilize code from the [**src**](./src/) directory to provide hands-on architectural setups.

Below is the list of available labs, categorized by technology/tool. Each lab provides a hands-on environment to practice and learn using Docker containers:
| Category      | Lab                                                                  | Description                                                                 |
| ------------- | -------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| linux         | [fundamental](./labs/linux/fundamental/)                             | Learn basic Linux commands and concepts in a containerized environment.     |
| haproxy       | [haproxy-basic](./labs/haproxy/haproxy-basic/)                       | Set up a basic HAProxy instance to load balance between backend servers.    |
| jenkins       | [jenkins-controller-setup](./labs/jenkins/jenkins-controller-setup/) | Deploy a Jenkins controller and explore pipeline fundamentals.              |
| nginx         | [nginx-basic](./labs/nginx/nginx-basic/)                             | Run a simple Nginx container to serve static content.                       |
| nginx         | [nginx-https-lab](./labs/nginx/nginx-https-lab/)                     | Enable HTTPS with self-signed certificates on an Nginx container.           |
| nginx         | [nginx-redirect](./labs/nginx/nginx-redirect/)                       | Configure basic and advanced URL redirection rules in Nginx.                |
| apache-httpd  | [apache-httpd-basic](./labs/apache-httpd/apache-httpd-basic/)        | Set up Apache HTTP Server and serve web content inside a container.         |
| apache-tomcat | [tomcat-basic](./labs/apache-tomcat/tomcat-basic/)                   | Deploy a Java web application using Apache Tomcat in Docker.                |
| os            | [ubuntu](./labs/os/ubuntu/)                                          | Launch and explore a minimal Ubuntu-based container environment.            |
| os            | [windows](./labs/os/windows/)                                        | Simulate a Windows container environment.                                   |
| mix           | [aio](./labs/mix/aio/)                                               | All-in-one lab combining multiple tools (e.g., Nginx, Prometheus, Grafana). |
