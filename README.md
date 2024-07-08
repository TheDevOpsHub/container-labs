# Container Labs

Container Labs is a project designed to set up and manage multiple server environments using Docker containers and networks, along with monitoring using Prometheus, Grafana, and Alertmanager.

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

We devided this repo into 3 main areas

### The infra pools

The [pools](./pools/) directory contains the base infrastructure for each tool and server. For example: `ubuntu-vm`, `grafana`, `prometheus`, ...

### The IaC source code

The [src](./src/) directory contains source code, script for configuration and infrastructure as code approach. E.g: Ansible/Terraform

### The infra labs

The [labs](./labs/) directory contains various labs with different architectural combinations.
