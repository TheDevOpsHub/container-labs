#!/bin/sh

# Custom setup commands
echo "Running custom setup..."

# Start the Jenkins agent
exec /usr/local/bin/jenkins-agent "$@"
