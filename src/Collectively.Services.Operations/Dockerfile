FROM microsoft/dotnet:2.0.0-runtime
WORKDIR /dotnetapp
COPY ./bin/Docker .
ENV ASPNETCORE_URLS http://*:10001
ENV ASPNETCORE_ENVIRONMENT docker
ENTRYPOINT dotnet Collectively.Services.Operations.dll