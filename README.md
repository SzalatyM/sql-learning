# sql-learning

## How to run the database

1. Download and install [Docker Desktop](https://www.docker.com/products/docker-desktop/)

2. Open command prompt and go to the directory with `sql-learning` repository.

> cd .\sql-learning\

3. Run the below command to run database on your machine

> docker-compose up -d

## How to use the database

1. Open `http://localhost:5050/` in the browser

2. Log in with the below credentials

| Email | Password |
| ----------- | ----------- |
| admin@admin.pl | password |

3. Register a new server by right click on `Servers` then `Register` then `Server...`

4. On the `General` tab choose the name, for example `database`

5. On the `Connection` tab fill the inputs as follow

| Hostname/address | Port | Maintenance database | Username | Password |
| ----------- | ----------- | ----------- | ----------- | ----------- |
| postgresdb | 5432 | postgres | postgres | password |




