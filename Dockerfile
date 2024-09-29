# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:6c4df091e4e531bb93bdbfe7e7f0998e7ced344f54426b7e874116a3dc3233ff
WORKDIR /app
COPY ./bin/Release/net8.0/publish/  .
ENTRYPOINT ["dotnet","Pozdrav.dll"]