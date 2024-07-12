# HA proxy lab

## 1. Labs stack

- nginx-webserver1: An Ubuntu VM running in nginx webserver.
- nginx-webserver2: An Ubuntu VM running in nginx webserver.
- haproxy: HA proxy points to 2 these web servers

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
- Refresh the page multiple time and you would see that the HA Proxy route to `server1` and `server2` in Round Robin mode.

  ![server1](./assets/server1.png)
  ![server2](./assets/server2.png)

- Now try to stop the `server1` and refresh the page http://localhost:6081, it will check and only route to `server2`

  ```bash
  docker stop nginx-webserver1
  ```

  ![server2](./assets/server2.png)
  ![server2](./assets/server2.png)
