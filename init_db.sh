#!/bin/bash
set -e

psql -v ON_ERROR_STOP=1 --username "postgres" --dbname "postgres" <<-EOSQL
    CREATE USER webapp WITH PASSWORD 'qwerty';
    CREATE DATABASE adminpanel WITH OWNER 'webapp';
EOSQL

psql -v ON_ERROR_STOP=1 --username "webapp" --dbname "adminpanel" <<-EOSQL
    CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
EOSQL