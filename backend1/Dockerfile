FROM microsoft/dotnet:sdk
WORKDIR /backend1
COPY . .

RUN dotnet restore
RUN dotnet build
RUN dotnet publish

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

RUN chmod +x ./wait-for-postgres.sh
ENTRYPOINT [ "/bin/bash", "./wait-for-postgres.sh" ]