FROM ubuntu:22.04
RUN apt-get update && apt-get install -y \
  supervisor \
  iputils-ping \
  openssh-client \
  # allow other containers SSH into this container
  openssh-server \
  && rm -rf /var/lib/apt/lists/*
COPY supervisord.conf /etc/supervisor/conf.d/supervisord.conf
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
EXPOSE 22
CMD ["/entrypoint.sh"]
