FROM ubuntu:22.04
RUN apt-get update && apt-get install -y \
  supervisor \
  iputils-ping \
  && rm -rf /var/lib/apt/lists/*
COPY supervisord.conf /etc/supervisor/conf.d/supervisord.conf
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
CMD ["/entrypoint.sh"]
