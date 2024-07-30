FROM jenkins/inbound-agent:latest

USER root

# Install any necessary packages
RUN apt-get update && apt-get install -y \
  curl \
  vim \
  wget

# Copy initialization script
COPY init.sh /init.sh
RUN chmod +x /init.sh

# Set the entrypoint
ENTRYPOINT ["/init.sh"]
