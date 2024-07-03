FROM ubuntu:22.04
RUN apt-get update && apt-get install -y \
  supervisor \
  iputils-ping \
  openssh-client \
  # allow other containers SSH into this container
  openssh-server \
  && rm -rf /var/lib/apt/lists/*
# Configure SSH
RUN mkdir /var/run/sshd \
  && echo 'root:docker' | chpasswd \
  && sed -i 's/#PermitRootLogin prohibit-password/PermitRootLogin yes/' /etc/ssh/sshd_config \
  && echo "export VISIBLE=now" >> /etc/profile

# Configure supervisor to manage ssh service
COPY supervisord.conf /etc/supervisor/conf.d/supervisord.conf

# Expose SSH port
EXPOSE 22

# Start supervisor
CMD ["/usr/bin/supervisord", "-c", "/etc/supervisor/conf.d/supervisord.conf"]