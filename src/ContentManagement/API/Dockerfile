#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Apollo.OpenAssesment.ContentManagement/Apollo.OpenAssesment.ContentManagement.csproj", "Apollo.OpenAssesment.ContentManagement/"]
RUN dotnet restore "Apollo.OpenAssesment.ContentManagement/Apollo.OpenAssesment.ContentManagement.csproj"
COPY . .
WORKDIR "/src/Apollo.OpenAssesment.ContentManagement"
RUN dotnet build "Apollo.OpenAssesment.ContentManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Apollo.OpenAssesment.ContentManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Apollo.OpenAssesment.ContentManagement.dll"]