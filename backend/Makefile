rundb:
	docker run --name=qlearn-db -e POSTGRES_PASSWORD="123321" -p 5436:5432 -d --rm postgres
migrateup:
	python3 ./Migrates/migratesup.py
migratedown:
	python3 ./Migrates/migratesdown.py