# Izberi osnovno sliko .NET Runtime, ki podpira poganjanje .exe datotek
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base

# Nastavi delovno mapo znotraj kontejnerja
WORKDIR /app

# Kopiraj lokalno .exe datoteko v Docker image
COPY ./Pozdrav/Pozdrav/bin/Debug/net8.0/ .
# Kopiraj README.md (ali druge datoteke, ki jih program potrebuje)
#COPY ./README.md .

# Zaženi .exe datoteko, ko kontejner zaženeš
CMD ["./Pozdrav.exe"]
