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

RUN systemctl enable ssh

# Expose SSH, Node Exporter ports
EXPOSE 22 9100

# Start systemd on container start
CMD ["/lib/systemd/systemd"]