FROM mcr.microsoft.com/dotnet/sdk:8.0

# Copy the project file and restore dependencies
COPY ["fingerprint-pro-server-api-dotnet-sdk.sln", "./"]
# LICENSE is required for building the package
COPY ["LICENSE", "./"]
COPY ["res", "res/"]
COPY ["src/FingerprintPro.ServerSdk/FingerprintPro.ServerSdk.csproj", "src/FingerprintPro.ServerSdk/"]
COPY ["src/FingerprintPro.ServerSdk.Examples/FingerprintPro.ServerSdk.Examples.csproj", "src/FingerprintPro.ServerSdk.Examples/"]
COPY ["src/FingerprintPro.ServerSdk.FunctionalTest/FingerprintPro.ServerSdk.FunctionalTest.csproj", "src/FingerprintPro.ServerSdk.FunctionalTest/"]
COPY ["src/FingerprintPro.ServerSdk.SealedResultExample/FingerprintPro.ServerSdk.SealedResultExample.csproj", "src/FingerprintPro.ServerSdk.SealedResultExample/"]
COPY ["src/FingerprintPro.ServerSdk.Test/FingerprintPro.ServerSdk.Test.csproj", "src/FingerprintPro.ServerSdk.Test/"]
COPY ["src/FingerprintPro.ServerSdk.WebhookExample/FingerprintPro.ServerSdk.WebhookExample.csproj", "src/FingerprintPro.ServerSdk.WebhookExample/"]
RUN dotnet restore
COPY ["./src", "src/"]
CMD ["dotnet", "list", "package"]