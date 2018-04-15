FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Integration.sln ./
COPY src/Integration.Api.Produto/Integration.Api.Produto.csproj src/Integration.Api.Produto/
COPY src/Integration.Domain.Entities/Integration.Domain.Entities.csproj src/Integration.Domain.Entities/
COPY src/Integration.Ioc/Integration.Ioc.csproj src/Integration.Ioc/
COPY src/Integration.Infra.Data/Integration.Infra.Data.csproj src/Integration.Infra.Data/
COPY src/Integration.Application/Integration.Application.csproj src/Integration.Application/
COPY src/Integration.CrossCuting.Tools/Integration.CrossCuting.Tools.csproj src/Integration.CrossCuting.Tools/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/src/Integration.Api.Produto
RUN dotnet build Integration.Api.Produto.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Integration.Api.Produto.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Integration.Api.Produto.dll"]
