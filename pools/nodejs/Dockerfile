# Use the official Node.js image from Docker Hub
FROM node:latest

# Create app directory
WORKDIR /usr/src/app

# Install app dependencies
COPY package.json ./
RUN npm install

# Bundle app source
COPY . .

# Expose the port the app runs on
EXPOSE 5000

# Command to run the app
CMD [ "node", "server.js" ]
