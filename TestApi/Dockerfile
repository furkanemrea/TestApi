FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build-env
WORKDIR /app

COPY *.csproj .

RUN dotnet restore 
COPY . ./

RUN dotnet publish --no-restore -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestApi.dll"]