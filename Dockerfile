ARG BASE_DOTNET_SDK_IMAGE="mcr.microsoft.com/dotnet/sdk:8.0"
ARG BASE_DOTNET_RUNTIME_IMAGE="mcr.microsoft.com/dotnet/aspnet:8.0"
ARG VERSION="1.0"

#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
FROM $BASE_DOTNET_SDK_IMAGE AS build-env
WORKDIR /app

ARG nuget_repo="https://api.nuget.org/v3/index.json"
ARG nuget_user="000"
ARG nuget_password="000"

RUN mkdir obj
COPY . ./

RUN dotnet nuget remove source nuget.org && \
dotnet nuget add source $nuget_repo -n myTeam -u $nuget_user -p $nuget_password --store-password-in-clear-text && \
dotnet restore "WbSailerNotifier/WbSailerNotifier.csproj" && \
dotnet publish "WbSailerNotifier/WbSailerNotifier.csproj" -c Release -o /app/out

WORKDIR /app
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS build
FROM $BASE_DOTNET_RUNTIME_IMAGE as build

WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "WbSailerNotifier.dll"]