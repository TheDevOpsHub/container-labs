# Nginx proxy lab

## 1. Labs stack

- [nginx-webserver1](https://nginx.org/): An Ubuntu VM running in nginx webserver.
- [nginx-proxy](https://nginx.org/): Nginx proxy points to the web servers.

## 2. Setup

### Prerequisites

- Docker + Docker Compose

### Build and run the containers

```bash
cd labs/nginx/nginx-basic
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

## 3. Explore the Nginx proxy

- Access the Nginx Proxy at http://localhost:6082 (You can replace 6082 by the port work on your machine!)
- Refresh the page multiple time and you would see that the Nginx Proxy route to `nginx-webserver1`
