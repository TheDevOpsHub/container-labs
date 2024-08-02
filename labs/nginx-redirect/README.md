# Nginx redirect proxy lab

## 1. Labs stack

- [nginx-webserver1](https://nginx.org/): An Ubuntu VM running in nginx webserver.
- [nginx-webserver2](https://nginx.org/): An Ubuntu VM running in nginx webserver.
- [nginx-redirect](https://nginx.org/): Nginx proxy points to the web servers.

## 2. Setup

### Prerequisites

- Docker + Docker Compose

### Build and run the containers

```bash
cd labs/nginx-redirect
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

## 3. Explore the Nginx redirect feature

- Access the Nginx Proxy at http://localhost:6087 (You can replace `6087` by the port work on your machine!)
  - Traffic will to `web-server1`
- Access the Nginx Proxy at http://localhost:6087/cms (You can replace `6087` by the port work on your machine!)
  - It will redirect to `web-server2`
