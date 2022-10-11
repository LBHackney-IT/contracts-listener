FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ENV DynamoDb_LocalMode='true'
ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ContractsListener.sln ./
COPY ./ContractsListener/ContractsListener.csproj ./ContractsListener/
COPY ./ContractsListener.Tests/ContractsListener.Tests.csproj ./ContractsListener.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./ContractsListener/ContractsListener.csproj
RUN dotnet restore ./ContractsListener.Tests/ContractsListener.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out ContractsListener.Tests/ContractsListener.Tests.csproj

CMD dotnet test
