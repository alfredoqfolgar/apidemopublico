#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY ApiCotizaciones/ApiCotizaciones.csproj ./ApiCotizaciones/
COPY Aplication/Aplication.csproj  ./Aplication/
COPY Domain/Domain.csproj ./Domain/
COPY Infrastructure/Infrastructure.csproj ./Infrastructure/
RUN ls
RUN dotnet restore "ApiCotizaciones/ApiCotizaciones.csproj"
COPY . .
WORKDIR "/src/ApiCotizaciones"
RUN dotnet build "ApiCotizaciones.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiCotizaciones.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiCotizaciones.dll"]