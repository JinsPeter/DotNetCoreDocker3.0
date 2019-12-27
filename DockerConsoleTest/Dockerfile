FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["DockerConsoleTest/DockerConsoleTest.csproj", "DockerConsoleTest/"]
RUN dotnet restore "DockerConsoleTest/DockerConsoleTest.csproj"
COPY . .
WORKDIR "/src/DockerConsoleTest"
RUN dotnet build "DockerConsoleTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerConsoleTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerConsoleTest.dll"]
