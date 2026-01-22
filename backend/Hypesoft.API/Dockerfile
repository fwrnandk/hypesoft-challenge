# Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY backend/*.sln ./backend/
COPY backend/Hypesoft.Domain backend/Hypesoft.Domain
COPY backend/Hypesoft.Application backend/Hypesoft.Application
COPY backend/Hypesoft.Infrastructure backend/Hypesoft.Infrastructure
COPY backend/Hypesoft.API backend/Hypesoft.API

WORKDIR /app/backend/Hypesoft.API
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/backend/Hypesoft.API/out .
EXPOSE 8080

ENTRYPOINT ["dotnet", "Hypesoft.API.dll"]
