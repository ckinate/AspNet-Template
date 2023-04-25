#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/FinTrakERP.Migrator/FinTrakERP.Migrator.csproj", "src/FinTrakERP.Migrator/"]
COPY ["src/FinTrakERP.EntityFrameworkCore/FinTrakERP.EntityFrameworkCore.csproj", "src/FinTrakERP.EntityFrameworkCore/"]
COPY ["src/FinTrakERP.Core/FinTrakERP.Core.csproj", "src/FinTrakERP.Core/"]
COPY ["src/FinTrakERP.Core.Shared/FinTrakERP.Core.Shared.csproj", "src/FinTrakERP.Core.Shared/"]
RUN dotnet restore "src/FinTrakERP.Migrator/FinTrakERP.Migrator.csproj"
COPY . .
WORKDIR "/src/src/FinTrakERP.Migrator"
RUN dotnet build "FinTrakERP.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinTrakERP.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinTrakERP.Migrator.dll"]
