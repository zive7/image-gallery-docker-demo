#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Common", "Common/"]
COPY ["ImageGallery.Web", "ImageGallery.Web/"]

RUN dotnet publish "/src/ImageGallery.Web/ImageGallery.Web.csproj" --configfile /src/Common/Docker/nuget.config -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ImageGallery.Web.dll"]