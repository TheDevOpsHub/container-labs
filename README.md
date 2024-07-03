# Container Labs

Container Labs is a project to set up and manage multiple server environments using Docker containers and networks, along with monitoring using Prometheus, Grafana, and Alertmanager.

## Getting Started

### Prerequisites

- Docker
- Docker Compose

### Setup

Clone the repository and navigate into it:

```bash
git clone https://github.com/TheDevOpsHub/container-labs.git
cd container-labs
```

## Build and run the containers:

- Option-1: Build and run in background

```bash
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

- Option-2: Run and verbose the logs

```bash
docker-compose up --build

# To stop, press 'Ctrl + C'
```

## Monitoring

- Access Prometheus at http://localhost:9090
- Access Grafana at http://localhost:3000 (default login: admin/admin)
- Access Alertmanager at http://localhost:9093

## Services

- ubuntu-vm1: An Ubuntu VM running in a Docker container.
- ubuntu-vm2: An Ubuntu VM running in a Docker container.
- prometheus: A Prometheus server for monitoring.
- grafana: A Grafana server for visualization.
- alertmanager: An Alertmanager server for alerting
