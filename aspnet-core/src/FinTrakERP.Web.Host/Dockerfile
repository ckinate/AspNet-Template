#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/FinTrakERP.Web.Host/FinTrakERP.Web.Host.csproj", "src/FinTrakERP.Web.Host/"]
COPY ["src/FinTrakERP.Web.Core/FinTrakERP.Web.Core.csproj", "src/FinTrakERP.Web.Core/"]
COPY ["src/FinTrakERP.Application/FinTrakERP.Application.csproj", "src/FinTrakERP.Application/"]
COPY ["src/FinTrakERP.Application.Shared/FinTrakERP.Application.Shared.csproj", "src/FinTrakERP.Application.Shared/"]
COPY ["src/FinTrakERP.Core.Shared/FinTrakERP.Core.Shared.csproj", "src/FinTrakERP.Core.Shared/"]
COPY ["src/FinTrakERP.Core/FinTrakERP.Core.csproj", "src/FinTrakERP.Core/"]
COPY ["src/FinTrakERP.EntityFrameworkCore/FinTrakERP.EntityFrameworkCore.csproj", "src/FinTrakERP.EntityFrameworkCore/"]
COPY ["src/FinTrakERP.GraphQL/FinTrakERP.GraphQL.csproj", "src/FinTrakERP.GraphQL/"]
RUN dotnet restore "src/FinTrakERP.Web.Host/FinTrakERP.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/FinTrakERP.Web.Host"
RUN dotnet build "FinTrakERP.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinTrakERP.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinTrakERP.Web.Host.dll"]
