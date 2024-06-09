import psycopg2
import os

# Database connection parameters
DB_PARAMS = {
    'dbname': 'postgres',
    'user': 'postgres',
    'password': '123321',
    'host': 'localhost',
    'port': '5436'
}

conn = psycopg2.connect(**DB_PARAMS)

with open("./Migrates/0000001_init.down.sql", 'r') as file:
    sql = file.read()
    
with conn.cursor() as cursor:
    cursor.execute(sql)
    
conn.commit()
    
