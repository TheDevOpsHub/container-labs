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

## Build and run the containers

- Option-1: Build and run in background (Recommend)

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

## Explore the resources

### Access the VM

- Access the VM1 and try to ping VM2 via lab-network

```bash
docker run -it --network container-labs_lab-network container-labs-ubuntu-vm1 bash

## Sample result:
# ➜  container-labs git:(init-proj) ✗ docker run -it --network container-labs_lab-network container-labs-ubuntu-vm1 bash
# root@9069153b62d5:/# ping ubuntu-vm2
# PING ubuntu-vm2 (172.20.0.3) 56(84) bytes of data.
# 64 bytes from ubuntu-vm2.container-labs_lab-network (172.20.0.3): icmp_seq=1 ttl=64 time=0.256 ms
# 64 bytes from ubuntu-vm2.container-labs_lab-network (172.20.0.3): icmp_seq=2 ttl=64 time=0.046 ms
# 64 bytes from ubuntu-vm2.container-labs_lab-network (172.20.0.3): icmp_seq=3 ttl=64 time=0.066 ms
# 64 bytes from ubuntu-vm2.container-labs_lab-network (172.20.0.3): icmp_seq=4 ttl=64 time=0.042 ms
# 64 bytes from ubuntu-vm2.container-labs_lab-network (172.20.0.3): icmp_seq=5 ttl=64 time=0.055 ms
# ^C
# --- ubuntu-vm2 ping statistics ---
# 5 packets transmitted, 5 received, 0% packet loss, time 4134ms
# rtt min/avg/max/mdev = 0.042/0.093/0.256/0.081 ms
# root@9069153b62d5:/#
```

### Monitoring

- Access Prometheus at http://localhost:9090
- Access Grafana at http://localhost:3000 (default login: admin/admin)
- Access Alertmanager at http://localhost:9093

### Services

- ubuntu-vm1: An Ubuntu VM running in a Docker container.
- ubuntu-vm2: An Ubuntu VM running in a Docker container.
- prometheus: A Prometheus server for monitoring.
- grafana: A Grafana server for visualization.
- alertmanager: An Alertmanager server for alerting
