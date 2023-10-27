# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine-amd64
WORKDIR /publish
COPY --from=publish /App/out .
ENTRYPOINT ["portfolio.api.exe", "portfolio.api.dll"]