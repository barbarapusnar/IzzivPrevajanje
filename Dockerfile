# Izberi osnovno sliko .NET Runtime, ki podpira poganjanje .exe datotek
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base

# Nastavi delovno mapo znotraj kontejnerja
WORKDIR /app

# Kopiraj lokalno .exe datoteko v Docker image
COPY ./Pozdrav/Pozdrav/bin/Debug/net8.0/Pozdrav.exe /app/

# Kopiraj README.md (ali druge datoteke, ki jih program potrebuje)
#COPY ./README.md .

# Dodaj izvedbena dovoljenja za .exe datoteko
RUN chmod +x Pozdrav.exe

# Zaženi .exe datoteko, ko kontejner zaženeš
CMD ["./Pozdrav.exe"]
