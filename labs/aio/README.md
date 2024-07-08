# AIO labs

## Labs stack

- ubuntu-vm1: An Ubuntu VM running in a Docker container.
- ubuntu-vm2: An Ubuntu VM running in a Docker container.
- prometheus: A Prometheus server for monitoring.
- grafana: A Grafana server for visualization.
- alertmanager: An Alertmanager server for alerting
- elk: An ELK server for logging

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
cd labs/aio
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

- Option-2: Run and verbose the logs

```bash
cd labs/aio
docker-compose up --build

# To stop, press 'Ctrl + C'
```

## Explore the resources

### Access the VM

- Access the VM1 and try to ping VM2 via lab-network

```bash
docker exec -it --network aio_lab-network ubuntu-vm1 bash
## To check docker network availble, run: docker network ls
## Sample result:
# ➜  ~ docker exec -it ubuntu-vm1 bash
# root@eefb8f36c1f6:/# ping ubuntu-vm2
# PING ubuntu-vm2 (172.20.0.2) 56(84) bytes of data.
# 64 bytes from ubuntu-vm2.aio_lab-network (172.20.0.2): icmp_seq=1 ttl=64 time=0.062 ms
# 64 bytes from ubuntu-vm2.aio_lab-network (172.20.0.2): icmp_seq=2 ttl=64 time=0.074 ms
# 64 bytes from ubuntu-vm2.aio_lab-network (172.20.0.2): icmp_seq=3 ttl=64 time=0.072 ms
# 64 bytes from ubuntu-vm2.aio_lab-network (172.20.0.2): icmp_seq=4 ttl=64 time=0.076 ms
# 64 bytes from ubuntu-vm2.aio_lab-network (172.20.0.2): icmp_seq=5 ttl=64 time=0.093 ms
# ^C
# --- ubuntu-vm2 ping statistics ---
# 5 packets transmitted, 5 received, 0% packet loss, time 4150ms
# rtt min/avg/max/mdev = 0.062/0.075/0.093/0.010 ms
# root@eefb8f36c1f6:/#
```

### Setup Node Exporter on 2 VM

- Use toolbox VM: [toolbox-vm](../../pools/toolbox-vm/) env
- Run

```bash
# Start the toolbox VM
docker run -it --network aio_lab-network \
           -v /mnt/d/CODING/GITHUB/TheDevOpsHub/container-labs/src/ansible:/tmp/ansible \
           container-labs-toolbox-vm bash

#########################
## root@dcd0c02bf4ec:/#
#########################
ssh-keygen -t rsa
# Ensure from the toolbox VM we can ssh to the 2 ubuntu VM
ssh-copy-id root@ubuntu-vm1
ssh-copy-id root@ubuntu-vm2

# Install the community prometheus.prometheus role
ansible-galaxy collection install prometheus.prometheus

# NOTE: Select yes to proccess
# Now run playbook in the container
cd /tmp/ansible
ansible-playbook -i inventory.ini node-exporter-setup.yml

# We now can access to the ubuntu VMs to check new service
ssh-copy-id root@ubuntu-vm1 # root@ubuntu-vm2
systemctl status node_exporter
```

### Access services

<!-- Monitoring -->

- Access Prometheus at http://localhost:9090
- Access Grafana at http://localhost:3000 (default login: admin/admin)
- Access Alertmanager at http://localhost:9093
<!-- Logging -->
- Access Elasticsearch at http://localhost:9200
- Access Kibana at http://localhost:5601
