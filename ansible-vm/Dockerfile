FROM ubuntu:latest
RUN apt-get update && apt-get install -y \
  ansible \
  openssh-client \
  && rm -rf /var/lib/apt/lists/*
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
CMD ["/entrypoint.sh"]
