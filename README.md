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

### Pools

[**pools**](./pools/) contains the base infrastructure for each tool and server. For example: `ubuntu-vm`, `grafana`, `prometheus`, ...

### Src

[**src**](./src/) contains source code, script for configuration and infrastructure as code approach. E.g: Ansible/Terraform

### Labs

[**labs**](./labs/) contains various labs with different architectural combinations.<br>
These labs combine components from the [**pools**](./pools/) directory and utilize code from the [**src**](./src/) directory to provide hands-on architectural setups.

- [linux-fundamental](./labs/linux-fundamental/)
- [aio](./labs/aio/)
- [haproxy-lab](./labs/haproxy-lab/)
- [jenkins-setup](./labs/jenkins-setup/)
- [nginx-https-lab](./labs/nginx-https-lab/)
- [nginx-lab](./labs/nginx-lab/)
- [nginx-redirect](./labs/nginx-redirect/)
- [apache-httpd](./labs/apache-httpd/)
