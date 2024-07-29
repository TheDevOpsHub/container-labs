# Nginx https proxy lab

## 1. Labs stack

- [nginx-webserver1](https://nginx.org/): An Ubuntu VM running in nginx webserver.
- [nginx-proxy](https://nginx.org/): Nginx proxy points to the web servers.

## 2. Setup

### Prerequisites

- Docker + Docker Compose

### Generate a self-signed SSL certificate

Generate a self-signed SSL certificate and key in the nginx-proxy/ssl directory. You can use OpenSSL to generate these files:

```bash
cd labs/nginx-https-lab
mkdir -p nginx-proxy/ssl
cd nginx-proxy/ssl
openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout nginx.key -out nginx.crt -subj "/CN=localhost"
```

### Build and run the containers

```bash
cd labs/nginx-https-lab
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

## 3. Explore the Nginx proxy

- Access the Nginx Proxy at https://localhost:6083 (You can replace 6083 by the port work on your machine!)
- Refresh the page multiple time and you would see that the Nginx Proxy route to `nginx-webserver1`
