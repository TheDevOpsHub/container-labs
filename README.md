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

[**pools**](./pools/)

- Contains the base infrastructure for each tool and server. For example: `ubuntu-vm`, `grafana`, `prometheus`, ...

[**src**](./src/)

- Contains source code, script for configuration and infrastructure as code approach. E.g: Ansible/Terraform

[**labs**](./labs/)
Contains various labs with different architectural combinations. These labs combine components from the [**pools**](./pools/) directory and utilize code from the [**src**](./src/) directory to provide hands-on architectural setups.

- [linux](./labs/linux/)
  - [fundamental](./labs/linux/fundamental/)
- [haproxy](./labs/haproxy/)
  - [haproxy-basic](./labs/haproxy/haproxy-basic/)
- [jenkins](./labs/jenkins/)
  - [jenkins-controller-setup](./labs/jenkins/jenkins-controller-setup/)
- [nginx](./labs/nginx/)
  - [nginx-basic](./labs/nginx/nginx-basic/)
  - [nginx-https-lab](./labs/nginx/nginx-https-lab/)
  - [nginx-redirect](./labs/nginx/nginx-redirect/)
- [apache-httpd](./labs/apache-httpd/)
  - [apache-httpd-basic](./labs/apache-httpd/apache-httpd-basic/)
- [apache-tomcat](./labs/apache-tomcat/)
  - [tomcat-basic](./labs/apache-tomcat/tomcat-basic/)
- [os](./labs/os/)
  - [ubuntu](./labs/os/ubuntu/)
  - [windows](./labs/os/windows/)
- [mix](./labs/mix/)
  - [aio](./labs/mix/aio/)
