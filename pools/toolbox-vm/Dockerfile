FROM ubuntu:22.04

# Set environment variables to avoid interactive installation prompts
ARG DEBIAN_FRONTEND=noninteractive
ARG TZ=UTC

# Update
RUN apt-get update

# Install required packages
RUN apt-get install -y --no-install-recommends \
  ca-certificates \
  curl \
  iputils-ping \
  openssh-client \
  openssh-server

# Set Python version as an argument
ARG PYTHON_VERSION=3.11
# Install Python with specified version
RUN apt install -y python${PYTHON_VERSION} && \
  ln -sf /usr/bin/python3.11 /usr/bin/python3

# Install pip for Python 3.12
RUN curl -k https://bootstrap.pypa.io/get-pip.py -o get-pip.py && \
  python3 get-pip.py && \
  rm get-pip.py

# Install Ansible
# Docs: https://docs.ansible.com/ansible/latest/installation_guide/intro_installation.html#installing-and-upgrading-ansible-with-pip
ARG ANSIBLE_VERSION=2.17.1
RUN python3 -m pip install ansible-core==${ANSIBLE_VERSION}

# Cleanup
RUN apt-get clean && \
  rm -rf /var/lib/apt/lists/*

# Reset environment variables
ENV DEBIAN_FRONTEND teletype
ENV TZ=""

# Define the default command to run when the container starts
CMD ["/bin/bash"]