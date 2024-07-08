# Use the official PostgreSQL image from Docker Hub
FROM postgres:latest

# Copy the initialization SQL script
COPY init.sql /docker-entrypoint-initdb.d/

# Expose the default PostgreSQL port
EXPOSE 5432
