# HA proxy lab

## 1. Labs stack

- nginx-webserver1: An Ubuntu VM running in nginx webserver.
- nginx-webserver2: An Ubuntu VM running in nginx webserver.
- haproxy: HA proxy point 2 these web servers

## 2. Setup

### Prerequisites

- Docker + Docker Compose

### Build and run the containers

- Option-1: Build and run in background (Recommend)

```bash
cd labs/haproxy-lab
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

- Option-2: Run and verbose the logs

```bash
cd labs/haproxy-lab
docker-compose up --build

# To stop, press 'Ctrl + C'
```

## 3. Explore the resources

### Access services

- Access the HA Proxy at http://localhost:6081 (You can replace 6081 by the port work on your machine!)
