# Jenkins setup lab

## 1. Labs stack

- 1 Jenkins controller
- 1 Jenkins agent

## 2. Setup

### Prerequisites

- Docker + Docker Compose

### Build and run the containers

```bash
cd labs/jenkins/jenkins-controller-setup
docker-compose up --build -d

# To stop and remove contaienr, run:
docker compose down
```

## 3. Explore the Jenkins

- Visit http://localhost:8080/ to explore and use Jenkins
- Get the init password to login (Login admin/initialAdminPassword):

```bash
docker exec jenkins-controller cat /var/jenkins_home/secrets/initialAdminPassword

# 1d86cf0e5fe14608970274adb54ec3ac
```
