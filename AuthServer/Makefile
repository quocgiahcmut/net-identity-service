build-schema:
	rm -rf "Data/Migrations"

	dotnet ef migrations add Users -c ApplicationDbContext -o Data/Migrations/ApplicationDb

	dotnet ef migrations add Grants -c PersistedGrantDbContext -o Data/Migrations/PersistedGrantDb
	dotnet ef migrations add Configuration -c ConfigurationDbContext -o Data/Migrations/ConfigurationDb

	dotnet ef migrations script -c ApplicationDbContext -o Data/Migrations/ApplicationDb.sql
	dotnet ef migrations script -c PersistedGrantDbContext -o Data/Migrations/PersistedGrantDb.sql
	dotnet ef migrations script -c ConfigurationDbContext -o Data/Migrations/ConfigurationDb.sql

updatedb:
	dotnet ef database update --context ApplicationDbContext

	dotnet ef database update --context PersistedGrantDbContext

	dotnet ef database update --context ConfigurationDbContext

	echo Database Update Done!

dropdb:
	dotnet ef database drop --context ApplicationDbContext

	dotnet ef database drop --context PersistedGrantDbContext

	dotnet ef database drop --context ConfigurationDbContext

	echo Database Drop Done!