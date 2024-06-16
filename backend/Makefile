run-dev:
	dotnet run --project src/WebApi/WebApi.csproj dev
run-prod:
	dotnet run --project src/WebApi/WebApi.csproj prod
run-test:
	dotnet run --project src/WebApi/WebApi.csproj test

run-dev-db:
	docker run --name="qlearn-dev-db" -e POSTGRES_PASSWORD="123321" -p 5436:5432 -d --rm postgres	
run-prod-db:
	docker run --name="qlearn-prod-db" -e POSTGRES_PASSWORD="qlearnProduct#123321" -p 4356:5432 -d --rm postgres	
run-test-db:
	docker run --name="qlearn-test-db" -e POSTGRES_PASSWORD="123321" -p 8745:5432 -d --rm postgres	
	
run-create-migrates:
	dotnet ef migrations add InitialCreate --project ./src/Core/Core.csproj --startup-project ./src/WebApi/WebApi.csproj

run-update-migrates:
	dotnet ef database update --project ./src/Core/Core.csproj --startup-project ./src/WebApi/WebApi.csproj
