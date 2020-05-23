#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Eproducts.IDP/Eproducts.IDP.csproj", "Eproducts.IDP/"]
RUN dotnet restore "Eproducts.IDP/Eproducts.IDP.csproj"
COPY . .
WORKDIR "/src/Eproducts.IDP"
RUN dotnet build "Eproducts.IDP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Eproducts.IDP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Eproducts.IDP.dll"]