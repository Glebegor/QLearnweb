run-dev:
	dotnet run --project src/WebApi/WebApi.csproj dev
run-prod:
	dotnet run --project src/WebApi/WebApi.csproj prod
run-test:
	dotnet run --project src/WebApi/WebApi.csproj test

run-db:
	docker run --name postgres -e POSTGRES_PASSWORD="123321" -p 5432:5432 -d postgres	