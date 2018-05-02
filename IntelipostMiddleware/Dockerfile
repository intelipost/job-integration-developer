FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY IntelipostMiddleware.sln ./
COPY IntelipostMiddleware/IntelipostMiddleware.Service.csproj IntelipostMiddleware/
COPY IntelipostMiddleware.API/IntelipostMiddleware.API.csproj IntelipostMiddleware.API/
COPY IntelipostMiddleware.Integrations/IntelipostMiddleware.Integrations.csproj IntelipostMiddleware.Integrations/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/IntelipostMiddleware
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IntelipostMiddleware.Service.dll"]